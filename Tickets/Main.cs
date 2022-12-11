using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tickets
{
    public partial class Main : Form
    {
        int currId; // Глоб. хранение идентификатора записи
        string currAuthor; // Глоб. хранение автора записи

        public Main()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Запрашиваем список существующих запросов используя хранимую процедуру в БД, и помещаем в DataGridView
        /// </summary>
        private void FillDataGridView()
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetTicketList", Connection);
                MySqlDataAdapter da = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgv_ticket_list.DataSource = dt;

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cmd.Dispose();
                    Connection.Close();
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            FillCombobox(cb_type, "GetTypes", "id_type", "name_type");
            FillCombobox(cb_status, "GetStatuses", "id_status", "name_status");
            FillCombobox(cb_priority, "GetPriorities", "id_priority", "name_priority");
            FillCombobox(cb_staff, "GetStaffList", "id_staff", "name_staff");
            cb_type.SelectedItem = null;
            cb_status.SelectedItem = null;
            cb_priority.SelectedItem = null;
            cb_staff.SelectedItem = null;
        }

        /// <summary>
        /// Отправляем в БД данные запроса
        /// </summary>
        private void btn_createTicket_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("CreateTicket", Connection);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@in_type", cb_type.SelectedValue); // Тип
                    cmd.Parameters.AddWithValue("@in_status", cb_status.SelectedValue); // Статус
                    cmd.Parameters.AddWithValue("@in_prio", cb_priority.SelectedValue); // Приоритет
                    cmd.Parameters.AddWithValue("@in_author", cb_staff.SelectedValue); // Автор
                    cmd.Parameters.AddWithValue("@in_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")); // Текущая дата и время
                    cmd.Parameters.AddWithValue("@in_misc", tb_misc.Text); // Детали
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cmd.Dispose();
                    Connection.Close();
                    FillDataGridView();
                }
            }
        }

        /// <summary>
        /// Запрашиваем данные с таблиц для заполнения элемента combobox
        /// </summary>
        /// <param name="cb">Используемый combobox</param>
        /// <param name="storedFuncName">Имя хранимой процедуры возвращающая список</param>
        /// <param name="colId">Имя колонки с идентификатором</param>
        /// <param name="colName">Имя колонки с названием</param>
        private void FillCombobox(ComboBox cb, string storedFuncName, string colId, string colName)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(storedFuncName, Connection);
                MySqlDataReader rdr;
                DataTable dt = new DataTable();

                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    Connection.Open();
                    rdr = cmd.ExecuteReader();
                    dt.Load(rdr);
                    cb.ValueMember = colId;
                    cb.DisplayMember = colName;
                    cb.DataSource = dt;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cmd.Dispose();
                    Connection.Close();
                    FillDataGridView();
                }
            }
        }

        /// <summary>
        /// Обрабатываем двойное нажатие по ячейке DataGridView, и выводим данные об авторе запроса в MessageBox
        /// </summary>
        private void dgv_ticket_list_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("GetStaffInfoByName", Connection);
                MySqlDataReader rdr;
                try
                {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@in_name", currAuthor);

                        Connection.Open();
                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            string res1 = rdr.GetString(1);
                            string res2 = rdr.GetString(2);
                            string res3 = rdr.GetString(3);
                            string res = res1 + Environment.NewLine + res2 + Environment.NewLine + res3;
                            MessageBox.Show(res, "Автор запроса", MessageBoxButtons.OKCancel);
                        }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cmd.Dispose();
                    Connection.Close();
                }
            }
        }

        /// <summary>
        /// Обновление данных о запросе в БД
        /// </summary>
        private void btn_update_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("UpdateTicketStatus", Connection);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@in_tic_id", currId); // Тип
                    cmd.Parameters.AddWithValue("@in_status_id", cb_status.SelectedValue); // Статус
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    cmd.Dispose();
                    Connection.Close();
                    FillDataGridView();
                }
            }
        }

        /// <summary>
        /// Удаление записи из БД по идентификатору
        /// </summary>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand("DeleteTicketById", Connection);
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@in_id", currId);
                    Connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    FillDataGridView();
                    cmd.Dispose();
                    Connection.Close();
                }
            }
        }

        /// <summary>
        /// Обработчик кликов по ячейке datagridview
        /// </summary>
        private void dgv_ticket_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_ticket_list.Rows[e.RowIndex];
                currId = (int)row.Cells[0].Value;
                currAuthor = (string)row.Cells[4].Value;
            }
        }

    }
}
