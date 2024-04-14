using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Diagnostics;

namespace OSN
{
    public partial class Form1 : Form
    {
        string gender;
        OleDbConnection con;
        OleDbCommand cmd;
        MemoryStream ms;

        public Form1()
        {
            InitializeComponent();
            generateImage();
        }

        int value = 0;

        private void generateImage()
        {
            Random random = new Random(); // get a random instance

            value = random.Next(10000, 99999); // get a random value between any range

            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height); // Get a bitmap

            var font = new Font("TimesNewRoman", 25, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel); // Get a font

            var graphics = Graphics.FromImage(image); // Get a graphics with the bitmap image

            graphics.DrawString(value.ToString(), font, Brushes.Red, new PointF(0, 0)); // Add the value in the graphics

            Pen p = new Pen(Brushes.Orange, 2.0f); // get pen width

            graphics.DrawLine(p, new PointF(0, this.pictureBox1.Height), new Point(this.pictureBox1.Width, 0)); // draw a diagonal line

            graphics.DrawLine(p, new PointF(0, 0), new Point(this.pictureBox1.Width, this.pictureBox1.Height)); // draw another diagonal line 

            p.Dispose(); // dispose the pen to avoid memory leak

            graphics.SmoothingMode = SmoothingMode.AntiAlias; // Smoothing the pixel

            graphics.TextRenderingHint = TextRenderingHint.AntiAlias; // Smoothing the text rendering because stem width may differ

            this.pictureBox3.Image = image; // load the image in the picturebox


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string constring=System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ToString();
            con = new OleDbConnection(constring);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == value.ToString())
            {
                MessageBox.Show("Captcha Matched");

                con.Open();
                cmd = new OleDbCommand("select *from regis where usrname='" + txtUsr.Text + "' and pwd='" + txtPwd.Text + "'", con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                System.Data.OleDb.OleDbDataReader dr = null;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (this.txtUsr.Text == dr["usrname"].ToString() & this.txtPwd.Text == dr["pwd"].ToString())
                    {
                        MessageBox.Show("*** Login Successful ***");
                        //Form5 f = new Form5(txtUsr.Text);
                      //  Form4 f = new Form4();
                       // f.PassValue(txtUsr.Text);
                       // f.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid");
            }
            con.Close();
        }

        

        

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {          
            con.Open();
            cmd = new OleDbCommand("insert into regis values('" + txtfname.Text + "','" + txtmname.Text + "','" + txtlname.Text + "','" + txtUsrname.Text + "','" + txtpwd1.Text + "','" + txtMail.Text + "','" + gender + "','" + cmbCity.Text + "','" + txtMob.Text + "',@image)", con);
            conv_photo();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted");
            con.Close();
        }
        void conv_photo()
        {
            //converting photo to binary data
            if (pictureBox1.Image != null)
            {
                //using MemoryStream:
                ms = new MemoryStream();
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@image", photo_aray);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMale.Checked)
            {
                gender = "Male";
            }
            else if (rdbFemale.Checked)
            {
                gender = "Female";
            }
        }
        private string ImageToBase64String(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, image.RawFormat);
                return Convert.ToBase64String(stream.ToArray());
            }
        }

        private void txtfname_Click(object sender, EventArgs e)
        {
            txtfname.Text = "";
        }

        private void txtmname_Click(object sender, EventArgs e)
        {
            txtmname.Text = "";
        }

        private void txtlname_Click(object sender, EventArgs e)
        {
            txtlname.Text = "";
        }

        private void txtUsrname_Click(object sender, EventArgs e)
        {
            txtUsrname.Text = "";
        }

        private void txtMob_Click(object sender, EventArgs e)
        {
            txtMob.Text = "";
        }

        private void txtMail_Click(object sender, EventArgs e)
        {
            txtMail.Text = "";
        }

        private void txtpwd1_Click(object sender, EventArgs e)
        {
            txtpwd1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.generateImage();
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.generateImage();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Process.Start("H:\\password cap\\WindowsFormsApplication2\\WindowsFormsApplication2\\bin\\Debug\\WindowsFormsApplication2.exe");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        
    }
}
