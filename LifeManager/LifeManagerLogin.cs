using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LifeManager.Pages;

namespace LifeManager
{
    public partial class LifeManagerLogin : Form
    {
        public LifeManagerLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(tbUserName.Text != string.Empty && tbPassword.Text != string.Empty)
            {
                Manager new_form = new Manager();
                new_form.Owner = this;
                //this.Hide();
                new_form.ShowDialog();
                Application.ExitThread();
            }
        }
    }
}
