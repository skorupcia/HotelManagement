using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void CardTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout2_Click(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.Show();
            this.Hide();
        }

        private void roombtn2_Click(object sender, EventArgs e)
        {
            Rooms Obj = new Rooms();
            Obj.Show();
            this.Hide();
        }

        private void guestsbtn2_Click(object sender, EventArgs e)
        {
            guests Obj = new guests();
            Obj.Show();
            this.Hide();
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
            if (Key == 0)
            {
                MessageBox.Show("Zaznacz miejsce");
            }
            else
            {
                try
                {
                    string RoomNumber = RoomNumberTb.Text;
                    string RoomLevel = RoomLevelTb.Text;
                    string Stat = RoomStatus.SelectedItem.ToString();
                    string Query = "delete from RoomsTB where RNum = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Pokój usunięty pomyślnie");
                    ShowRooms();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RoomsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
