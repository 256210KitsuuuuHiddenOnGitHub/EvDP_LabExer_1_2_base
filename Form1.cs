namespace EvDP_03LabExer1_10252022
{
    public partial class Form1 : Form
    {
        private string gender;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Do Nothing
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Do Nothing 
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //Do Nothing
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //Catch Gender Exception
            try
            {
                //Open Form 2
                Form2 frm2 = new Form2();
                //Put Info
                frm2.setAgeAndGender(txtBoxAge.Text.ToString(), gender);
                frm2.setProgramBday(cbProgram.Text.ToString(), dtBday.Text.ToString());
                frm2.setFullName(txtBoxFirstName.Text.ToString(), txtBoxMiddleInital.Text.ToString(), txtBoxLastName.Text.ToString()); //Full Name
                frm2.setNums(txtBoxStudentNumber.Text.ToString(), txtBoxContactNumber.Text.ToString());

                //Then Show
                frm2.ShowDialog();
            }catch(NullReferenceException ex)
            {
                this.gender = "NaN";
            }
            
        }


        //Tick and Untick
        private void checkBMale_CheckedChanged(object sender, EventArgs e)
        {
            checkBFemale.Checked = false;
            this.gender = "Male";
        }

        private void checkBFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkBMale.Checked = false;
            this.gender = "Female";
        }
    }
}