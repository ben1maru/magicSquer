using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Магічний_квадрат
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FrmMain newform = new FrmMain();
            newform.Show();
            this.Hide();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            grbInfo.Visible = false;
            grbMenu.Visible = true;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            grbInfo.Visible = true;
            grbMenu.Visible = false;
        
            using (StreamReader reader = File.OpenText(@"Menu\About.txt"))
            {
                txtInfo.Text = reader.ReadToEnd();
            }
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            grbInfo.Visible = true;
            grbMenu.Visible = false;

            using (StreamReader reader = File.OpenText(@"Menu\InaGame.txt"))
            {
                txtInfo.Text = reader.ReadToEnd();
            }
        }

        
    }
    }
   