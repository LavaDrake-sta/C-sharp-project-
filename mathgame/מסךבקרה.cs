using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathgame
{
    public partial class מסךבקרה : Form
    {
        public מסךבקרה()
        {
            InitializeComponent();
        }

        private void התחלתמשחק_Click(object sender, EventArgs e)
        {
            המשחק gameForm = new המשחק();
            gameForm.Show();
            this.Hide();
        }

        private void חוקיהמשחק_Click(object sender, EventArgs e)
        {
            חוקיהמשחק gameForm = new חוקיהמשחק();
            gameForm.Show();
            this.Hide();
        }

        private void חזרהלמסךראשי_Click(object sender, EventArgs e)
        {
            //GameForm gameForm = new GameForm();
           // gameForm.Show();
            this.Hide();
        }
    }
}
