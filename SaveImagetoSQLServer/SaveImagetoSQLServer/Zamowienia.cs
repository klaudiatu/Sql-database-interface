using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaveImagetoSQLServer
{
    public partial class Zamowienia : Form
    {
        public Zamowienia()
        {
            InitializeComponent();
        }
        

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Zamowienia_Load(object sender, EventArgs e)
        {
            displayData();
        }

        public void displayData()
        {
            using (SqlConnection conn = Class1.ConnectDB())
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from zamowienia";
                //cmd.ExecuteNonQuery();
                DataTable dtArtysci = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtArtysci);
                dgZamowienia.DataSource = dtArtysci;
                conn.Close();
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxbData.Clear();
            txbObraz.Clear();
            TxbKlient.Clear();
            txbZamowienie.Clear();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Class1.ConnectDB())

                try
                {
                    //Chnange into dbo.Artysci

                    if (string.IsNullOrWhiteSpace(TxbData.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");

                    }
                    else if (string.IsNullOrWhiteSpace(txbZamowienie.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }
                    else if (string.IsNullOrWhiteSpace(txbObraz.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }
                    else if (string.IsNullOrWhiteSpace(TxbKlient.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }

                    string sql = "INSERT INTO dbo.Zamowienia (IdZamowienia, IdKlienta, IdObrazu, DataZamówienia) " +
                        "values(" + txbZamowienie.Text + ",'" + TxbKlient.Text + "','" + txbObraz.Text + "','" + TxbData.Text + "')";

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
                    if (string.IsNullOrWhiteSpace(txbZamowienie.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij pole ID.");
                    }

                    string sql = "DELETE FROM dbo.Zamowienia WHERE IdZamowienia = '" + txbZamowienie.Text + "'";

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

                if (!string.IsNullOrWhiteSpace(txbZamowienie.Text))
                {
                    sql = "SELECT * from dbo.Zamowienia WHERE IdZamowienia LIKE '%" + txbZamowienie.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(TxbKlient.Text))
                {
                    sql = "SELECT * from dbo.Zamowienia WHERE IdKlienta LIKE '%" + TxbKlient.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbObraz.Text))
                {
                    sql = "SELECT * from dbo.Zamowienia WHERE IdObrazu LIKE '%" + txbObraz.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(TxbData.Text))
                {
                    sql = "SELECT * from dbo.Zamowienia WHERE DataZamówienia LIKE '%" + TxbData.Text + "%'";
                    cmd.CommandText = sql;
                }

                cmd.ExecuteNonQuery();
                DataTable dtArtysci = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtArtysci);
                dgZamowienia.DataSource = dtArtysci;
                conn.Close();
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbZamowienie.Text))
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

                    if (!string.IsNullOrWhiteSpace(txbObraz.Text))
                    {
                        sql = "UPDATE dbo.Zamowienia SET IdObrazu ='" + txbObraz.Text + "' WHERE IdZamowienia ='" + txbZamowienie.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(TxbKlient.Text))
                    {
                        sql = "UPDATE dbo.Zamowienia SET IdKlienta ='" + TxbKlient.Text + "' WHERE IdZamowienia ='" + txbZamowienie.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(TxbData.Text))
                    {
                        sql = "UPDATE dbo.Zamowienia SET DataZamówienia ='" + TxbData.Text + "' WHERE IdZamowienia ='" + txbZamowienie.Text + "'";
                        cmd.CommandText = sql;
                    }

                    cmd.ExecuteNonQuery();
                    DataTable dtArtysci = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtArtysci);
                    dgZamowienia.DataSource = dtArtysci;
                    conn.Close();
                    displayData();
                }
            }
        }
        private void btnZaladuj_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
    }

