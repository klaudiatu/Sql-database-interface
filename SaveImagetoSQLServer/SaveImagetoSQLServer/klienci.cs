using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveImagetoSQLServer
{
    public partial class klienci : Form
    {
        public klienci()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Class1.ConnectDB())

                try
                {
                    //Chnange into dbo.Artysci

                    if (string.IsNullOrWhiteSpace(txbAdres.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");

                    }
                    else if (string.IsNullOrWhiteSpace(txbEmail.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }
                    else if (string.IsNullOrWhiteSpace(txbIdKlienta.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }
                    else if (string.IsNullOrWhiteSpace(txbIdPlatnosci.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }
                    else if (string.IsNullOrWhiteSpace(txbIdZamowienia.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }
                    else if (string.IsNullOrWhiteSpace(txbImie.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }
                    else if (string.IsNullOrWhiteSpace(txbKraj.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }
                    else if (string.IsNullOrWhiteSpace(txbTelefon.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }

                    string sql = "INSERT INTO dbo.Klienci ( IdKlienta, IdZamowienia, IdPlatnosci, ImieiNazwisko, Adres, Kraj, Telefon, Email) " +
                        "values(" + txbIdKlienta.Text + ",'" + txbIdZamowienia.Text + "','" + txbIdPlatnosci.Text + "','" + txbImie.Text + "', " +
                        "'" + txbAdres + "', '" + txbKraj + "', '" + txbTelefon + "','" + txbEmail + "')";

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    displayData();
                    MessageBox.Show(" Zapisane. ");



                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void klienci_Load(object sender, EventArgs e)
        {
            displayData();
        }
        public void displayData()
        {
            using (SqlConnection conn = Class1.ConnectDB())
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from klienci";
                //cmd.ExecuteNonQuery();
                DataTable dtArtysci = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtArtysci);
                dgKlienci.DataSource = dtArtysci;
                conn.Close();
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Class1.ConnectDB())

                try
                {
                    if (string.IsNullOrWhiteSpace(txbIdKlienta.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij pole ID.");
                    }

                    string sql = "DELETE FROM dbo.Klienci WHERE IdKlienta = '" + txbIdKlienta.Text + "'";

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(" Usunięte. ");
                    displayData();


                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txbAdres.Clear();
            txbEmail.Clear();
            txbIdKlienta.Clear();
            txbIdPlatnosci.Clear();
            txbIdZamowienia.Clear();
            txbImie.Clear();
            txbKraj.Clear();
            txbTelefon.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txbIdKlienta.Text))
            {
                MessageBox.Show("Proszę, uzupełnij pole ID");
            }
            else
            {
                using (SqlConnection conn = Class1.ConnectDB())
                {
                    String sql;
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    if (!string.IsNullOrWhiteSpace(txbIdPlatnosci.Text))
                    {
                        sql = "UPDATE dbo.Klienci SET IdPlatnosci ='" + txbIdPlatnosci.Text + "' WHERE IdKlienta ='" + txbIdKlienta.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(txbIdZamowienia.Text))
                    {
                        sql = "UPDATE dbo.Klienci SET IdZamowienia ='" + txbIdZamowienia.Text + "' WHERE IdKlienta ='" + txbIdKlienta.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(txbImie.Text))
                    {
                        sql = "UPDATE dbo.Klienci SET ImieiNazwisko ='" + txbImie.Text + "' WHERE IdKlienta ='" + txbIdKlienta.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(txbKraj.Text))
                    {
                        sql = "UPDATE dbo.Klienci SET Kraj ='" + txbKraj.Text + "' WHERE IdKlienta ='" + txbIdKlienta.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(txbTelefon.Text))
                    {
                        sql = "UPDATE dbo.Klienci SET Telefon ='" + txbTelefon.Text + "' WHERE IdKlienta ='" + txbIdKlienta.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(txbAdres.Text))
                    {
                        sql = "UPDATE dbo.Klienci SET Adres ='" + txbAdres.Text + "' WHERE IdKlienta ='" + txbIdKlienta.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(txbEmail.Text))
                    {
                        sql = "UPDATE dbo.Klienci SET Email ='" + txbEmail.Text + "' WHERE IdKlienta ='" + txbIdKlienta.Text + "'";
                        cmd.CommandText = sql;
                    }

                    cmd.ExecuteNonQuery();
                    DataTable dtArtysci = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtArtysci);
                    dgKlienci.DataSource = dtArtysci;
                    conn.Close();
                    displayData();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Class1.ConnectDB())
            {
                String sql;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                if (!string.IsNullOrWhiteSpace(txbIdKlienta.Text))
                {
                    sql = "SELECT * from dbo.Klienci WHERE IdKlienta LIKE '%" + txbIdKlienta.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbIdPlatnosci.Text))
                {
                    sql = "SELECT * from dbo.Klienci WHERE IdPlatnosci LIKE '%" + txbIdPlatnosci.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbIdZamowienia.Text))
                {
                    sql = "SELECT * from dbo.Klienci WHERE IdZamowienia LIKE '%" + txbIdZamowienia.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbImie.Text))
                {
                    sql = "SELECT * from dbo.Klienci WHERE ImieiNazwisko LIKE '%" + txbImie.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbKraj.Text))
                {
                    sql = "SELECT * from dbo.Klienci WHERE Kraj LIKE '%" + txbKraj.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbTelefon.Text))
                {
                    sql = "SELECT * from dbo.Klienci WHERE Telefon LIKE '%" + txbTelefon.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbAdres.Text))
                {
                    sql = "SELECT * from dbo.Klienci WHERE Adres LIKE '%" + txbAdres.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbEmail.Text))
                {
                    sql = "SELECT * from dbo.Klienci WHERE Email LIKE '%" + txbEmail.Text + "%'";
                    cmd.CommandText = sql;
                }

                cmd.ExecuteNonQuery();
                DataTable dtArtysci = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtArtysci);
                dgKlienci.DataSource = dtArtysci;
                conn.Close();
            }
        }
    }
}
