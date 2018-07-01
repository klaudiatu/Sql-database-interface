using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace SaveImagetoSQLServer
{
    public partial class Form1 : Form
    {
        MdiClient client;
        SqlCommand command;
        string imgLoc = "";

        public Form1()
        {
            InitializeComponent();
            //IsMdiContainer = true;
            client = Controls.OfType<MdiClient>().First();
            client.GotFocus += (s, e) =>
            {
                if (!MdiChildren.Any(x => x.Visible)) client.SendToBack();
            };
        }


        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Picture";
                if(dlg.ShowDialog()== DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    picObraz.ImageLocation = imgLoc;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {using (SqlConnection conn = Class1.ConnectDB())
                try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                string sql = "INSERT INTO dbo.Obrazy (IdObrazu, IdArtysty, IdStatusuObrazu, Tytul, Zdjecie) values(" + IdO.Text + ",'" + IdA.Text + "','" + IdSO.Text + "','" + Tytul.Text +"',@img)";


                if (conn.State != ConnectionState.Open)
                    conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.Add(new SqlParameter("@img", img));
                int x = command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(x.ToString() + " Zapisane. ");

                    IdO.Text = "";
                    IdA.Text = "";
                    IdSO.Text = "";
                    Tytul.Text = "";
                    picObraz.Image = null; 
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Class1.ConnectDB())
                try
            {
                string sql = "SELECT IdArtysty, IdStatusuObrazu, Tytul, Zdjecie FROM dbo.Obrazy WHERE IdObrazu ="+IdO.Text+"";
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        IdA.Text = reader[0].ToString();
                        IdSO.Text = reader[1].ToString();
                        Tytul.Text = reader[2].ToString();
                        byte[] img = (byte[])(reader[3]);

                        if (img == null)
                            picObraz.Image = null;
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            picObraz.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {

                        IdO.Text = "";
                        IdA.Text = "";
                        IdSO.Text = "";
                        Tytul.Text = "";
                        picObraz.Image = null;
                        MessageBox.Show("To Id nie istnieje w bazie danych");
                    }
                    conn.Close();
            }
            catch (Exception ex)
            {
                    conn.Close();
                    MessageBox.Show(ex.Message);
            }
        }


        

         //FArtysci artysci;
        private void artyściToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (artysci == null)
            //{
            //    FArtysci artysci = new FArtysci();
            //    artysci.MdiParent = this;
            //    artysci.FormClosed += Artysci_FormClosed1;
            //    artysci.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    artysci.Activate();
            //}

            Form f = new FArtysci();
            f.Show();
        }

        private void Artysci_FormClosed1(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void zamówieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Zamowienia();
            f.Show();
        }

        private void klienciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new klienci();
            f.Show();
        }

        private void obrazyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Obrazy();
            f.Show();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            IdO.Text = "";
            IdA.Text = "";
            IdSO.Text = "";
            Tytul.Text = "";
            picObraz.Image = null;
        }



        // private void ShowForm(Form artysci)
        //             {
        //     client.BringToFront();//This will make your child form shown on top.
        //artysci.Show();
        // }

        //private void Artysci_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    artysci = null;
        //    //throw new NotImplementedException();
        //}
    }
}
