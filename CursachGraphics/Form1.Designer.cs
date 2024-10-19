namespace CursachGraphics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            labelD = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            textBoxD = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            comboBox1 = new ComboBox();
            labelFunction = new Label();
            buttonRedraw = new Button();
            labelError = new Label();
            textBoxYourGraphic = new TextBox();
            comboBoxGraphics = new ComboBox();
            labelCurrentGraphics = new Label();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 141);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Добавить график:";
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Location = new Point(12, 35);
            labelA.Name = "labelA";
            labelA.Size = new Size(26, 15);
            labelA.TabIndex = 1;
            labelA.Text = "A =";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Location = new Point(12, 61);
            labelB.Name = "labelB";
            labelB.Size = new Size(25, 15);
            labelB.TabIndex = 2;
            labelB.Text = "B =";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Location = new Point(12, 89);
            labelC.Name = "labelC";
            labelC.Size = new Size(26, 15);
            labelC.TabIndex = 3;
            labelC.Text = "C =";
            // 
            // labelD
            // 
            labelD.AutoSize = true;
            labelD.Location = new Point(12, 117);
            labelD.Name = "labelD";
            labelD.Size = new Size(26, 15);
            labelD.TabIndex = 4;
            labelD.Text = "D =";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(44, 29);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(100, 23);
            textBoxA.TabIndex = 5;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(44, 58);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(100, 23);
            textBoxB.TabIndex = 6;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(44, 86);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(100, 23);
            textBoxC.TabIndex = 7;
            // 
            // textBoxD
            // 
            textBoxD.Location = new Point(44, 115);
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(100, 23);
            textBoxD.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Текущие графики:";
            legend1.Enabled = false;
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(162, 29);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series0";
            chart1.Series.Add(series1);
            chart1.Size = new Size(626, 409);
            chart1.TabIndex = 9;
            chart1.Text = "chart1";
            chart1.MouseWheel += chart1_MouseWheel;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Синус", "Косинус", "Натуральный логарифм", "Экспонента", "Многочлен", "Произвольный" });
            comboBox1.Location = new Point(12, 159);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(132, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelFunction
            // 
            labelFunction.AutoSize = true;
            labelFunction.Location = new Point(12, 185);
            labelFunction.Name = "labelFunction";
            labelFunction.Size = new Size(55, 15);
            labelFunction.TabIndex = 11;
            labelFunction.Text = "Функция";
            labelFunction.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonRedraw
            // 
            buttonRedraw.Location = new Point(10, 203);
            buttonRedraw.Name = "buttonRedraw";
            buttonRedraw.Size = new Size(133, 23);
            buttonRedraw.TabIndex = 12;
            buttonRedraw.Text = "Добавить график";
            buttonRedraw.TextAlign = ContentAlignment.MiddleRight;
            buttonRedraw.UseVisualStyleBackColor = true;
            buttonRedraw.Click += buttonRedraw_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Location = new Point(11, 408);
            labelError.Name = "labelError";
            labelError.Size = new Size(75, 15);
            labelError.TabIndex = 13;
            labelError.Text = "Ошибок нет";
            // 
            // textBoxYourGraphic
            // 
            textBoxYourGraphic.Location = new Point(4, 451);
            textBoxYourGraphic.Name = "textBoxYourGraphic";
            textBoxYourGraphic.Size = new Size(867, 23);
            textBoxYourGraphic.TabIndex = 14;
            // 
            // comboBoxGraphics
            // 
            comboBoxGraphics.FormattingEnabled = true;
            comboBoxGraphics.Location = new Point(11, 318);
            comboBoxGraphics.Name = "comboBoxGraphics";
            comboBoxGraphics.Size = new Size(132, 23);
            comboBoxGraphics.TabIndex = 15;
            comboBoxGraphics.SelectedIndexChanged += comboBoxGraphics_SelectedIndexChanged;
            // 
            // labelCurrentGraphics
            // 
            labelCurrentGraphics.AutoSize = true;
            labelCurrentGraphics.Location = new Point(12, 300);
            labelCurrentGraphics.Name = "labelCurrentGraphics";
            labelCurrentGraphics.Size = new Size(97, 15);
            labelCurrentGraphics.TabIndex = 16;
            labelCurrentGraphics.Text = "Удалить график:";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(12, 349);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 486);
            Controls.Add(buttonDelete);
            Controls.Add(labelCurrentGraphics);
            Controls.Add(comboBoxGraphics);
            Controls.Add(textBoxYourGraphic);
            Controls.Add(labelError);
            Controls.Add(buttonRedraw);
            Controls.Add(labelFunction);
            Controls.Add(comboBox1);
            Controls.Add(chart1);
            Controls.Add(textBoxD);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(labelD);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Построитель графиков";
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelA;
        private Label labelB;
        private Label labelC;
        private Label labelD;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private TextBox textBoxD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ComboBox comboBox1;
        private Label labelFunction;
        private Button buttonRedraw;
        private Label labelError;
        private TextBox textBoxYourGraphic;
        private ComboBox comboBoxGraphics;
        private Label labelCurrentGraphics;
        private Button buttonDelete;
    }
}
