namespace EvDP_03LabExer1_10252022
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblStudnum = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBDAY = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblContactNum = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtBoxFileName = new System.Windows.Forms.TextBox();
            this.btnSaveNameFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(12, 48);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(73, 28);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblStudnum
            // 
            this.lblStudnum.AutoSize = true;
            this.lblStudnum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudnum.Location = new System.Drawing.Point(12, 9);
            this.lblStudnum.Name = "lblStudnum";
            this.lblStudnum.Size = new System.Drawing.Size(130, 28);
            this.lblStudnum.TabIndex = 1;
            this.lblStudnum.Text = "Student No. : ";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProgram.Location = new System.Drawing.Point(12, 94);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(102, 28);
            this.lblProgram.TabIndex = 2;
            this.lblProgram.Text = "Program : ";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAge.Location = new System.Drawing.Point(12, 140);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(61, 28);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age : ";
            // 
            // lblBDAY
            // 
            this.lblBDAY.AutoSize = true;
            this.lblBDAY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBDAY.Location = new System.Drawing.Point(12, 185);
            this.lblBDAY.Name = "lblBDAY";
            this.lblBDAY.Size = new System.Drawing.Size(99, 28);
            this.lblBDAY.TabIndex = 4;
            this.lblBDAY.Text = "Birthday : ";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(12, 228);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(90, 28);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender : ";
            // 
            // lblContactNum
            // 
            this.lblContactNum.AutoSize = true;
            this.lblContactNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContactNum.Location = new System.Drawing.Point(12, 277);
            this.lblContactNum.Name = "lblContactNum";
            this.lblContactNum.Size = new System.Drawing.Size(130, 28);
            this.lblContactNum.TabIndex = 6;
            this.lblContactNum.Text = "Contact No. : ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(242, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(154, 39);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileName.Location = new System.Drawing.Point(12, 328);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(108, 28);
            this.lblFileName.TabIndex = 8;
            this.lblFileName.Text = "File Name: ";
            // 
            // txtBoxFileName
            // 
            this.txtBoxFileName.Location = new System.Drawing.Point(120, 332);
            this.txtBoxFileName.Name = "txtBoxFileName";
            this.txtBoxFileName.Size = new System.Drawing.Size(276, 27);
            this.txtBoxFileName.TabIndex = 9;
            // 
            // btnSaveNameFile
            // 
            this.btnSaveNameFile.Location = new System.Drawing.Point(12, 383);
            this.btnSaveNameFile.Name = "btnSaveNameFile";
            this.btnSaveNameFile.Size = new System.Drawing.Size(154, 39);
            this.btnSaveNameFile.TabIndex = 10;
            this.btnSaveNameFile.Text = "Save File";
            this.btnSaveNameFile.UseVisualStyleBackColor = true;
            this.btnSaveNameFile.Click += new System.EventHandler(this.btnSaveNameFile_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 434);
            this.Controls.Add(this.btnSaveNameFile);
            this.Controls.Add(this.txtBoxFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblContactNum);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBDAY);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblStudnum);
            this.Controls.Add(this.lblName);
            this.Name = "Form2";
            this.Text = "Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblName;
        private Label lblStudnum;
        private Label lblProgram;
        private Label lblAge;
        private Label lblBDAY;
        private Label lblGender;
        private Label lblContactNum;
        private Button btnSubmit;
        private Label lblFileName;
        private TextBox txtBoxFileName;
        private Button btnSaveNameFile;
    }
}