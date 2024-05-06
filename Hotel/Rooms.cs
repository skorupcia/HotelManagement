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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
            Con = new Functions();
            ShowRooms();
        }

        Functions Con;
        private void ShowRooms()
        {
            string Query = "select * from RoomsTb";
            RoomsDGV.DataSource = Con.GetData(Query);
        }

        int Key = 0;
        private void RoomsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (RoomsDGV.SelectedRows.Count > 0)
            {
                RoomNumberTb.Text = RoomsDGV.SelectedRows[0].Cells[1].Value.ToString();
                RoomLevelTb.Text = RoomsDGV.SelectedRows[0].Cells[2].Value.ToString();
                RoomStatus.Text = RoomsDGV.SelectedRows[0].Cells[3].Value.ToString();

                Key = Convert.ToInt32(RoomsDGV.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                Key = 0;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (RoomNumberTb.Text == "" || RoomLevelTb.Text == "" || RoomStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Brak danych");
            }
            else
            {
                try
                {
                    string RoomNumber = RoomNumberTb.Text;
                    string RoomLevel = RoomLevelTb.Text;
                    string Stat = RoomStatus.SelectedItem.ToString();
                    string Query = "Insert into RoomsTB values ('{0}','{1}','{2}')";
                    Query = string.Format(Query, RoomNumber, RoomLevel, Stat);
                    Con.SetData(Query);
                    MessageBox.Show("Pokój dodany pomyślnie");
                    ShowRooms();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RoomsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Guests Obj = new Guests();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Rooms Obj = new Rooms();
            Obj.Show();
            this.Hide();
        }

        private void RoomLevelTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
