namespace AemtliPlan
{
    partial class AemltliGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMembers = new System.Windows.Forms.Button();
            this.btnMangageTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMembers
            // 
            this.buttonMembers.Location = new System.Drawing.Point(654, 34);
            this.buttonMembers.Name = "buttonMembers";
            this.buttonMembers.Size = new System.Drawing.Size(123, 23);
            this.buttonMembers.TabIndex = 0;
            this.buttonMembers.Text = "Manage Members";
            this.buttonMembers.UseVisualStyleBackColor = true;
            this.buttonMembers.Click += new System.EventHandler(this.buttonMembers_Click);
            // 
            // btnMangageTasks
            // 
            this.btnMangageTasks.Location = new System.Drawing.Point(654, 84);
            this.btnMangageTasks.Name = "btnMangageTasks";
            this.btnMangageTasks.Size = new System.Drawing.Size(123, 23);
            this.btnMangageTasks.TabIndex = 1;
            this.btnMangageTasks.Text = "Mange Tasks";
            this.btnMangageTasks.UseVisualStyleBackColor = true;
            this.btnMangageTasks.Click += new System.EventHandler(this.btnMangageTasks_Click);
            // 
            // AemltliGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMangageTasks);
            this.Controls.Add(this.buttonMembers);
            this.Name = "AemltliGenerator";
            this.Text = "AemltliGenerator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMembers;
        private System.Windows.Forms.Button btnMangageTasks;
    }
}

