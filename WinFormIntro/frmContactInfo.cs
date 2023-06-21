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
    public partial class frmContactInfo : Form
    {

        string Interests = "";
        string quals = "";



        public frmContactInfo()
        {
            InitializeComponent();
        }

       

        private void btnSave_Click(object sender, EventArgs e)
        {
            string gender = rbtMale.Checked ? "Male" : "Female";

            string qual = string.Join(",", lstQual.SelectedItems.OfType<string>().ToArray());


            string st = $"Contact Named {txtFirstName.Text} {txtLastName.Text} is {gender} Resides in {txtAddress.Text} can be Contacted using {cmbContactnumberType.SelectedText} no : {txtContactNo.Text} Education completed {qual} , interested in {Interests} ";

                


            MessageBox.Show(st);


        }

        private void Interest_Changed(object sender, EventArgs e)
        {

            Interests = chkChess.Checked ? chkChess.Text : "";
            Interests += chkMovies.Checked ? chkMovies.Text : "";
            Interests += chkMusic.Checked ? chkMusic.Text : "";
            Interests += chkTravel.Checked ? chkTravel.Text : "";


        }
    }
}
