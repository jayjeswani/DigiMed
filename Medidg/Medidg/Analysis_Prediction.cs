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
    public partial class Analysis_Prediction : Form
    {
        OleDbCommand cmd;
        public Analysis_Prediction()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Medidg\Medidg\bin\Debug\info.mdb"))
            {
                con.Open();
                cmd = new OleDbCommand("insert into dataset(disease,symptom,type,analysis,prediction) values('"+txtDisease.Text+"','"+txtSymptom.Text+"','"+txtType.Text+"','"+txtAnalysis.Text+"','"+txtPrediction.Text+"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Inserted");
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDisease.Text == string.Empty)
            {
                MessageBox.Show("Enter Disease");
            }
            else
            {
                using (OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\project23\Medidg\Medidg\bin\Debug\info.mdb"))
                {
                    con.Open();
                    cmd = new OleDbCommand("delete from dataset where disease='" + txtDisease.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Deleted");
                    con.Close();
                }
            }
        }
    }
}
