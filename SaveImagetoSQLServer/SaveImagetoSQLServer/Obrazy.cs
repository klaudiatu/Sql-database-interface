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
    public partial class Obrazy : Form
    {
        public Obrazy()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txbIdArtysty.Clear();
            txbIdObrazu.Clear();
            txbStatus.Clear();
            txbTytul.Clear();
        }

        public void displayData()
        {
            using (SqlConnection conn = Class1.ConnectDB())
            {
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from obrazy";
                //cmd.ExecuteNonQuery();
                DataTable dtArtysci = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtArtysci);
                dgObrazy.DataSource = dtArtysci;
                conn.Close();
            }
        }

        //private void btnDodaj_Click(object sender, EventArgs e)
        //{
        //    using (SqlConnection conn = Class1.ConnectDB())

        //        try
        //        {
        //            //Chnange into dbo.Artysci

        //            if (string.IsNullOrWhiteSpace(txbTytul.Text))
        //            {
        //                MessageBox.Show("Proszę, uzupełnij wszystkie pola");

        //            }
        //            else if (string.IsNullOrWhiteSpace(txbStatus.Text))
        //            {
        //                MessageBox.Show("Proszę, uzupełnij wszystkie pola");
        //            }
        //            else if (string.IsNullOrWhiteSpace(txbIdObrazu.Text))
        //            {
        //                MessageBox.Show("Proszę, uzupełnij wszystkie pola");
        //            }
        //            else if (string.IsNullOrWhiteSpace(txbIdArtysty.Text))
        //            {
        //                MessageBox.Show("Proszę, uzupełnij wszystkie pola");
        //            }


        //            string sql = "INSERT INTO dbo.Obrazy ( IdObrazu, IdArtysty, IdStatusuObrazu, Tytul) " +
        //                "values(" + txbIdObrazu.Text + ",'" + txbIdArtysty.Text + "','" + txbStatus.Text + "','" + txbTytul.Text + "')";

        //            if (conn.State != ConnectionState.Open)
        //                conn.Open();

        //            SqlCommand cmd = conn.CreateCommand();
        //            cmd.CommandType = CommandType.Text;
        //            cmd.CommandText = sql;
        //            cmd.ExecuteNonQuery();

        //            conn.Close();
        //            displayData();
        //            MessageBox.Show(" Zapisane. ");



        //        }
        //        catch (Exception ex)
        //        {
        //            conn.Close();
        //            MessageBox.Show(ex.Message);
        //        }
        //}

        private void Obrazy_Load(object sender, EventArgs e)
        {
            displayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Class1.ConnectDB())

                try
                {
                    if (string.IsNullOrWhiteSpace(txbIdObrazu.Text))
                    {
                        MessageBox.Show("Proszę, uzupełnij pole ID.");
                    }

                    string sql = "DELETE FROM dbo.Obrazy WHERE IdObrazu = '" + txbIdObrazu.Text + "'";

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

        private void button5_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbIdObrazu.Text))
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

                    if (!string.IsNullOrWhiteSpace(txbIdArtysty.Text))
                    {
                        sql = "UPDATE dbo.Obrazy SET IdArtysty ='" + txbIdArtysty.Text + "' WHERE IdObrazu ='" + txbIdObrazu.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(txbStatus.Text))
                    {
                        sql = "UPDATE dbo.Obrazy SET IdStatusuObrazu ='" + txbStatus.Text + "' WHERE IdObrazu ='" + txbIdObrazu.Text + "'";
                        cmd.CommandText = sql;
                    }
                    else if (!string.IsNullOrWhiteSpace(txbTytul.Text))
                    {
                        sql = "UPDATE dbo.Obrazy SET Tytul ='" + txbTytul.Text + "' WHERE IdObrazu ='" + txbIdObrazu.Text + "'";
                        cmd.CommandText = sql;
                    }

                    cmd.ExecuteNonQuery();
                    DataTable dtArtysci = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dtArtysci);
                    dgObrazy.DataSource = dtArtysci;
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

                if (!string.IsNullOrWhiteSpace(txbIdArtysty.Text))
                {
                    sql = "SELECT * from dbo.Obrazy WHERE IdArtysty LIKE '%" + txbIdArtysty.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbIdObrazu.Text))
                {
                    sql = "SELECT * from dbo.Obrazy WHERE IdObrazu LIKE '%" + txbIdObrazu.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbStatus.Text))
                {
                    sql = "SELECT * from dbo.Obrazy WHERE IdStatusuObrazu LIKE '%" + txbStatus.Text + "%'";
                    cmd.CommandText = sql;
                }
                else if (!string.IsNullOrWhiteSpace(txbTytul.Text))
                {
                    sql = "SELECT * from dbo.Obrazy WHERE Tytul LIKE '%" + txbTytul.Text + "%'";
                    cmd.CommandText = sql;
                }


                cmd.ExecuteNonQuery();
                DataTable dtArtysci = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dtArtysci);
                dgObrazy.DataSource = dtArtysci;
                conn.Close();
            }
        }
    }
}
