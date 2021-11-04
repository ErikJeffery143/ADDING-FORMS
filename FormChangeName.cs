using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADDING_FORMS
{
    public partial class FormChangeName : Form
    {
        int index;
        public FormChangeName(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lblEditInstruction_Click(object sender, EventArgs e)
        {

        }

        private void FormChangeName_Load(object sender, EventArgs e)
        {
            lblSelected.Text = frmMain.names[index];
        }

        private void btnFinishEdit_Click(object sender, EventArgs e)
        {
            if (txtEdited.Text == "")
            {

            }
            else
            {
                frmMain.names.Remove(lblSelected.Text);
                frmMain.names.Add(txtEdited.Text);
                frmMain.names.Sort();
                this.Dispose();
            }

            
        }
    }
}
