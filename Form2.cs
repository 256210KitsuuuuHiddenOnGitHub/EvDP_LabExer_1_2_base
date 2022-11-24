using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvDP_03LabExer1_10252022
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            //Do nothing
        }

        //methods & Direct Point
        public void setProgramBday(string P, string Bd)
        {
            lblBDAY.Text = "Birthday : " + Bd.ToString();
            lblProgram.Text = "Program : " + P.ToString();
        }
        public void setFullName(string fname, string mname, string lname)
        {
            lblName.Text = "Name : " + fname + " " + mname + " " + lname;
        }
        public void setAgeAndGender(string a, string only2)
        {
            lblAge.Text = "Age : " + a.ToString();
            lblGender.Text = "Gender : " + only2.ToString();
        }
        public void setNums(string studentNum, string ContactNum)
        {
            //Try Catch for Number Error
            //As Handout says, No universal Exception or
            //face minus points
            try
            {
                int cN = Convert.ToInt32(ContactNum), sN = Convert.ToInt32(studentNum);
                lblStudnum.Text = "Student No. : " + sN.ToString();
                lblContactNum.Text = "Contact No. : " + cN.ToString();
            }
            catch(FormatException num)
            {
                //Say Something
                Error frm3 = new Error();
                frm3.ShowDialog();
                //Then Set Default on System Instead
                //and disable submit button
                btnSubmit.Enabled = false;

            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Close button
            this.Close();
        }
    }

}
