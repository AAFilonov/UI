namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ButtonsAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelDesired = new System.Windows.Forms.Label();
            this.checkBoxEx2 = new System.Windows.Forms.CheckBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 63);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(144, 7);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество кнопок:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(189, 63);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.ButtonsAmount,
            this.Time});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 92);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(199, 489);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // number
            // 
            this.number.Text = "№ Опыта";
            // 
            // ButtonsAmount
            // 
            this.ButtonsAmount.Text = "Кнопок";
            // 
            // Time
            // 
            this.Time.Text = "Время";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(103, 63);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Сброс";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 93);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(46, 488);
            this.textBox1.TabIndex = 9;
            // 
            // labelDesired
            // 
            this.labelDesired.AutoSize = true;
            this.labelDesired.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.labelDesired.Location = new System.Drawing.Point(657, 13);
            this.labelDesired.Name = "labelDesired";
            this.labelDesired.Size = new System.Drawing.Size(0, 63);
            this.labelDesired.TabIndex = 10;
            // 
            // checkBoxEx2
            // 
            this.checkBoxEx2.AutoSize = true;
            this.checkBoxEx2.Location = new System.Drawing.Point(186, 33);
            this.checkBoxEx2.Name = "checkBoxEx2";
            this.checkBoxEx2.Size = new System.Drawing.Size(78, 17);
            this.checkBoxEx2.TabIndex = 12;
            this.checkBoxEx2.Text = "Задание 2";
            this.checkBoxEx2.UseVisualStyleBackColor = true;
            this.checkBoxEx2.CheckedChanged += new System.EventHandler(this.checkBoxEx2_CheckedChanged);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DisplayMember = "3";
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "14",
            "16",
            ""});
            this.comboBoxSize.Location = new System.Drawing.Point(12, 31);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(37, 21);
            this.comboBoxSize.TabIndex = 13;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(108, 31);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(72, 21);
            this.comboBoxColor.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Цвет:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.checkBoxEx2);
            this.Controls.Add(this.labelDesired);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader ButtonsAmount;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelDesired;
        private System.Windows.Forms.CheckBox checkBoxEx2;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label2;
    }
}

