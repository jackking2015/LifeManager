using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeManager.Pages
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //进入密码管理界面
            Manager new_form = new Manager();
            new_form.Owner = this;
            this.Hide();
            new_form.ShowDialog();
            Application.ExitThread();
        }
    }
}
