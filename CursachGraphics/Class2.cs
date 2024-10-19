using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using org.mariuszgromada.math.mxparser;

namespace CursachGraphics
{
    internal class GraphicEx
    {
        private double A, B, C, D;
        private string S;
        public string displayName;
        public int color;
        private Expression e;
        private Argument x;
        public GraphicEx(double A, double B, double C, double D, string S, string displayName)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;
            this.S = S;
            this.displayName = displayName;
        }
        public GraphicEx(string S)
        {
            this.A = 0;
            this.B = 0;
            this.C = 0;
            this.D = 0;
            this.S = S;
            this.displayName = S;
            x = new Argument("x", -1);
            e = new Expression(S, x);
        }
        public double calculate(double x1)
        {
            if (S.Equals("Sin"))
            {
                return A*Math.Sin(B*x1 + C) + D;
            }
            else if (S.Equals("Cos"))
            {
                return A * Math.Cos(B * x1 + C) + D;
            }
            else if (S.Equals("ln"))
            {
                return A * Math.Log(B * x1 + C) + D;
            }
            else if (S.Equals("Exp"))
            {
                try
                {
                    return A * (double)Math.Exp(B * x1 + C) + D;
                }
                catch
                {
                    return 0;
                }
            }
            else if (S.Equals("polynom"))
            {
                return A * Math.Pow(x1, 3) + B * Math.Pow(x1, 2) + C * x1 + D;
            }
            else//ПРОИЗВОЛЬНОЕ ВЫРАЖЕНИЕ
            {
                //Argument x = new Argument("x", x1);
                //e = new Expression(S, x);
                x.setArgumentValue(x1);
                return e.calculate(); 
            }
            return 0;
        }
    }
}

/*this.chart1.Series[0].Points.Clear();
            isExists = true;
            chart1.ChartAreas[0].AxisX.Maximum = b;
            chart1.ChartAreas[0].AxisX.Minimum = a;
            chart1.ChartAreas[0].AxisY.Maximum = d;
            chart1.ChartAreas[0].AxisY.Minimum = c;
            for (x = a; x <= b; x += h)
            {
                //y = A * Math.Sin(B * x + C) + D;
                switch (selectedFunction)
                {
                    case 0:
                        y = A * Math.Sin(B * x + C) + D;
                        break;
                    case 1:
                        y = A * Math.Cos(B * x + C) + D;
                        break; 
                    case 2:
                        y = A * Math.Log(B * x + C) + D;
                        break;
                    case 3:
                        y = A * Math.Exp(B * x + C) + D;
                        break;
                    case 4:
                        y = A * Math.Pow(x, 3) + B * Math.Pow(x, 2) + C * x + D;
                        break;
                    default:
                        break;
                }
                this.chart1.Series[0].Points.AddXY(x, y);
            }*/