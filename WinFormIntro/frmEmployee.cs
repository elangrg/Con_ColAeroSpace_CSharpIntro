using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormIntro
{
    public partial class frmEmployee : Form
    {

        Models.EmployeeContext _db = new Models.EmployeeContext();


        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empDbDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.empDbDataSet.Employee);





        }
    }
}
