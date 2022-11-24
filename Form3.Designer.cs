namespace EvDP_03LabExer1_10252022
{
    partial class Error
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
            this.errorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.errorText.Location = new System.Drawing.Point(12, 20);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(221, 24);
            this.errorText.TabIndex = 0;
            this.errorText.Text = "Invalid Input Detected.";
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 65);
            this.Controls.Add(this.errorText);
            this.Name = "Error";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label errorText;
    }
}