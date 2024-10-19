using System.Windows.Forms.DataVisualization.Charting;

namespace CursachGraphics
{
    public partial class Form1 : Form
    {
        string[] labelArray = { "ASin(Bx + C) + D", "ACos(Bx + C) + D", "Aln(Bx + C) + D", "Aexp(Bx + C) + D", "Ax3 + Bx2 + Cx + D", "Введите функцию" };
        int selectedFunction = 0;
        double a = -20, b = 20, c = -20, d = 20;
        double x, y, h;
        double A, B, C, D;
        int ind = 0;
        List<GraphicEx> Graphics = new List<GraphicEx>();
        bool isExists = false;
        bool isGraphicSelected = false;
        public Form1()
        {
            InitializeComponent();
            //this.AddGraphic();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelFunction.Text = labelArray[comboBox1.SelectedIndex];
            selectedFunction = comboBox1.SelectedIndex;
        }
        private bool readData()
        {
            double tempDouble;
            //A = double.Parse(textBoxA.Text);
            //B = double.Parse(textBoxB.Text);
            //C = double.Parse(textBoxC.Text);
            //D = double.Parse(textBoxD.Text);
            //tempDouble = 0;
            if (selectedFunction == 5)
            {
                labelError.Text = "Ошибок нет";
                return true;
            }
            if (double.TryParse(textBoxA.Text, out tempDouble))
            {
                A = tempDouble;
            }
            else
            {
                //ERROR
                labelError.Text = "Ошибка в поле А";
                //labelA.
                return false;
            }
            if (double.TryParse(textBoxB.Text, out tempDouble))
            {
                B = tempDouble;
            }
            else
            {
                //ERROR
                labelError.Text = "Ошибка в поле B";
                return false;
            }
            if (double.TryParse(textBoxC.Text, out tempDouble))
            {
                C = tempDouble;
            }
            else
            {
                //ERROR
                labelError.Text = "Ошибка в поле C";
                return false;
            }
            if (double.TryParse(textBoxD.Text, out tempDouble))
            {
                D = tempDouble;
            }
            else
            {
                //ERROR
                labelError.Text = "Ошибка в поле D";
                return false;
            }
            if (B == 0 && C == 0 && selectedFunction == 2)
            {
                //ERROR
                labelError.Text = "Ошибка: Bx + C = 0";
                return false;
            }
            labelError.Text = "Ошибок нет";
            return true;
        }
        private void AddGraphic()
        {
            //Добавляем объект GraphicEx

            this.chart1.Legends[0].Enabled = true;
            string seriesName1 = "NONE";
            string temp = "Sin";
            Random rnd = new Random();
            switch (selectedFunction)
            {
                case 0:
                    {
                        temp = "Sin";
                        seriesName1 = string.Format("{0}*SIN({1}*x + {2}) + {3}", A, B, C, D);
                        GraphicEx tempGr = new GraphicEx(A, B, C, D, temp, seriesName1);
                        tempGr.color = rnd.Next(0, 5);
                        Graphics.Add(tempGr);
                        break;
                    }
                case 1:
                    {
                        temp = "Cos";
                        seriesName1 = string.Format("{0}*COS({1}*x + {2}) + {3}", A, B, C, D);
                        GraphicEx tempGr = new GraphicEx(A, B, C, D, temp, seriesName1);
                        tempGr.color = rnd.Next(0, 5);
                        Graphics.Add(tempGr);
                        break;
                    }
                case 2:
                    {
                        temp = "ln";
                        seriesName1 = string.Format("{0}*LOGN({1}*x + {2}) + {3}", A, B, C, D);
                        GraphicEx tempGr = new GraphicEx(A, B, C, D, temp, seriesName1);
                        tempGr.color = rnd.Next(0, 5);
                        Graphics.Add(tempGr);
                        break;
                    }
                case 3:
                    {
                        temp = "Exp";
                        seriesName1 = string.Format("{0}*EXP({1}*x + {2}) + {3}", A, B, C, D);
                        GraphicEx tempGr = new GraphicEx(A, B, C, D, temp, seriesName1);
                        tempGr.color = rnd.Next(0, 5);
                        Graphics.Add(tempGr);
                        break;
                    }
                case 4:
                    {
                        temp = "polynom";
                        seriesName1 = string.Format("{0}*x^3 + {1}*x^2 + {2}*x + {3}", A, B, C, D);
                        GraphicEx tempGr = new GraphicEx(A, B, C, D, temp, seriesName1);
                        tempGr.color = rnd.Next(0, 5);
                        Graphics.Add(tempGr);
                        break;
                    }
                case 5:
                    {
                        seriesName1 = textBoxYourGraphic.Text;
                        GraphicEx tempGr = new GraphicEx(seriesName1);
                        tempGr.color = rnd.Next(0, 5);
                        Graphics.Add(tempGr);
                        break;
                    }
                default:
                    break;
            }


            //Добавляем Series


            if (ind == 0)
            {
                ind++;
                //seriesName1 = "";
                chart1.Series[0].Name = seriesName1;
                chart1.Series[0].BorderWidth = 3;
                //Добавляем его в ComboBoxGraphics
                comboBoxGraphics.Items.Add(seriesName1);
            }
            else
            {
                //seriesName1 = "Series" + ind;
                if (chart1.Series.IsUniqueName(seriesName1))
                {
                    Series ser1 = chart1.Series.Add(seriesName1);
                    ser1.ChartArea = chart1.ChartAreas[0].Name;
                    ser1.Name = seriesName1;
                    ser1.ChartType = SeriesChartType.Spline;
                    ser1.BorderWidth = 3;
                    ind++;
                    //Добавляем его в ComboBoxGraphics
                    comboBoxGraphics.Items.Add(seriesName1);
                }
            }
            //Рисуем график
            chartRedraw();
        }
        private void chartRedraw()
        {
            //Надо перерисовать ВСЕ графики
            chart1.ChartAreas[0].AxisX.Maximum = b;
            chart1.ChartAreas[0].AxisX.Minimum = a;
            chart1.ChartAreas[0].AxisY.Maximum = d;
            chart1.ChartAreas[0].AxisY.Minimum = c;
            chart1.ChartAreas[0].AxisX.Title = "Ось  x";
            chart1.ChartAreas[0].AxisY.Title = "Ось  y";
            for (int i = 0; i < chart1.Series.Count; i++)
            {
                isExists = true;
                this.chart1.Series[i].Points.Clear();
                switch (Graphics[i].color)
                {
                    case 0:
                        this.chart1.Series[i].Color = Color.DarkRed; break;
                    case 1:
                        this.chart1.Series[i].Color = Color.DarkBlue; break;
                    case 2:
                        this.chart1.Series[i].Color = Color.DarkCyan; break;
                    case 3:
                        this.chart1.Series[i].Color = Color.DarkGreen; break;
                    case 4:
                        this.chart1.Series[i].Color = Color.Orange; break;
                    case 5:
                        this.chart1.Series[i].Color = Color.Violet; break;
                    default:
                        this.chart1.Series[i].Color = Color.Red; break;
                }
                for (x = a; x <= b; x += h)
                {
                    try
                    {
                        y = Graphics[i].calculate(x);
                        if (y >= d)
                            y = d;
                        this.chart1.Series[i].Points.AddXY(x, y);
                    }
                    catch
                    {
                        Console.WriteLine("!!!");
                    }
                }
            }

        }

        private void buttonRedraw_Click(object sender, EventArgs e) //КНОПКА ДОБАВЛЕНИЯ ГРАФИКА
        {
            h = (b - a) / 1000;

            chart1.ChartAreas[0].AxisX.Maximum = b;
            chart1.ChartAreas[0].AxisX.Minimum = a;
            chart1.ChartAreas[0].AxisY.Maximum = d;
            chart1.ChartAreas[0].AxisY.Minimum = c;
            if (readData())
                AddGraphic();

        }

        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (!isExists) return;
            if (e.Delta > 0)
            {
                //прокрутка вверх, надо увеличить масштаб
                a = a / 2.0;
                b = b / 2.0;
                c = c / 2.0;
                d = d / 2.0;
                h = (b - a) / 1000.0;
                chart1.ChartAreas[0].AxisX.Maximum = b;
                chart1.ChartAreas[0].AxisX.Minimum = a;
                chart1.ChartAreas[0].AxisY.Maximum = d;
                chart1.ChartAreas[0].AxisY.Minimum = c;
                chartRedraw();

            }
            else
            {
                a = a * 2.0;
                b = b * 2.0;
                c = c * 2.0;
                d = d * 2.0;
                h = (b - a) / 1000.0;
                chart1.ChartAreas[0].AxisX.Maximum = b;
                chart1.ChartAreas[0].AxisX.Minimum = a;
                chart1.ChartAreas[0].AxisY.Maximum = d;
                chart1.ChartAreas[0].AxisY.Minimum = c;
                chartRedraw();
                //прокрутка вниз, надо уменьшить масштаб
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            double h1 = (b - a) / 5;
            double h2 = (c - d) / 5;
            if (isExists)
            {
                switch (keyData)
                {
                    case Keys.Down:
                        d += h2;
                        c += h2;
                        chartRedraw();
                        break;
                    case Keys.Up:
                        d -= h2;
                        c -= h2;
                        chartRedraw();
                        //Handle up arrow key event
                        break;
                    case Keys.Right:
                        a += h1;
                        b += h1;
                        chartRedraw();
                        //Handle right arrow key event
                        break;
                    case Keys.Left:
                        a -= h1;
                        b -= h1;
                        chartRedraw();
                        //Handle left arrow key event
                        break;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void comboBoxGraphics_SelectedIndexChanged(object sender, EventArgs e)
        {
            isGraphicSelected = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (isGraphicSelected)
            {
                string temp1 = comboBoxGraphics.SelectedItem.ToString();
                GraphicEx tempGr;
                for (int i = 0; i < Graphics.Count; i++)
                {
                    if (Graphics[i].displayName == temp1)
                    {
                        tempGr = Graphics[i];
                        Graphics.Remove(tempGr);
                        break;
                    }
                }
                chart1.Series.Remove(chart1.Series.FindByName(temp1));
                comboBoxGraphics.Items.Remove(temp1);
            }
            isGraphicSelected=false;
        }
    }
}
