using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Hotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Wprowadż dane");
            }
            else
            {
                if (Login.Text == "Admin" && Password.Text == "Admin")
                {
                    Guests Obj = new Guests();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nieprawidłowe dane");
                    Login.Text = "";
                    Password.Text = "";
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
