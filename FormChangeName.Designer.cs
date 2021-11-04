namespace ADDING_FORMS
{
    partial class FormChangeName
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
            this.lblEditInstruction = new System.Windows.Forms.Label();
            this.btnFinishEdit = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.txtEdited = new System.Windows.Forms.TextBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEditInstruction
            // 
            this.lblEditInstruction.AutoSize = true;
            this.lblEditInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditInstruction.Location = new System.Drawing.Point(61, 66);
            this.lblEditInstruction.Name = "lblEditInstruction";
            this.lblEditInstruction.Size = new System.Drawing.Size(309, 29);
            this.lblEditInstruction.TabIndex = 1;
            this.lblEditInstruction.Text = "The name you chose to edit";
            this.lblEditInstruction.Click += new System.EventHandler(this.lblEditInstruction_Click);
            // 
            // btnFinishEdit
            // 
            this.btnFinishEdit.Location = new System.Drawing.Point(137, 203);
            this.btnFinishEdit.Name = "btnFinishEdit";
            this.btnFinishEdit.Size = new System.Drawing.Size(75, 23);
            this.btnFinishEdit.TabIndex = 2;
            this.btnFinishEdit.Text = "Complete";
            this.btnFinishEdit.UseVisualStyleBackColor = true;
            this.btnFinishEdit.Click += new System.EventHandler(this.btnFinishEdit_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Location = new System.Drawing.Point(217, 203);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(75, 23);
            this.btnLeave.TabIndex = 3;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // txtEdited
            // 
            this.txtEdited.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdited.Location = new System.Drawing.Point(66, 144);
            this.txtEdited.Name = "txtEdited";
            this.txtEdited.Size = new System.Drawing.Size(304, 29);
            this.txtEdited.TabIndex = 4;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.Location = new System.Drawing.Point(110, 112);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(260, 29);
            this.lblSelected.TabIndex = 5;
            this.lblSelected.Text = "___________________";
            // 
            // FormChangeName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 277);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.txtEdited);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnFinishEdit);
            this.Controls.Add(this.lblEditInstruction);
            this.Name = "FormChangeName";
            this.Text = "FormChangeName";
            this.Load += new System.EventHandler(this.FormChangeName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEditInstruction;
        private System.Windows.Forms.Button btnFinishEdit;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.TextBox txtEdited;
        private System.Windows.Forms.Label lblSelected;
    }
}