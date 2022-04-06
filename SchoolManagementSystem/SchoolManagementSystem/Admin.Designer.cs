namespace SchoolManagementSystem
{
    partial class Admin
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
            this.btnAdminProfile = new System.Windows.Forms.Button();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.btnTeacherAdd = new System.Windows.Forms.Button();
            this.btnStudentInfo = new System.Windows.Forms.Button();
            this.btnTeacherInfo = new System.Windows.Forms.Button();
            this.btnStudentResult = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminProfile
            // 
            this.btnAdminProfile.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdminProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminProfile.Location = new System.Drawing.Point(30, 12);
            this.btnAdminProfile.Name = "btnAdminProfile";
            this.btnAdminProfile.Size = new System.Drawing.Size(287, 37);
            this.btnAdminProfile.TabIndex = 0;
            this.btnAdminProfile.Text = "Profile";
            this.btnAdminProfile.UseVisualStyleBackColor = false;
            this.btnAdminProfile.Click += new System.EventHandler(this.btnAdminProfile_Click);
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStudentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentAdd.Location = new System.Drawing.Point(30, 69);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(287, 37);
            this.btnStudentAdd.TabIndex = 1;
            this.btnStudentAdd.Text = "Student Add";
            this.btnStudentAdd.UseVisualStyleBackColor = false;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // btnTeacherAdd
            // 
            this.btnTeacherAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTeacherAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherAdd.Location = new System.Drawing.Point(30, 125);
            this.btnTeacherAdd.Name = "btnTeacherAdd";
            this.btnTeacherAdd.Size = new System.Drawing.Size(287, 37);
            this.btnTeacherAdd.TabIndex = 2;
            this.btnTeacherAdd.Text = "Teacher Add";
            this.btnTeacherAdd.UseVisualStyleBackColor = false;
            this.btnTeacherAdd.Click += new System.EventHandler(this.btnTeacherAdd_Click);
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStudentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentInfo.Location = new System.Drawing.Point(30, 182);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.Size = new System.Drawing.Size(287, 37);
            this.btnStudentInfo.TabIndex = 3;
            this.btnStudentInfo.Text = "Student Info";
            this.btnStudentInfo.UseVisualStyleBackColor = false;
            this.btnStudentInfo.Click += new System.EventHandler(this.btnStudentInfo_Click);
            // 
            // btnTeacherInfo
            // 
            this.btnTeacherInfo.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTeacherInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherInfo.Location = new System.Drawing.Point(30, 238);
            this.btnTeacherInfo.Name = "btnTeacherInfo";
            this.btnTeacherInfo.Size = new System.Drawing.Size(287, 37);
            this.btnTeacherInfo.TabIndex = 4;
            this.btnTeacherInfo.Text = "Tacher Info";
            this.btnTeacherInfo.UseVisualStyleBackColor = false;
            this.btnTeacherInfo.Click += new System.EventHandler(this.btnTeacherInfo_Click);
            // 
            // btnStudentResult
            // 
            this.btnStudentResult.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStudentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentResult.Location = new System.Drawing.Point(30, 290);
            this.btnStudentResult.Name = "btnStudentResult";
            this.btnStudentResult.Size = new System.Drawing.Size(287, 37);
            this.btnStudentResult.TabIndex = 5;
            this.btnStudentResult.Text = "Student Result";
            this.btnStudentResult.UseVisualStyleBackColor = false;
            this.btnStudentResult.Click += new System.EventHandler(this.btnStudentResult_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(209, 355);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 37);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 413);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnStudentResult);
            this.Controls.Add(this.btnTeacherInfo);
            this.Controls.Add(this.btnStudentInfo);
            this.Controls.Add(this.btnTeacherAdd);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.btnAdminProfile);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminProfile;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Button btnTeacherAdd;
        private System.Windows.Forms.Button btnStudentInfo;
        private System.Windows.Forms.Button btnTeacherInfo;
        private System.Windows.Forms.Button btnStudentResult;
        private System.Windows.Forms.Button btnLogout;
    }
}