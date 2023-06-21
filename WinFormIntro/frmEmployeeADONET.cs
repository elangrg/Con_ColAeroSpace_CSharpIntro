using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormIntro
{
    public partial class frmEmployeeADONET : Form
    {
        public frmEmployeeADONET()
        {
            InitializeComponent();
        }

        private void frmEmployeeADONET_Load(object sender, EventArgs e)
        {

            SqlConnection _cn = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=empdb;Integrated Security=True;");


            DataTable _dt = new DataTable();

            SqlDataAdapter _da = new SqlDataAdapter("select * from employee", _cn);
            _da.Fill(_dt);

            dataGridViewEmployee.DataSource = _dt;
           


        }
    }
}
