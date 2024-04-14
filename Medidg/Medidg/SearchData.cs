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
    public partial class SearchData : Form
    {
        OleDbCommand cmd;
        public SearchData()
        {
            InitializeComponent();
        }

        private void SearchData_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Medidg\Medidg\bin\Debug\info.mdb"))
            {
                con.Open();
                cmd = new OleDbCommand("select analysis,prediction from dataset where disease='" + textBox1.Text + "' or symptom='" + textBox1.Text + "' or type='" + textBox1.Text + "'", con);
                OleDbDataReader dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    richTextBox1.Text = "Analysis:->"+dr["analysis"].ToString() + Environment.NewLine +"Prediction:->"+ dr["prediction"].ToString();
                }
                dr.Close();
                con.Close();
            }
        }

       
       

        
    }
}
