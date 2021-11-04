namespace ADDING_FORMS
{
    partial class frmMain
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
            this.btnAddName = new System.Windows.Forms.Button();
            this.btnEditName = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(12, 12);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(75, 23);
            this.btnAddName.TabIndex = 0;
            this.btnAddName.Text = "Add Name";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // btnEditName
            // 
            this.btnEditName.Location = new System.Drawing.Point(12, 42);
            this.btnEditName.Name = "btnEditName";
            this.btnEditName.Size = new System.Drawing.Size(75, 23);
            this.btnEditName.TabIndex = 1;
            this.btnEditName.Text = "Edit Name";
            this.btnEditName.UseVisualStyleBackColor = true;
            this.btnEditName.Click += new System.EventHandler(this.btnEditName_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 72);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Name";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 188);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(114, 12);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(120, 199);
            this.lstNames.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 217);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEditName);
            this.Controls.Add(this.btnAddName);
            this.Name = "frmMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnEditName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.ListBox lstNames;
    }
}

