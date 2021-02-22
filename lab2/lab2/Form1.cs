using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    class Item
    {
        public int Value { get; set; }
        public string Name { get; set; }
     
    }

    public partial class Form1 : Form
    {
        List<Panel> panelList = new List<Panel>();
        Button buttonPrototype = new Button();
        const int MaxN = 9;
        Random rnd = new Random();
        Stopwatch stopwatch =new Stopwatch();

        Point StartPoint = new Point(300, 10);
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Maximum = MaxN;
           
           

            comboBoxColor.DataSource = new List<Item>
            {
                new Item { Name = "White", Value = 1 },
                new Item { Name = "Black", Value = 2 },
                new Item { Name = "Yellow", Value = 3 },
                new Item { Name = "Green", Value = 4 },
                new Item { Name = "Blue", Value = 5 },
                new Item { Name = "Red", Value = 6 }

            };
            comboBoxColor.ValueMember = "Value";
            comboBoxColor.DisplayMember= "Name";
            comboBoxColor.SelectedValue = 2;
            comboBoxColor.Enabled = false;

            comboBoxSize.DataSource = new List<Item>
            {
                new Item { Name = "10", Value = 10 },
                new Item { Name = "11", Value = 11 },
                new Item { Name = "12", Value = 12 },
                new Item { Name = "14", Value = 14 },
                new Item { Name = "16", Value = 16 }             

            };
            comboBoxSize.ValueMember = "Value";
            comboBoxSize.SelectedValue = 12;           
            comboBoxSize.Enabled = false;



            buttonPrototype.Width = 100;
            buttonPrototype.Height = 50;
            buttonPrototype.BackColor = Color.Gray;
            buttonPrototype.ForeColor = Color.Red;
            buttonPrototype.Font = new Font("Courier", 24, FontStyle.Italic);

            
            

            for (int i = 0; i < MaxN; i++)
            {
                panelList.Add(new Panel());
               
                panelList[i].Width = buttonPrototype.Width;
                panelList[i].Height = buttonPrototype.Height;
               
                panelList[i].BackColor = buttonPrototype.BackColor;
                panelList[i].Padding = new System.Windows.Forms.Padding(0);
                panelList[i].Margin = new System.Windows.Forms.Padding(0);
                panelList[i].Visible = false;
                panelList[i].BringToFront();
                panelList[i].Location = new Point(StartPoint.X, StartPoint.Y + (buttonPrototype.Height + 10) * i);
                panelList[i].Click += PanelClick;
                //panelList[i].Font = buttonPrototype.Font;
                //panelList[i].ForeColor = buttonPrototype.ForeColor;
                var lbl = new Label()
                {
                    Height = 36,
                    Name = "label_" + i.ToString(),
                    Font = buttonPrototype.Font,
                    Width = 30,
                    ForeColor = buttonPrototype.ForeColor,
                  
                };

                lbl.Font = new Font("Courier", 24, FontStyle.Italic);
                lbl.Location = new Point(63 - lbl.Width, 8);
                lbl.ForeColor = buttonPrototype.ForeColor;


                panelList[i].Controls.Add(lbl);

                this.Controls.Add(panelList[i]);
            }


        }

        int count;
   

        private void PanelClick(object sender, EventArgs e)
        {
            var pnl = (Panel)sender;
            if ((int)pnl.Tag == desiredBtnNum)
            {
                stopwatch.Stop();
                count++;

                var N = (int)numericUpDown1.Value;

                var Time = stopwatch.ElapsedMilliseconds;


                textBox1.Text += Time + "\n";

                ListViewItem item = new ListViewItem(new string[] { count.ToString(), N.ToString(), Time.ToString() });
                listView1.Items.Add(item);

                buttonStart_Click(null, null);
            }
        }

        void SetCursor(int N)
        {
            var TopBorder = panelList[0].Location.Y;
            var BottomBorder = panelList[N-1].Location.Y + panelList[N-1].Size.Height;
            var p1 = new Point(StartPoint.X + buttonPrototype.Width + 50, (TopBorder + BottomBorder) / 2);
            var p = PointToScreen(p1);
            Rectangle screenRectangle = this.RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            //p.Y -= titleHeight;

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
                var lbl = panelList[i].Controls.Find("label_" + i.ToString(),false)[0];
               
                lbl.Text = nums[i].ToString();
                panelList[i].Tag = nums[i];
            }
        }
        void SetPanels(int N)
        {
            for (int i = 0; i < N; i++)
            {
                panelList[i].Visible = true;
            }
        }

        void SetDesiredStyle(int i)
        {
            var lbl = panelList[i].Controls.Find("label_" + i.ToString(), false)[0];
          
            var color = new Color();
            switch (comboBoxColor.SelectedValue)
            {
                case "White":
                    color = Color.White;
                    break;
                case "Black":
                    color = Color.Black;
                    break;
                case "Yellow":
                    color = Color.Yellow;
                    break;
                case "Green":
                    color = Color.Green;
                    break;
                case "Blue":
                    color = Color.Blue;
                    break;
                case "Red":
                    color = Color.Red;
                    break;


            }
            int size = (int)comboBoxSize.SelectedValue;
            panelList[i].BackColor = color;
            lbl.Font = new Font("Courier", size, FontStyle.Italic);



        }
        int desiredBtnNum;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int N = (int)numericUpDown1.Value;

            SetCursor(N);
            SetPanels(N);
            SetRandomNums(N);

            desiredBtnNum = rnd.Next(0, N)+1;
            if (!checkBoxEx2.Checked)
            {
                labelDesired.Text = desiredBtnNum.ToString();
            }
            else
            {
               SetDesiredStyle(desiredBtnNum);
            }



           
            if (stopwatch.IsRunning) stopwatch.Reset();
            stopwatch.Start();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MaxN; i++)
            {
                panelList[i].Visible = false;
            }
  
            labelDesired.Text = "";
            stopwatch.Reset();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            count = 0;
            textBox1.Text = "";
            listView1.Items.Clear();
            buttonCancel_Click(null, null);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            count = 0;
        }

        private void checkBoxEx2_CheckedChanged(object sender, EventArgs e)
        {

            if (((CheckBox)sender).Checked)
            {
                labelDesired.Visible = false;
              
                comboBoxColor.Enabled = true;
                comboBoxSize.Enabled = true;
                for (int i = 0; i < MaxN; i++)
                {

                    var lbl = panelList[i].Controls.Find("label_" + i.ToString(), false)[0];
                    lbl.Font = new Font("Courier", 12, FontStyle.Regular);
                    lbl.Location = new Point(73 - lbl.Width, 15);
                    lbl.ForeColor = Color.Black;
                }
            }
            else
            {
                labelDesired.Visible = true;
                comboBoxColor.Enabled = false;
                comboBoxSize.Enabled = false;
                for (int i = 0; i < MaxN; i++)
                {

                    var lbl = panelList[i].Controls.Find("label_" + i.ToString(), false)[0];
                    lbl.Font = new Font("Courier", 24, FontStyle.Italic);
                    lbl.Location = new Point(63 - lbl.Width, 8);
                    lbl.ForeColor = buttonPrototype.ForeColor;

                }
            }
        }
    }
}
