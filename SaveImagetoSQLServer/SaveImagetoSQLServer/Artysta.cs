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
    public partial class Artysta : Form
    {
        public Artysta()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Artysta_Load(object sender, EventArgs e)
        {
            displayData();
        }

        public void displayData()
        {
            using (SqlConnection conn = Class1.ConnectDB())
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Artysci";
                //cmd.ExecuteNonQuery();
                DataTable dtArtysci = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtArtysci);
                dgArtysta.DataSource = dtArtysci;
                conn.Close();
            }
        }

        private void btnZaladuj_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Class1.ConnectDB())

                try
                {
                    //Chnange into dbo.Artysci

                    if (string.IsNullOrWhiteSpace(txbIdArtysty.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");

                    }
                    else if (string.IsNullOrWhiteSpace(txbIdNurtu.Text))
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
                    else if (string.IsNullOrWhiteSpace(txbRok.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }

                    string sql = "INSERT INTO dbo.Artysci (IdArtysty, IdNurtu, ImieiNazwisko, Kraj, Rok) " +
                        "values(" + txbIdArtysty.Text + ",'" + txbIdNurtu.Text + "','" + txbImie.Text + "','" + txbKraj.Text + "', '" + txbRok + "')";

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

        private void btnUsun_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Class1.ConnectDB())

                try
                {
                    if (string.IsNullOrWhiteSpace(txbIdArtysty.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij pole ID.");
                    }

                    string sql = "DELETE FROM dbo.Zamowienia WHERE IdArtysty = '" + txbIdArtysty.Text + "'";

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

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Class1.ConnectDB())
            {
                String sql;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                if (!string.IsNullOrWhiteSpace(txbIdArtysty.Text))
                {
                    sql = "SELECT * from dbo.Artysci WHERE IdArtysty LIKE '%" + txbIdArtysty.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbIdNurtu.Text))
                {
                    sql = "SELECT * from dbo.Artysci WHERE IdNurtu LIKE '%" + txbIdNurtu.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbImie.Text))
                {
                    sql = "SELECT * from dbo.Artysci WHERE ImieiNazwisko LIKE '%" + txbImie.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbKraj.Text))
                {
                    sql = "SELECT * from dbo.Artysci WHERE Kraj LIKE '%" + txbKraj.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbRok.Text))
                {
                    sql = "SELECT * from dbo.Artysci WHERE RokUrodzenia LIKE '%" + txbRok.Text + "%'";
                    cmd.CommandText = sql;
                }

                cmd.ExecuteNonQuery();
                DataTable dtArtysci = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtArtysci);
                dgArtysta.DataSource = dtArtysci;
                conn.Close();
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbIdArtysty.Text))
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

                    if (!string.IsNullOrWhiteSpace(txbIdNurtu.Text))
                    {
                        sql = "UPDATE dbo.Artysci SET IdNurtu ='" + txbIdNurtu.Text + "' WHERE IdZamowienia ='" + txbIdArtysty.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(txbImie.Text))
                    {
                        sql = "UPDATE dbo.Artysci SET ImieiNazwisko ='" + txbImie.Text + "' WHERE IdZamowienia ='" + txbIdArtysty.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(txbKraj.Text))
                    {
                        sql = "UPDATE dbo.Artysci SET Kraj ='" + txbKraj.Text + "' WHERE IdZamowienia ='" + txbIdArtysty.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(txbRok.Text))
                    {
                        sql = "UPDATE dbo.Artysci SET Rok ='" + txbRok.Text + "' WHERE IdZamowienia ='" + txbIdArtysty.Text + "'";
                        cmd.CommandText = sql;
                    }

                    cmd.ExecuteNonQuery();
                    DataTable dtArtysci = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtArtysci);
                    dgArtysta.DataSource = dtArtysci;
                    conn.Close();
                    displayData();
                }
            }
        }
    }
}
