namespace SchoolManagementSystem
{
    partial class StudentResult
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
            this.txtResultSearch = new System.Windows.Forms.TextBox();
            this.SEARCH = new System.Windows.Forms.Label();
            this.dgvStudentInfo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResultSearch
            // 
            this.txtResultSearch.Location = new System.Drawing.Point(164, 11);
            this.txtResultSearch.Name = "txtResultSearch";
            this.txtResultSearch.Size = new System.Drawing.Size(240, 20);
            this.txtResultSearch.TabIndex = 8;
            this.txtResultSearch.TextChanged += new System.EventHandler(this.txtResultSearch_TextChanged);
            // 
            // SEARCH
            // 
            this.SEARCH.AutoSize = true;
            this.SEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SEARCH.Location = new System.Drawing.Point(12, 9);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(146, 20);
            this.SEARCH.TabIndex = 7;
            this.SEARCH.Text = "Enter Student ID";
            // 
            // dgvStudentInfo
            // 
            this.dgvStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentInfo.Location = new System.Drawing.Point(12, 50);
            this.dgvStudentInfo.Name = "dgvStudentInfo";
            this.dgvStudentInfo.Size = new System.Drawing.Size(619, 268);
            this.dgvStudentInfo.TabIndex = 6;
            // 
            // StudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 328);
            this.Controls.Add(this.txtResultSearch);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.dgvStudentInfo);
            this.Name = "StudentResult";
            this.Text = "StudentResult";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentResult_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultSearch;
        private System.Windows.Forms.Label SEARCH;
        private System.Windows.Forms.DataGridView dgvStudentInfo;
    }
}