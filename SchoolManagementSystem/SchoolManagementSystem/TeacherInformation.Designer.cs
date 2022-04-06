namespace SchoolManagementSystem
{
    partial class TeacherInformation
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
            this.txtTeacherSearch = new System.Windows.Forms.TextBox();
            this.SEARCH = new System.Windows.Forms.Label();
            this.dgvStudentInfo = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTeacherSearch
            // 
            this.txtTeacherSearch.Location = new System.Drawing.Point(164, 11);
            this.txtTeacherSearch.Name = "txtTeacherSearch";
            this.txtTeacherSearch.Size = new System.Drawing.Size(240, 20);
            this.txtTeacherSearch.TabIndex = 5;
            this.txtTeacherSearch.TextChanged += new System.EventHandler(this.txtTeacherSearch_TextChanged);
            // 
            // SEARCH
            // 
            this.SEARCH.AutoSize = true;
            this.SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH.Location = new System.Drawing.Point(12, 9);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(147, 20);
            this.SEARCH.TabIndex = 4;
            this.SEARCH.Text = "Enter Teacher ID";
            // 
            // dgvStudentInfo
            // 
            this.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInfo.Location = new System.Drawing.Point(12, 50);
            this.dgvStudentInfo.Name = "dgvStudentInfo";
            this.dgvStudentInfo.Size = new System.Drawing.Size(619, 268);
            this.dgvStudentInfo.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(475, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TeacherInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 332);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTeacherSearch);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.dgvStudentInfo);
            this.Name = "TeacherInformation";
            this.Text = "TeacherInformation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherInformation_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeacherSearch;
        private System.Windows.Forms.Label SEARCH;
        private System.Windows.Forms.DataGridView dgvStudentInfo;
        private System.Windows.Forms.Button btnDelete;
    }
}