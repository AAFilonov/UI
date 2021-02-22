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

namespace Lab1
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;
        Random rnd;
        RoundButton newButton;
        public Form1()
        {
            InitializeComponent();
            this.MouseClick += mouseClickHandler;
            this.MouseMove += mouseMoveHandler;
            
            stopwatch = new Stopwatch();
            rnd = new Random();
            count = 0;

             newButton = new RoundButton();
            this.Controls.Add(newButton);
            //newButton.Text = "Кнопка";
           
            newButton.Visible = false;
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.BackColor = Color.Gray;
            newButton.FlatAppearance.BorderSize = 0;
            newButton.Click += newBtnClickHandler;
            newButton.MouseMove += mouseMoveHandler;
        }
        bool RecordStart = false;
        bool CircleCreated = false;
        private void mouseClickHandler(object sender, MouseEventArgs e)
        {
            var Distance = (int)numericUpDown1.Value;
            var Size = (int)numericUpDown2.Value;


            var StartPosition = e.Location;

            var rad = rnd.NextDouble() * (Math.PI * 2);
            Point point = new Point(
                (int)(Distance * Math.Sin(rad)),
                (int)(Distance * Math.Cos(rad))
                );
            int x_corr = (int)(-0.5 * Size), y_corr = (int)(-0.5 * Size), r_corr = 0;// (int)0.5 * Size;

           newButton.Size = new Size(Size, Size);
            
            newButton.Location = new Point(StartPosition.X + point.X +x_corr + r_corr, StartPosition.Y + point.Y + y_corr + r_corr);
            newButton.Visible = true;

            stopwatch.Reset();
            CircleCreated = true;
            RecordStart = false;

        }
        Point _LastPoint = new Point();
        private void mouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (_LastPoint != e.Location)
            {
                _LastPoint = e.Location;
                if (CircleCreated && !RecordStart)
                {

                    stopwatch.Start();
                    RecordStart = true;

                }
            }
        }


        int count;
        private void newBtnClickHandler(object sender, EventArgs e)
        {
            stopwatch.Stop();
            count++;

            var Distance = (int)numericUpDown1.Value;
            var Size = (int)numericUpDown2.Value;
            var Time = stopwatch.ElapsedMilliseconds;
          
            toolStripStatusTime.Text = Time + " мс";
            textBox1.Text += Time+"\n";
            newButton.Visible = false;

            ListViewItem item = new ListViewItem(new string[] { count.ToString(), Distance.ToString(), Size.ToString(), Time.ToString() });
            listView1.Items.Add(item);
    

            RecordStart = false;
            CircleCreated = false;
        }
        
     
        private void buttonReset_Click(object sender, EventArgs e)
        {
            count = 0;
            listView1.Items.Clear();
            textBox1.Text = "";
        }

        private void buttonСancel_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
            newButton.Visible = false;

        }

    
    }
}
