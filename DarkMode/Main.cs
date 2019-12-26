using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkMode
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            panelLeft.Height = buttonOpen.Height;
            panelLeft.Top = buttonOpen.Top;
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonOpen.Height;
            panelLeft.Top = buttonOpen.Top;
        }

        private void buttonCars_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonCars.Height;
            panelLeft.Top = buttonCars.Top;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonSave.Height;
            panelLeft.Top = buttonSave.Top;
        }
    }
}
