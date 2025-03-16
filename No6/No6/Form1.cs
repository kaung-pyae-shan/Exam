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
using CrystalDecisions.CrystalReports.Engine;

namespace No6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str = "Data Source=MSI;Initial Catalog=StaffRecord;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            string query = "SELECT * FROM Staff";
            DisplayData(query, con);
        }

        private void DisplayData(string query, SqlConnection con)
        {
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            adapter.Fill(ds, "Staff");
            dgView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(str);
            string query = "SELECT * FROM Staff WHERE Staff_Name = '" + txtName.Text.Trim() + "'";
            DisplayData(query, con);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportDocument crpt = new ReportDocument();
            crpt.Load("D:\\School\\CS-4101\\No6\\No6\\CrystalReport1.rpt"); // crpt file destination
            crv1.ReportSource = crpt;
            crv1.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
