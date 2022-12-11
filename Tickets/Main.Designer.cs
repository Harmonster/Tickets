
namespace Tickets
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_main = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_ticket_list = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_createTicket = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_misc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_priority = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.tb_misc = new System.Windows.Forms.TextBox();
            this.cb_staff = new System.Windows.Forms.ComboBox();
            this.cb_priority = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.pnl_main.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ticket_list)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.panel2);
            this.pnl_main.Controls.Add(this.panel1);
            this.pnl_main.Controls.Add(this.pnl_right);
            this.pnl_main.Controls.Add(this.pnl_left);
            this.pnl_main.Controls.Add(this.pnl_top);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1002, 599);
            this.pnl_main.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_ticket_list);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(15, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(972, 569);
            this.panel2.TabIndex = 4;
            // 
            // dgv_ticket_list
            // 
            this.dgv_ticket_list.AllowUserToAddRows = false;
            this.dgv_ticket_list.AllowUserToDeleteRows = false;
            this.dgv_ticket_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ticket_list.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_ticket_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ticket_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ticket_list.Location = new System.Drawing.Point(0, 0);
            this.dgv_ticket_list.Name = "dgv_ticket_list";
            this.dgv_ticket_list.RowHeadersVisible = false;
            this.dgv_ticket_list.RowHeadersWidth = 51;
            this.dgv_ticket_list.RowTemplate.Height = 24;
            this.dgv_ticket_list.Size = new System.Drawing.Size(756, 569);
            this.dgv_ticket_list.TabIndex = 1;
            this.dgv_ticket_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ticket_list_CellContentClick);
            this.dgv_ticket_list.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ticket_list_CellContentDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_createTicket);
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Controls.Add(this.lbl_misc);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbl_priority);
            this.panel3.Controls.Add(this.lbl_status);
            this.panel3.Controls.Add(this.lbl_type);
            this.panel3.Controls.Add(this.tb_misc);
            this.panel3.Controls.Add(this.cb_staff);
            this.panel3.Controls.Add(this.cb_priority);
            this.panel3.Controls.Add(this.cb_status);
            this.panel3.Controls.Add(this.cb_type);
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(756, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 569);
            this.panel3.TabIndex = 0;
            // 
            // btn_createTicket
            // 
            this.btn_createTicket.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_createTicket.Location = new System.Drawing.Point(0, 441);
            this.btn_createTicket.Name = "btn_createTicket";
            this.btn_createTicket.Size = new System.Drawing.Size(214, 42);
            this.btn_createTicket.TabIndex = 0;
            this.btn_createTicket.Text = "Создать запрос";
            this.btn_createTicket.UseVisualStyleBackColor = true;
            this.btn_createTicket.Click += new System.EventHandler(this.btn_createTicket_Click);
            // 
            // btn_update
            // 
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_update.Location = new System.Drawing.Point(0, 483);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(214, 42);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Обновить запрос";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_misc
            // 
            this.lbl_misc.AutoSize = true;
            this.lbl_misc.Location = new System.Drawing.Point(16, 249);
            this.lbl_misc.Name = "lbl_misc";
            this.lbl_misc.Size = new System.Drawing.Size(58, 17);
            this.lbl_misc.TabIndex = 10;
            this.lbl_misc.Text = "Детали";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Автор";
            // 
            // lbl_priority
            // 
            this.lbl_priority.AutoSize = true;
            this.lbl_priority.Location = new System.Drawing.Point(16, 138);
            this.lbl_priority.Name = "lbl_priority";
            this.lbl_priority.Size = new System.Drawing.Size(80, 17);
            this.lbl_priority.TabIndex = 8;
            this.lbl_priority.Text = "Приоритет";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(16, 80);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(53, 17);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "Статус";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(16, 22);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(33, 17);
            this.lbl_type.TabIndex = 6;
            this.lbl_type.Text = "Тип";
            // 
            // tb_misc
            // 
            this.tb_misc.Location = new System.Drawing.Point(16, 269);
            this.tb_misc.Multiline = true;
            this.tb_misc.Name = "tb_misc";
            this.tb_misc.Size = new System.Drawing.Size(177, 131);
            this.tb_misc.TabIndex = 5;
            // 
            // cb_staff
            // 
            this.cb_staff.FormattingEnabled = true;
            this.cb_staff.Location = new System.Drawing.Point(16, 211);
            this.cb_staff.Name = "cb_staff";
            this.cb_staff.Size = new System.Drawing.Size(177, 24);
            this.cb_staff.TabIndex = 4;
            // 
            // cb_priority
            // 
            this.cb_priority.FormattingEnabled = true;
            this.cb_priority.Location = new System.Drawing.Point(16, 158);
            this.cb_priority.Name = "cb_priority";
            this.cb_priority.Size = new System.Drawing.Size(177, 24);
            this.cb_priority.TabIndex = 3;
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(16, 100);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(177, 24);
            this.cb_status.TabIndex = 2;
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(16, 45);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(177, 24);
            this.cb_type.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_delete.Location = new System.Drawing.Point(0, 525);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(214, 42);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Удалить запрос";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(15, 584);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 15);
            this.panel1.TabIndex = 3;
            // 
            // pnl_right
            // 
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_right.Location = new System.Drawing.Point(987, 15);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(15, 584);
            this.pnl_right.TabIndex = 2;
            // 
            // pnl_left
            // 
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 15);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(15, 584);
            this.pnl_left.TabIndex = 1;
            // 
            // pnl_top
            // 
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1002, 15);
            this.pnl_top.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 599);
            this.Controls.Add(this.pnl_main);
            this.Name = "Main";
            this.Text = "Открытые запросы";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnl_main.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ticket_list)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_ticket_list;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_createTicket;
        private System.Windows.Forms.ComboBox cb_staff;
        private System.Windows.Forms.ComboBox cb_priority;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.TextBox tb_misc;
        private System.Windows.Forms.Label lbl_misc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_priority;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
    }
}

