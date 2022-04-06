namespace SchoolManagementSystem
{
    partial class StudentForm
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
            this.btnResult = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGpa = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblGPA = new System.Windows.Forms.Label();
            this.userControlStudentInfo1 = new SchoolManagementSystem.UserControlStudentInfo();
            this.userControlStudentResult1 = new SchoolManagementSystem.UserControlStudentResult();
            this.SuspendLayout();
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.LimeGreen;
            this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.Location = new System.Drawing.Point(39, 33);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(254, 45);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Information";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGpa
            // 
            this.btnGpa.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGpa.Location = new System.Drawing.Point(39, 157);
            this.btnGpa.Name = "btnGpa";
            this.btnGpa.Size = new System.Drawing.Size(254, 45);
            this.btnGpa.TabIndex = 6;
            this.btnGpa.Text = "GPA";
            this.btnGpa.UseVisualStyleBackColor = false;
            this.btnGpa.Click += new System.EventHandler(this.btnGpa_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(39, 311);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(254, 45);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblGPA
            // 
            this.lblGPA.AutoSize = true;
            this.lblGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGPA.ForeColor = System.Drawing.Color.Red;
            this.lblGPA.Location = new System.Drawing.Point(148, 246);
            this.lblGPA.Name = "lblGPA";
            this.lblGPA.Size = new System.Drawing.Size(46, 20);
            this.lblGPA.TabIndex = 10;
            this.lblGPA.Text = "GPA";
            // 
            // userControlStudentInfo1
            // 
            this.userControlStudentInfo1.Location = new System.Drawing.Point(299, 12);
            this.userControlStudentInfo1.Name = "userControlStudentInfo1";
            this.userControlStudentInfo1.Size = new System.Drawing.Size(600, 357);
            this.userControlStudentInfo1.TabIndex = 9;
            // 
            // userControlStudentResult1
            // 
            this.userControlStudentResult1.Location = new System.Drawing.Point(299, 12);
            this.userControlStudentResult1.Name = "userControlStudentResult1";
            this.userControlStudentResult1.Size = new System.Drawing.Size(600, 357);
            this.userControlStudentResult1.TabIndex = 8;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 380);
            this.Controls.Add(this.lblGPA);
            this.Controls.Add(this.userControlStudentInfo1);
            this.Controls.Add(this.userControlStudentResult1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnGpa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnResult);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGpa;
        private System.Windows.Forms.Button btnLogOut;
        private UserControlStudentResult userControlStudentResult1;
        private UserControlStudentInfo userControlStudentInfo1;
        private System.Windows.Forms.Label lblGPA;
    }
}