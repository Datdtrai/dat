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
using System.Data.Common;
namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Delete from BangDemo where Ten = 'Dat'";
            //  cmd.CommandText = "Select * from BangDemo where Ten = 'Vu' ";
            //cmd.Connection = conn;
            //DbDataReader reader =
            string a=Convert.ToString(cmd.ExecuteNonQuery());
            MessageBox.Show(a);
            // MessageBox.Show(Convert.ToString(reader.HasRows));
            //reader.Read();
            //MessageBox.Show(Convert.ToString(reader.GetOrdinal("Ten_Tai_Khoan")));
            //  MessageBox.Show(reader.GetString(1));
            // reader.Read();
            //MessageBox.Show(reader.GetString(1));
            this.Close();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
