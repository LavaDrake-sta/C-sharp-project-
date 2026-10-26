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
    public partial class חוקיהמשחק : Form
    {
        public חוקיהמשחק()
        {
            InitializeComponent();
        }

        private void התחלתהמשחק_Click(object sender, EventArgs e)
        {
            המשחק gameForm = new המשחק();
            gameForm.Show();
            this.Hide();
        }

        private void החזרהלתפריט_Click(object sender, EventArgs e)
        {
            מסךבקרה gameForm = new מסךבקרה();
            gameForm.Show();
            this.Hide();
        }
    }
}
