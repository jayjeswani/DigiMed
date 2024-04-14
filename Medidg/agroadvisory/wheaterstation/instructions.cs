using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace wheaterstation
{
    public partial class instructions : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public instructions()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //string[] Labels = { "Wind Max", "Wind Min", "Temp Max", "Temp Min", "Water Max", "Water Min" };
        //int[] points = { 0, 0, 0, 0, 0, 0 };
        private void butFindInstruction_Click(object sender, EventArgs e)
        {
            string sql4 = "Select * from agrofield";
            //dt = new DataTable();  
            //adapt.Fill(dt);  

            OleDbDataAdapter da = new OleDbDataAdapter(sql4, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "perdication");
            dataGridView1.DataSource = da;
            con.Close();



            int count = ds.Tables["perdication"].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                int windMax = Convert.ToInt32(ds.Tables["perdication"].Rows[i].ItemArray.GetValue(1));
                int windMin = Convert.ToInt32(ds.Tables["perdication"].Rows[i].ItemArray.GetValue(2));

                int tempMax = Convert.ToInt32(ds.Tables["perdication"].Rows[i].ItemArray.GetValue(3));
                int tempMin = Convert.ToInt32(ds.Tables["perdication"].Rows[i].ItemArray.GetValue(4));

                int waterMax = Convert.ToInt32(ds.Tables["perdication"].Rows[i].ItemArray.GetValue(5));
                int waterMin = Convert.ToInt32(ds.Tables["perdication"].Rows[i].ItemArray.GetValue(6));



                //points[0] = windMax;
                //points[1] = windMin;
                //points[2] = tempMax;
                //points[3] = tempMin;
                //points[4] = waterMax;
                //points[5] = waterMin;
                //this.chart1.Series.Clear();

                //for (int j = 0; j < 6; j++)
                //{
                //    Series s = chart1.Series.Add(Labels[j]);

                //    s.Points.Add(points[j]);
                //}

                //chart1.ResetAutoValues();
                //Application.DoEvents();
                //System.Threading.Thread.Sleep(1000);

            }
        }

        private void instructions_Load(object sender, EventArgs e)
        {
         con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\Project 22\agroadvisory\wheaterstation\bin\Debug\info.mdb");
        }

        private void txtinstruction_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
             if (txtRainfall.Text != "" && txtTemperature.Text != "" && txtWaterLevel.Text != "" && txtWindspeed.Text!="")
            {
                string sql4 = "Select * from agrofield";
                OleDbDataAdapter da = new OleDbDataAdapter(sql4, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "agrofield");

                int count = ds.Tables["agrofield"].Rows.Count;

                Boolean windMatched = false;
                Boolean temperatureMatched = false;
                Boolean waterLevelMatched = false;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (row["temp"].ToString() == txtTemperature.Text && row["humidity"].ToString()==txtWaterLevel.Text && row["windspeed"].ToString()==txtWindspeed.Text && row["rainfall"].ToString()==txtRainfall.Text)
                    {
                        MessageBox.Show("Prediction:- "+row["perdication"].ToString()+"\n"+"Crop:- "+row["crop"].ToString());
                        txtPrediction.Text = row["perdication"].ToString();
                        txtCrop.Text = row["crop"].ToString();
                    }
                }
                //for (int i = 0; i < count - 1; i++)
                //{
                //    if (int.Parse(txtRainfall.Text) <= Convert.ToInt32(ds.Tables["agrofield"].Rows[i].ItemArray.GetValue(3))) //&&
                //    // int.Parse(txtWindSpeed.Text) >= Convert.ToInt32(ds.Tables["Info"].Rows[i].ItemArray.GetValue(2)))
                //    {
                //        windMatched = true;
                //    }
                //    else
                //    {
                //        windMatched = false;
                //    }

                //    if (double.Parse(txtTemperature.Text) <= Convert.ToDouble(ds.Tables["agrofield"].Rows[i].ItemArray.GetValue(4))) //&&
                //    // int.Parse(txtTemperature.Text) >= Convert.ToInt32(ds.Tables["Info"].Rows[i].ItemArray.GetValue(4)))
                //    {
                //        temperatureMatched = true;
                //    }
                //    else
                //    {
                //        temperatureMatched = false;
                //    }

                //    if (int.Parse(txtWaterLevel.Text) <= Convert.ToInt32(ds.Tables["Agrofield"].Rows[i].ItemArray.GetValue(5)))// &&
                //    //int.Parse(txtWaterLevel.Text) >= Convert.ToInt32(ds.Tables["Info"].Rows[i].ItemArray.GetValue(6)))
                //    {
                //        waterLevelMatched = true;
                //    }
                //    else
                //    {
                //        waterLevelMatched = false;
                //    }

                //    if (temperatureMatched == true && waterLevelMatched == true)
                //    {

                //        Database.strInstructions = ds.Tables["agrofiled"].Rows[i].ItemArray.GetValue(7).ToString();
                //        instructions f = new instructions();
                //        f.ShowDialog();
                //        return;
                //    }
                //}
                
            }
             else
             {
                 MessageBox.Show("Please supply correct values.", "No Value supplied");
                 return;
             }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        }


        }
        
       

   

