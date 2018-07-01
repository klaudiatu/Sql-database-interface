using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SaveImagetoSQLServer
{
    public partial class FArtysci : Form
    {

        public FArtysci()
        {
            InitializeComponent();
        }

        private DataTable dtArtysci = new DataTable();

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxbKraj.Clear();
            txbRok.Clear();
            txbName.Clear();
            TxbNurt.Clear();
            txbId.Clear();
                      
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FArtysci_Load(object sender, EventArgs e)
        {        
            displayData();
        }       

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Class1.ConnectDB())

                try
                {
                    //Chnange into dbo.Artysci
                    
                    if (string.IsNullOrWhiteSpace(txbId.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");

                    } else if (string.IsNullOrWhiteSpace(TxbNurt.Text)) {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }
                    else if (string.IsNullOrWhiteSpace(txbName.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }
                    else if (string.IsNullOrWhiteSpace(TxbKraj.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }
                    else if (string.IsNullOrWhiteSpace(txbRok.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij wszystkie pola");
                    }

                    string sql = "INSERT INTO dbo.Artysci (IdArtysty, IdNurtu, ImieiNazwisko, Kraj, RokUrodzenia) " +
                        "values(" + txbId.Text + ",'" + TxbNurt.Text + "','" + txbName.Text + "','" + TxbKraj.Text + "','" + txbRok.Text + "')";

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    displayData();
                    MessageBox.Show(" Zapisane. ");

                    txbId.Text = "";
                    TxbNurt.Text = "";
                    txbName.Text = "";
                    TxbKraj.Text = "";
                    txbRok.Text = "";

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
                    if (string.IsNullOrWhiteSpace(txbId.Text)){
                        MessageBox.Show("Proszę, uzupełnij pole ID.");
                    }

                    string sql = "DELETE FROM dbo.Artysci WHERE IdArtysty = '" + txbId.Text + "'"; 

                    if (conn.State != ConnectionState.Open)
                        conn.Open();

                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show( " Usunięte. ");
                    displayData();

                    txbId.Text = "";
                    TxbNurt.Text = "";
                    txbName.Text = "";
                    TxbKraj.Text = "";
                    txbRok.Text = "";

                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnZaladuj_Click(object sender, EventArgs e)
        {
            displayData();
        }

        public void displayData()
        {
            using (SqlConnection conn = Class1.ConnectDB())
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * from dbo.Artysci ";
                cmd.ExecuteNonQuery();
                DataTable dtArtysci = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtArtysci);
                dgArtysci.DataSource = dtArtysci;
                conn.Close();
            }
        }

        private void btnSzukaj_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Class1.ConnectDB())
            {
                String sql;
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                if (!string.IsNullOrWhiteSpace(txbId.Text))
                {
                    sql = "SELECT * from dbo.Artysci WHERE IdArtysty LIKE '%" + txbId.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(TxbKraj.Text))
                {
                    sql = "SELECT * from dbo.Artysci WHERE Kraj LIKE '%" + TxbKraj.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbName.Text))
                {
                    sql = "SELECT * from dbo.Artysci WHERE ImieiNazwisko LIKE '%" + txbName.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(TxbNurt.Text))
                {
                    sql = "SELECT * from dbo.Artysci WHERE IdNurtu LIKE '%" + TxbNurt.Text + "%'";
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
                dgArtysci.DataSource = dtArtysci;
                conn.Close();

                txbId.Text = "";
                TxbNurt.Text = "";
                txbName.Text = "";
                TxbKraj.Text = "";
                txbRok.Text = "";
            }
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txbId.Text)) {
                MessageBox.Show("Proszę, uzupełnij pole ID");
            }
            else {
                using (SqlConnection conn = Class1.ConnectDB())
                {                    
                    String sql;
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    if (!string.IsNullOrWhiteSpace(TxbKraj.Text))
                    {
                        sql = "UPDATE dbo.Artysci SET Kraj ='" + TxbKraj.Text + "' WHERE IdArtysty ='" + txbId.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(txbName.Text))
                    {
                        sql = "UPDATE dbo.Artysci SET ImieiNazwisko ='" + txbName.Text + "' WHERE IdArtysty ='" + txbId.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(TxbNurt.Text))
                    {
                        sql = "UPDATE dbo.Artysci SET IdNurtu ='" + TxbNurt.Text + "' WHERE IdArtysty ='" + txbId.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(txbRok.Text))
                    {
                        sql = "UPDATE dbo.Artysci SET RokUrodzenia ='" + txbRok.Text + "' WHERE IdArtysty ='" + txbId.Text + "'";
                        cmd.CommandText = sql;
                    }

                    cmd.ExecuteNonQuery();
                    DataTable dtArtysci = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtArtysci);
                    dgArtysci.DataSource = dtArtysci;
                    conn.Close();
                    displayData();
                }
            }
        }
    }
}
