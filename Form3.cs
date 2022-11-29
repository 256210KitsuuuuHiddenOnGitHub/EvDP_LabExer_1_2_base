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
    public partial class SystemMessage : Form
    {
        public SystemMessage()
        {
            InitializeComponent();
        }

        private void SystemMessage_Load(object sender, EventArgs e)
        {
            //Do Nothing
        }

        private void errorText_Click(object sender, EventArgs e)
        {
            //Do Nothing
        }

        //Trigger Success Text
        public string SuccessText(string ss)
        {
            return errorText.Text = ss;
        }

    }
}
