using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var StartPosition = (Button)sender;
            var newButton = new RoundButton();
            this.Controls.Add(newButton);
            newButton.Text = "Кнопка";
            newButton.Location = new Point(StartPosition.Location.X+ 200, StartPosition.Location.Y+0);
            newButton.Size = new Size(50, 50);
            newButton.Visible = true;
            newButton.FlatStyle = FlatStyle.Flat
            newButton.FlatAppearance.BorderColor = Color.White;
            newButton.FlatAppearance.BorderSize = 1;

        }
    }
}
