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
    public partial class frmStudentRecord : Form
    {
        public frmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Register then goes back main application
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //Try Catch and No message Leftovers
            try
            {
                //Find
                ofd2.InitialDirectory = @"C:\";
                ofd2.Title = "Browse Text Files";
                ofd2.DefaultExt = "txt";
                ofd2.Filter = "Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
                ofd2.ShowDialog();
                string Path = ofd2.FileName;
                using (StreamReader readIt = File.OpenText(Path))
                {
                    string _getText = "";
                    while ((_getText = readIt.ReadLine()) != null)
                    {
                        lvRecords.Items.Add(_getText);
                    }
                }
            }catch(Exception)
            {
                //Do Nothing
            }

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //Upload
            SystemMessage sm = new SystemMessage();
            sm.SuccessText("Upload Success");
            sm.ShowDialog();

            //Then Clear
            lvRecords.Clear();
        }

        private void frmStudentRecord_Load(object sender, EventArgs e)
        {
            //Do Nothing
        }
    }

}
