namespace ADDING_FORMS
{
    partial class FormAddName
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
            this.btnDone = new System.Windows.Forms.Button();
            this.txtAddNames = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(210, 64);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtAddNames
            // 
            this.txtAddNames.Location = new System.Drawing.Point(129, 38);
            this.txtAddNames.Name = "txtAddNames";
            this.txtAddNames.Size = new System.Drawing.Size(156, 20);
            this.txtAddNames.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(129, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstNames
            // 
            this.lstNames.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(12, 12);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(111, 160);
            this.lstNames.TabIndex = 3;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(127, 22);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(171, 13);
            this.lblInstruction.TabIndex = 4;
            this.lblInstruction.Text = "Enter a name below and click add.";
            // 
            // FormAddName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 176);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAddNames);
            this.Controls.Add(this.btnDone);
            this.Name = "FormAddName";
            this.Text = "Add a Name";
            this.Load += new System.EventHandler(this.FormAddName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TextBox txtAddNames;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.Label lblInstruction;
    }
}