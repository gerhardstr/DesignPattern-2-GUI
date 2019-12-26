using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkModeHorizontal
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            NavigationLayoutLeft(this.buttonNew);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            NavigationLayoutTop(this.buttonOpen);  
        }

        private void buttonCars_Click(object sender, EventArgs e)
        {
            NavigationLayoutTop(this.buttonCars);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            NavigationLayoutTop(this.buttonSave);
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            NavigationLayoutTop(this.buttonQuit);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            NavigationLayoutLeft(this.buttonNew);
        }

        private void NavigationLayoutTop(Button button)
        {
            panelLeft.Top = button.Bottom - 7;
            panelLeft.Left = button.Left;
            panelLeft.Height = 7;
            panelLeft.Width = button.Width;
        }

        private void NavigationLayoutLeft(Button button)
        {
            panelLeft.Top = button.Top;
            panelLeft.Left = button.Left - 7;
            panelLeft.Height = button.Height;
            panelLeft.Width = 7;
        }

    }
}
