namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Wprowad¿ dane");
            }
            else
            {
                if (Login.Text == "Admin" && Password.Text == "Admin")
                {
                    guests Obj = new guests();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nieprawid³owe dane");
                    Login.Text = "";
                    Password.Text = "";
                }
            }
        }

    }
}
