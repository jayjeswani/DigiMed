using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Medidg
{
    public partial class Login : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Medidg\Medidg\bin\Debug\Info.mdb");
        }
        int value = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
                con.Open();
                cmd = new OleDbCommand("select *from Reg where name='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                System.Data.OleDb.OleDbDataReader dr = null;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (this.textBox1.Text == dr["name"].ToString() & this.textBox2.Text == dr["password"].ToString())
                    {
                        MessageBox.Show("*** Login Successful ***");
                        Form1 f = new Form1();
                        f.Show();
                            //Form5 f = new Form5(txtUsr.Text);
                        //  Form4 f = new Form4();
                        // f.PassValue(txtUsr.Text);
                        // f.Show();
                     //
                        //f.Show();
                        this.Hide();
                    }
                }
            
            else
            {
                MessageBox.Show("Invalid");
            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

