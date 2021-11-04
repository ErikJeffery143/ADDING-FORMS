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
    
    public partial class frmMain : Form
    {
        public static List<string> names = new List<string>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            
            FormAddName frmAddName = new FormAddName();
            frmAddName.ShowDialog();
            lstNames.DataSource = null;
            lstNames.DataSource = names;
            

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            names.Add("Mort");
            names.Add("Maurice");
            names.Add("King Julian");
            names.Sort();
            lstNames.DataSource = names;
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex != -1)
            {
                names.RemoveAt(lstNames.SelectedIndex);
                lstNames.DataSource = null;
                lstNames.DataSource = names;
                lstNames.ClearSelected();
            }
            else
            {

            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEditName_Click(object sender, EventArgs e)
        {
            
            

            if (lstNames.SelectedIndex == -1)
            {

            }
            else
            {
                FormChangeName frmAddName = new FormChangeName(lstNames.SelectedIndex);
                frmAddName.ShowDialog();
                lstNames.DataSource = null;
                lstNames.DataSource = names;
            }



        }

        private static int GetIndexIgnoreCase(string naming)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].Equals(naming, StringComparison.CurrentCultureIgnoreCase))
                    return i;
            }
            return -1;



        }
    }
}
