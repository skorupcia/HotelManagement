namespace Hotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            Login = new Guna.UI2.WinForms.Guna2TextBox();
            pictureBox1 = new PictureBox();
            Password = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(263, 184);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 0;
            label1.Text = "Panel logowania";
            // 
            // Login
            // 
            Login.CustomizableEdges = customizableEdges5;
            Login.DefaultText = "";
            Login.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Login.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Login.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Login.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Login.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Login.Font = new Font("Segoe UI", 9F);
            Login.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Login.Location = new Point(159, 285);
            Login.Name = "Login";
            Login.PasswordChar = '\0';
            Login.PlaceholderText = "";
            Login.SelectedText = "";
            Login.ShadowDecoration.CustomizableEdges = customizableEdges6;
            Login.Size = new Size(422, 36);
            Login.TabIndex = 1;
            Login.TextChanged += guna2TextBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(294, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Password
            // 
            Password.CustomizableEdges = customizableEdges7;
            Password.DefaultText = "";
            Password.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Password.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Password.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Password.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Password.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Password.Font = new Font("Segoe UI", 9F);
            Password.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Password.Location = new Point(159, 380);
            Password.Name = "Password";
            Password.PasswordChar = '●';
            Password.PlaceholderText = "";
            Password.SelectedText = "";
            Password.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Password.Size = new Size(422, 36);
            Password.TabIndex = 3;
            Password.UseSystemPasswordChar = true;
            Password.TextChanged += guna2TextBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(329, 257);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 4;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(329, 352);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 5;
            label3.Text = "Hasło";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.quit;
            pictureBox3.Location = new Point(707, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(294, 435);
            button1.Name = "button1";
            button1.Size = new Size(130, 40);
            button1.TabIndex = 7;
            button1.Text = "Zaloguj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(749, 570);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Password);
            Controls.Add(pictureBox1);
            Controls.Add(Login);
            Controls.Add(label1);
            Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Login;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox Password;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox3;
        private Button button1;
    }
}
