namespace Age_calculator
{
    partial class frmAgecalculator
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
            this.lbldate = new System.Windows.Forms.Label();
            this.lblBirthMontth = new System.Windows.Forms.Label();
            this.lblBirthyear = new System.Windows.Forms.Label();
            this.txtboxmonth = new System.Windows.Forms.TextBox();
            this.txtboxyear = new System.Windows.Forms.TextBox();
            this.txtboxage = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtboxdate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(218, 123);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(125, 16);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = "Enter your birthdate:";
            // 
            // lblBirthMontth
            // 
            this.lblBirthMontth.AutoSize = true;
            this.lblBirthMontth.Location = new System.Drawing.Point(218, 186);
            this.lblBirthMontth.Name = "lblBirthMontth";
            this.lblBirthMontth.Size = new System.Drawing.Size(134, 16);
            this.lblBirthMontth.TabIndex = 1;
            this.lblBirthMontth.Text = "Enter your birthmonth:";
            // 
            // lblBirthyear
            // 
            this.lblBirthyear.AutoSize = true;
            this.lblBirthyear.Location = new System.Drawing.Point(218, 245);
            this.lblBirthyear.Name = "lblBirthyear";
            this.lblBirthyear.Size = new System.Drawing.Size(125, 16);
            this.lblBirthyear.TabIndex = 2;
            this.lblBirthyear.Text = "Enter your birthyear:";
            // 
            // txtboxmonth
            // 
            this.txtboxmonth.Location = new System.Drawing.Point(367, 183);
            this.txtboxmonth.Name = "txtboxmonth";
            this.txtboxmonth.Size = new System.Drawing.Size(102, 22);
            this.txtboxmonth.TabIndex = 1;
            // 
            // txtboxyear
            // 
            this.txtboxyear.Location = new System.Drawing.Point(367, 239);
            this.txtboxyear.Name = "txtboxyear";
            this.txtboxyear.Size = new System.Drawing.Size(102, 22);
            this.txtboxyear.TabIndex = 2;
            // 
            // txtboxage
            // 
            this.txtboxage.BackColor = System.Drawing.Color.SkyBlue;
            this.txtboxage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxage.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxage.Location = new System.Drawing.Point(176, 388);
            this.txtboxage.Multiline = true;
            this.txtboxage.Name = "txtboxage";
            this.txtboxage.ReadOnly = true;
            this.txtboxage.Size = new System.Drawing.Size(415, 57);
            this.txtboxage.TabIndex = 7;
            this.txtboxage.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSubmit.Location = new System.Drawing.Point(332, 307);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 46);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtboxdate
            // 
            this.txtboxdate.Location = new System.Drawing.Point(367, 123);
            this.txtboxdate.Name = "txtboxdate";
            this.txtboxdate.Size = new System.Drawing.Size(102, 22);
            this.txtboxdate.TabIndex = 0;
            // 
            // frmAgecalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 475);
            this.Controls.Add(this.txtboxdate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtboxage);
            this.Controls.Add(this.txtboxyear);
            this.Controls.Add(this.txtboxmonth);
            this.Controls.Add(this.lblBirthyear);
            this.Controls.Add(this.lblBirthMontth);
            this.Controls.Add(this.lbldate);
            this.Name = "frmAgecalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblBirthMontth;
        private System.Windows.Forms.Label lblBirthyear;
        private System.Windows.Forms.TextBox txtboxmonth;
        private System.Windows.Forms.TextBox txtboxyear;
        private System.Windows.Forms.TextBox txtboxage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtboxdate;
    }
}

