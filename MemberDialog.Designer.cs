namespace AemtliPlan
{
    partial class MemberDialog
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnNewMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(701, 50);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(75, 23);
            this.btnNewMember.TabIndex = 0;
            this.btnNewMember.Text = "New";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(701, 106);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMember.TabIndex = 1;
            this.btnDeleteMember.Text = "Delete";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 15;
            this.listBoxTasks.Location = new System.Drawing.Point(27, 50);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(648, 364);
            this.listBoxTasks.TabIndex = 2;
            this.listBoxTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxTasks_SelectedIndexChanged);
            // 
            // MemberDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnNewMember);
            this.Name = "MemberDialog";
            this.Text = "MemberDialog";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.ListBox listBoxTasks;
    }
}