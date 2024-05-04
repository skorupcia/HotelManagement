namespace Hotel
{
    partial class Rooms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            RoomsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            roompanel = new Panel();
            guestsbtn2 = new PictureBox();
            roombtn2 = new PictureBox();
            icon2 = new PictureBox();
            exit2 = new PictureBox();
            logout2 = new PictureBox();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            RoomNumberTb = new Guna.UI2.WinForms.Guna2TextBox();
            RoomLevelTb = new Guna.UI2.WinForms.Guna2TextBox();
            RoomStatus = new ComboBox();
            AddBtn = new Button();
            DeleteBtn = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)RoomsDGV).BeginInit();
            roompanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guestsbtn2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roombtn2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exit2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logout2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RoomsDGV
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            RoomsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Cambria", 12F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            RoomsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            RoomsDGV.ColumnHeadersHeight = 4;
            RoomsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Cambria", 12F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            RoomsDGV.DefaultCellStyle = dataGridViewCellStyle6;
            RoomsDGV.GridColor = Color.FromArgb(231, 229, 255);
            RoomsDGV.Location = new Point(277, 106);
            RoomsDGV.Name = "RoomsDGV";
            RoomsDGV.RowHeadersVisible = false;
            RoomsDGV.Size = new Size(819, 529);
            RoomsDGV.TabIndex = 13;
            RoomsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            RoomsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            RoomsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            RoomsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            RoomsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            RoomsDGV.ThemeStyle.BackColor = Color.White;
            RoomsDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            RoomsDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            RoomsDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            RoomsDGV.ThemeStyle.HeaderStyle.Font = new Font("Cambria", 12F);
            RoomsDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            RoomsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            RoomsDGV.ThemeStyle.HeaderStyle.Height = 4;
            RoomsDGV.ThemeStyle.ReadOnly = false;
            RoomsDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            RoomsDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            RoomsDGV.ThemeStyle.RowsStyle.Font = new Font("Cambria", 12F);
            RoomsDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            RoomsDGV.ThemeStyle.RowsStyle.Height = 25;
            RoomsDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            RoomsDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            RoomsDGV.CellContentClick += RoomsDGV_CellContentClick;
            // 
            // roompanel
            // 
            roompanel.BackColor = Color.Tan;
            roompanel.Controls.Add(label1);
            roompanel.Controls.Add(guestsbtn2);
            roompanel.Controls.Add(roombtn2);
            roompanel.Controls.Add(icon2);
            roompanel.Dock = DockStyle.Top;
            roompanel.Location = new Point(0, 0);
            roompanel.Name = "roompanel";
            roompanel.Size = new Size(1108, 68);
            roompanel.TabIndex = 7;
            // 
            // guestsbtn2
            // 
            guestsbtn2.Cursor = Cursors.Hand;
            guestsbtn2.Image = Properties.Resources.guests;
            guestsbtn2.Location = new Point(975, 9);
            guestsbtn2.Name = "guestsbtn2";
            guestsbtn2.Size = new Size(53, 53);
            guestsbtn2.SizeMode = PictureBoxSizeMode.StretchImage;
            guestsbtn2.TabIndex = 21;
            guestsbtn2.TabStop = false;
            guestsbtn2.Click += guestsbtn2_Click;
            // 
            // roombtn2
            // 
            roombtn2.Cursor = Cursors.Hand;
            roombtn2.Image = Properties.Resources.rooms1;
            roombtn2.Location = new Point(1043, 9);
            roombtn2.Name = "roombtn2";
            roombtn2.Size = new Size(53, 53);
            roombtn2.SizeMode = PictureBoxSizeMode.StretchImage;
            roombtn2.TabIndex = 20;
            roombtn2.TabStop = false;
            roombtn2.Click += roombtn2_Click;
            // 
            // icon2
            // 
            icon2.Image = Properties.Resources.logo1;
            icon2.Location = new Point(0, 0);
            icon2.Name = "icon2";
            icon2.Size = new Size(73, 68);
            icon2.SizeMode = PictureBoxSizeMode.StretchImage;
            icon2.TabIndex = 3;
            icon2.TabStop = false;
            // 
            // exit2
            // 
            exit2.Cursor = Cursors.Hand;
            exit2.Image = Properties.Resources.quit;
            exit2.Location = new Point(57, 648);
            exit2.Name = "exit2";
            exit2.Size = new Size(40, 40);
            exit2.SizeMode = PictureBoxSizeMode.StretchImage;
            exit2.TabIndex = 19;
            exit2.TabStop = false;
            exit2.Click += pictureBox3_Click;
            // 
            // logout2
            // 
            logout2.Cursor = Cursors.Hand;
            logout2.Image = Properties.Resources.logout;
            logout2.Location = new Point(11, 648);
            logout2.Name = "logout2";
            logout2.Size = new Size(40, 40);
            logout2.SizeMode = PictureBoxSizeMode.StretchImage;
            logout2.TabIndex = 18;
            logout2.TabStop = false;
            logout2.Click += logout2_Click;
            // 
            // RoomNumberTb
            // 
            RoomNumberTb.CustomizableEdges = customizableEdges5;
            RoomNumberTb.DefaultText = "Numer pokoju";
            RoomNumberTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            RoomNumberTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            RoomNumberTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            RoomNumberTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            RoomNumberTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            RoomNumberTb.Font = new Font("Cambria", 9F);
            RoomNumberTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            RoomNumberTb.Location = new Point(30, 69);
            RoomNumberTb.Name = "RoomNumberTb";
            RoomNumberTb.PasswordChar = '\0';
            RoomNumberTb.PlaceholderText = "";
            RoomNumberTb.SelectedText = "";
            RoomNumberTb.ShadowDecoration.CustomizableEdges = customizableEdges6;
            RoomNumberTb.Size = new Size(200, 34);
            RoomNumberTb.TabIndex = 11;
            RoomNumberTb.TextChanged += CardTb_TextChanged;
            // 
            // RoomLevelTb
            // 
            RoomLevelTb.CustomizableEdges = customizableEdges7;
            RoomLevelTb.DefaultText = "Piętro";
            RoomLevelTb.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            RoomLevelTb.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            RoomLevelTb.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            RoomLevelTb.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            RoomLevelTb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            RoomLevelTb.Font = new Font("Cambria", 9F);
            RoomLevelTb.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            RoomLevelTb.Location = new Point(30, 109);
            RoomLevelTb.Name = "RoomLevelTb";
            RoomLevelTb.PasswordChar = '\0';
            RoomLevelTb.PlaceholderText = "";
            RoomLevelTb.SelectedText = "";
            RoomLevelTb.ShadowDecoration.CustomizableEdges = customizableEdges8;
            RoomLevelTb.Size = new Size(200, 34);
            RoomLevelTb.TabIndex = 14;
            // 
            // RoomStatus
            // 
            RoomStatus.Font = new Font("Cambria", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RoomStatus.FormattingEnabled = true;
            RoomStatus.Items.AddRange(new object[] { "Wolny", "Zarezerwowany", "Sprzątanie", "Wyłączony" });
            RoomStatus.Location = new Point(30, 149);
            RoomStatus.Name = "RoomStatus";
            RoomStatus.Size = new Size(200, 30);
            RoomStatus.TabIndex = 15;
            RoomStatus.Text = "Status pokoju";
            // 
            // AddBtn
            // 
            AddBtn.Cursor = Cursors.Hand;
            AddBtn.Location = new Point(30, 185);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(100, 35);
            AddBtn.TabIndex = 16;
            AddBtn.Text = "Dodaj";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Cursor = Cursors.Hand;
            DeleteBtn.Location = new Point(130, 185);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(100, 35);
            DeleteBtn.TabIndex = 17;
            DeleteBtn.Text = "Usuń";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = AddBtn;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = DeleteBtn;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = RoomsDGV;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tan;
            panel1.Controls.Add(DeleteBtn);
            panel1.Controls.Add(RoomNumberTb);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(RoomLevelTb);
            panel1.Controls.Add(RoomStatus);
            panel1.Location = new Point(12, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 529);
            panel1.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(80, 17);
            label1.Name = "label1";
            label1.Size = new Size(285, 32);
            label1.TabIndex = 22;
            label1.Text = "Zarządzanie Pokojami";
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1108, 700);
            Controls.Add(exit2);
            Controls.Add(logout2);
            Controls.Add(RoomsDGV);
            Controls.Add(roompanel);
            Controls.Add(panel1);
            Font = new Font("Cambria", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Rooms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rooms";
            ((System.ComponentModel.ISupportInitialize)RoomsDGV).EndInit();
            roompanel.ResumeLayout(false);
            roompanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guestsbtn2).EndInit();
            ((System.ComponentModel.ISupportInitialize)roombtn2).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon2).EndInit();
            ((System.ComponentModel.ISupportInitialize)exit2).EndInit();
            ((System.ComponentModel.ISupportInitialize)logout2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView RoomsDGV;
        private Panel roompanel;
        private PictureBox icon2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2TextBox RoomNumberTb;
        private Guna.UI2.WinForms.Guna2TextBox RoomLevelTb;
        private ComboBox RoomStatus;
        private Button AddBtn;
        private Button DeleteBtn;
        private PictureBox exit2;
        private PictureBox logout2;
        private PictureBox roombtn2;
        private PictureBox guestsbtn2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Panel panel1;
        private Label label1;
    }
}