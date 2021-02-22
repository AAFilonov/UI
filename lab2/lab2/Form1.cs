using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        List<Button> buttonList;
        Button buttonPrototype;

        public Form1()
        {
            InitializeComponent();
            buttonList = new List<Button>();
            buttonPrototype = new Button();

            buttonPrototype.Width = 100;
            buttonPrototype.Height = 50;
            buttonPrototype.BackColor = Color.Gray;
            buttonPrototype.ForeColor = Color.Red;
            buttonPrototype.Font = new Font("Courier", 24, FontStyle.Italic);

            var StartPoint = new Point(panel1.Location.X, panel1.Location.Y);
            panel1.BackColor = Color.FromArgb(25, Color.White);
            panel1.SendToBack();

            for (int i = 0; i < 9; i++)
            {
                buttonList.Add(new Button());

                buttonList[i].Width = buttonPrototype.Width;
                buttonList[i].Height = buttonPrototype.Height;
                buttonList[i].Font = buttonPrototype.Font;
                buttonList[i].BackColor = buttonPrototype.BackColor;
                buttonList[i].ForeColor = buttonPrototype.ForeColor;
                buttonList[i].BringToFront();
                buttonList[i].Location = new Point(StartPoint.X, StartPoint.Y + (buttonPrototype.Height + 10) * i);
                this.Controls.Add(buttonList[i]);
            }


        }




        private void buttonStart_Click(object sender, EventArgs e)
        {

        }
    }
}
