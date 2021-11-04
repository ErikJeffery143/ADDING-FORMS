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
    public partial class FormAddName : Form
    {
        public FormAddName()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (GetIndexIgnoreCase(txtAddNames.Text) == -1)
            {
                
                frmMain.names.Add(txtAddNames.Text);
                frmMain.names.Sort();
                lstNames.DataSource = null;
                lstNames.DataSource = frmMain.names;
                txtAddNames.Text = "";
            }



        }

        private void FormAddName_Load(object sender, EventArgs e)
        {
            lstNames.DataSource = frmMain.names;
        }

        private static int GetIndexIgnoreCase(string naming)
        {
            for (int i = 0; i < frmMain.names.Count; i++)
            {
                if (frmMain.names[i].Equals(naming, StringComparison.CurrentCultureIgnoreCase))
                    return i;
            }
            return -1;


        }
    } }
