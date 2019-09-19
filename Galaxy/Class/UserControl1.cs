using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Galaxy.Class
{
    public partial class UserControl1 : MetroUserControl
    {
        private static UserControl1 _instance;

        public static UserControl1 instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl1();
                return _instance;
            }
        }

        public UserControl1() 
        {
            InitializeComponent();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.seen(this);
        }
    }
}
