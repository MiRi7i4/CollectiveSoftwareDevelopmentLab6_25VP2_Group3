namespace CollectiveSoftwareDevelopmentLab6_25VP2_Group3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            findBtn = new Button();
            exitBtn = new Button();
            panel1 = new Panel();
            keyInput = new NumericUpDown();
            panel2 = new Panel();
            baisicInd = new TextBox();
            basicTime = new TextBox();
            panel3 = new Panel();
            optimalInd = new TextBox();
            optimalTime = new TextBox();
            panel4 = new Panel();
            interpolInd = new TextBox();
            interpolTime = new TextBox();
            panel5 = new Panel();
            linearlikeBinInd = new TextBox();
            linearlikeBinTime = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)keyInput).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 20);
            label1.Name = "label1";
            label1.Size = new Size(193, 20);
            label1.TabIndex = 0;
            label1.Text = "Лабораторная работа №6";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 14);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Ключ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 6);
            label3.Name = "label3";
            label3.Size = new Size(236, 20);
            label3.TabIndex = 2;
            label3.Text = "Неоптиальный бинарный поиск";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 52);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Время";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(296, 52);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "Индекс";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 282);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 7;
            label6.Text = "Индекс";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 282);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 6;
            label7.Text = "Время";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(140, 17);
            label8.Name = "label8";
            label8.Size = new Size(230, 20);
            label8.TabIndex = 5;
            label8.Text = "Оптимальный бинарный поиск";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(287, 383);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 10;
            label9.Text = "Индекс";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(71, 383);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 9;
            label10.Text = "Время";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(122, 17);
            label11.Name = "label11";
            label11.Size = new Size(273, 20);
            label11.TabIndex = 8;
            label11.Text = "Интерполяционный бинарный поиск";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(287, 479);
            label12.Name = "label12";
            label12.Size = new Size(59, 20);
            label12.TabIndex = 13;
            label12.Text = "Индекс";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(71, 479);
            label13.Name = "label13";
            label13.Size = new Size(54, 20);
            label13.TabIndex = 12;
            label13.Text = "Время";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(118, 32);
            label14.Name = "label14";
            label14.Size = new Size(278, 20);
            label14.TabIndex = 11;
            label14.Text = "\"Последовательный\" бинарный поиск";
            // 
            // findBtn
            // 
            findBtn.Location = new Point(198, 547);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(94, 29);
            findBtn.TabIndex = 16;
            findBtn.Text = "Найти";
            findBtn.UseVisualStyleBackColor = true;
            findBtn.Click += findBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(403, 572);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(94, 29);
            exitBtn.TabIndex = 17;
            exitBtn.Text = "Выход";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(keyInput);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-10, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(536, 62);
            panel1.TabIndex = 18;
            // 
            // keyInput
            // 
            keyInput.Location = new Point(196, 14);
            keyInput.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            keyInput.Name = "keyInput";
            keyInput.Size = new Size(159, 27);
            keyInput.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(baisicInd);
            panel2.Controls.Add(basicTime);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-10, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(534, 100);
            panel2.TabIndex = 19;
            // 
            // baisicInd
            // 
            baisicInd.Location = new Point(361, 49);
            baisicInd.Name = "baisicInd";
            baisicInd.Size = new Size(125, 27);
            baisicInd.TabIndex = 6;
            // 
            // basicTime
            // 
            basicTime.Location = new Point(140, 49);
            basicTime.Name = "basicTime";
            basicTime.Size = new Size(125, 27);
            basicTime.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(optimalInd);
            panel3.Controls.Add(optimalTime);
            panel3.Controls.Add(label8);
            panel3.Location = new Point(-10, 218);
            panel3.Name = "panel3";
            panel3.Size = new Size(536, 104);
            panel3.TabIndex = 20;
            // 
            // optimalInd
            // 
            optimalInd.Location = new Point(361, 60);
            optimalInd.Name = "optimalInd";
            optimalInd.Size = new Size(125, 27);
            optimalInd.TabIndex = 7;
            // 
            // optimalTime
            // 
            optimalTime.Location = new Point(140, 60);
            optimalTime.Name = "optimalTime";
            optimalTime.Size = new Size(125, 27);
            optimalTime.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(interpolInd);
            panel4.Controls.Add(interpolTime);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(-10, 319);
            panel4.Name = "panel4";
            panel4.Size = new Size(536, 107);
            panel4.TabIndex = 21;
            // 
            // interpolInd
            // 
            interpolInd.Location = new Point(361, 60);
            interpolInd.Name = "interpolInd";
            interpolInd.Size = new Size(125, 27);
            interpolInd.TabIndex = 10;
            // 
            // interpolTime
            // 
            interpolTime.Location = new Point(140, 63);
            interpolTime.Name = "interpolTime";
            interpolTime.Size = new Size(125, 27);
            interpolTime.TabIndex = 9;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(linearlikeBinInd);
            panel5.Controls.Add(linearlikeBinTime);
            panel5.Controls.Add(label14);
            panel5.Location = new Point(-6, 406);
            panel5.Name = "panel5";
            panel5.Size = new Size(536, 135);
            panel5.TabIndex = 22;
            // 
            // linearlikeBinInd
            // 
            linearlikeBinInd.Location = new Point(357, 69);
            linearlikeBinInd.Name = "linearlikeBinInd";
            linearlikeBinInd.Size = new Size(125, 27);
            linearlikeBinInd.TabIndex = 13;
            // 
            // linearlikeBinTime
            // 
            linearlikeBinTime.Location = new Point(136, 69);
            linearlikeBinTime.Name = "linearlikeBinTime";
            linearlikeBinTime.Size = new Size(125, 27);
            linearlikeBinTime.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(509, 606);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(exitBtn);
            Controls.Add(findBtn);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Name = "Form1";
            Text = "25ВП2 Лабораторная работа 6";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)keyInput).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button findBtn;
        private Button exitBtn;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private NumericUpDown keyInput;
        private TextBox baisicInd;
        private TextBox basicTime;
        private TextBox optimalInd;
        private TextBox optimalTime;
        private TextBox interpolInd;
        private TextBox interpolTime;
        private TextBox linearlikeBinInd;
        private TextBox linearlikeBinTime;
    }
}
