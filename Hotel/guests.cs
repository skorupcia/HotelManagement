using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class guests : Form
    {
        Functions Con;
        public guests()
        {
            InitializeComponent();
            Con = new Functions();
            ShowGuests();

            GuestsDGV.SelectionChanged += GuestsDGV_SelectionChanged;
        }

        int Key = 0;
        private void GuestsDGV_SelectionChanged(object sender, EventArgs e)
        {
            if (GuestsDGV.SelectedRows.Count > 0)
            {
                ImieTb.Text = GuestsDGV.SelectedRows[0].Cells[1].Value.ToString();
                NazwiskoTb.Text = GuestsDGV.SelectedRows[0].Cells[2].Value.ToString();
                PeselTb.Text = GuestsDGV.SelectedRows[0].Cells[3].Value.ToString();
                CardTb.Text = GuestsDGV.SelectedRows[0].Cells[4].Value.ToString();
                DateTb.Text = GuestsDGV.SelectedRows[0].Cells[5].Value.ToString();

                Key = Convert.ToInt32(GuestsDGV.SelectedRows[0].Cells[0].Value);
            }
            else
            {
                Key = 0;
            }
        }

        private void ShowGuests()
        {
            string Query = "select * from ClientsTb";
            GuestsDGV.DataSource = Con.GetData(Query);
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GuestsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ImieTb.Text == "" || NazwiskoTb.Text == "" || PeselTb.Text == "" || CardTb.Text == "")
            {
                MessageBox.Show("Brak danych");
            }
            else
            {
                try
                {
                    string Imie = ImieTb.Text;
                    string Nazwisko = NazwiskoTb.Text;
                    string Pesel = PeselTb.Text;
                    string Card = CardTb.Text;
                    string Przyjazd = DateTb.Value.ToString("yyyy-MM-dd");

                    string Query = "INSERT INTO ClientsTb (Imie, Nazwisko, Pesel, Card, Przyjazd) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
                    Query = string.Format(Query, Imie, Nazwisko, Pesel, Card, Przyjazd);

                    Con.SetData(Query);
                    MessageBox.Show("Gość dodany pomyślnie");
                    ShowGuests();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Zaznacz Gościa");
            }
            else
            {
                try
                {
                    string Query = "delete from ClientsTb where CNum = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Gość wyrejestrowany pomyślnie!");
                    ShowGuests();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 Obj = new Form1();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Rooms Obj = new Rooms();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            guests Obj = new guests();
            Obj.Show();
            this.Hide();
        }
    }
}
