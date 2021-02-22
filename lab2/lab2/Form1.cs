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
        List<Panel> panelList;
        Button buttonPrototype;
        const int MaxN = 9;
        Random rnd = new Random();
        Point StartPoint = new Point(300, 10);
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Maximum = MaxN;

            panelList = new List<Panel>();
            buttonPrototype = new Button();

            buttonPrototype.Width = 100;
            buttonPrototype.Height = 50;
            buttonPrototype.BackColor = Color.Gray;
            buttonPrototype.ForeColor = Color.Red;
            buttonPrototype.Font = new Font("Courier", 24, FontStyle.Italic);

            
            

            for (int i = 0; i < MaxN; i++)
            {
                panelList.Add(new Panel());
                panelList[i].Controls.Add(buttonPrototype);
                panelList[i].Width = buttonPrototype.Width;
                panelList[i].Height = buttonPrototype.Height;
                //panelList[i].Font = buttonPrototype.Font;
                //panelList[i].BackColor = buttonPrototype.BackColor;
                //panelList[i].ForeColor = buttonPrototype.ForeColor;
                panelList[i].Visible = false;
                panelList[i].BringToFront();
                panelList[i].Location = new Point(StartPoint.X, StartPoint.Y + (buttonPrototype.Height + 10) * i);
                this.Controls.Add(panelList[i]);
            }


        }


        void SetCursor(int N)
        {
            var TopBorder = panelList[0].Location.Y;
            var BottomBorder = panelList[N].Location.Y + panelList[N].Size.Height;
            var p1 = new Point(StartPoint.X + buttonPrototype.Width + 50, (TopBorder + BottomBorder) / 2);
            var p = PointToScreen(p1);
            Rectangle screenRectangle = this.RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            p.Y -= titleHeight;

            Cursor.Position = p;
        }
        void SetRandomNums (int N)
        {
            
            int[] nums = new int[MaxN] {0,0,0, 0, 0, 0, 0, 0, 0 };
            for (int i = 1; i <= N; i++)
            {
                var t = rnd.Next(2, N+1) - 1;
                var count = 0;
                do
                {
                    if (nums[t] == 0) { 
                        nums[t] = i;
                        count++;
                        break; 
                    }
                   
                    else t = (t+1) %( N);
                } while (count!=N);
            }

            for (int i = 0; i < N; i++)
            {
                //var lbl = new Label();
                //lbl.Text = nums[i].ToString();
                //panelList[i].Controls.Add(lbl);
                
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int N = (int)numericUpDown1.Value;
            for (int i = 0; i < N; i++)
            {
                panelList[i].Visible = true;
            }
            SetCursor(N);
           
            var desiredBtnNum = rnd.Next(2, N)-1;
            labelDesired.Text = desiredBtnNum.ToString();
            SetRandomNums(N);


        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MaxN; i++)
            {
                panelList[i].Visible = false;
            }
            labelDesired.Text = "";
        }
    }
}
