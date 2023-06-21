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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mniBasicControlsUsingContactFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmContactInfo objfrm = new frmContactInfo();
            objfrm.MdiParent = this;
            objfrm.Visible = true;

          



        }

        private void mniDataBindingSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee objfrm = new frmEmployee();
            objfrm.MdiParent = this;
            objfrm.Visible = true;
        }

        private void dataBindingADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeADONET objfrm = new frmEmployeeADONET();
            objfrm.MdiParent = this;
            objfrm.Visible = true;
        }
    }
    }

