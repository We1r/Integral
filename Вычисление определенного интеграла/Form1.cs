using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Вычисление_определенного_интеграла
{
    public partial class Form1 : Form
    {
        private double a = 1, b = 10, epsilon = 0.01, n = 10;
        private int AccuracyForView;
        private string StringFunction;
        private Fuction fuction;
        public Form1()
        {
            InitializeComponent();
        }
        private double Round(double x)
        {
            double Accuracy = Math.Log10(epsilon) * -1.0;
            int AccuracyForView = Convert.ToInt32(Accuracy);
            if (AccuracyForView < 0)
            {
                AccuracyForView = 0;
            }
            double RoundX = Math.Round(x, AccuracyForView);
            return RoundX;
        }

        private void functionString_TextChanged(object sender, EventArgs e)
        {

        }
        private void setupFunction()
        {
            if (TextBoxFunction.Text == "" || TextBoxFunction.Text == " ")
            {
                StringFunction = "(27 - 18 * x + 2 * x^2) * exp(-x/3)";
            }
            else
            {
                StringFunction = TextBoxFunction.Text;
            }
            fuction = new Fuction(StringFunction);
        }

        private void Visualisation()
        {
            double x;
            double y;
            if (a < b)
            {
                x = a;

                chart1.Series[0].Points.Clear();
                while (x <= b)
                {
                    y = fuction.StandartFunction(x);
                    chart1.Series[0].Points.AddXY(x, y);
                    x += 0.01;
                }
            }
        }
        private void DrawLeftRectangles()
        {
            double h = (b - a) / n;
            double x;
            double y;

            chart1.Series[1].Points.Clear();

            for (int i = 0; i < n; i++)
            {
                x = a + i * h;
                y = fuction.StandartFunction(x);

                // Добавляем прямоугольники на график
                chart1.Series[1].Points.AddXY(x, y);
                chart1.Series[1].Points.AddXY(x + h, y);
                chart1.Series[1].Points.AddXY(x + h, 0);
                chart1.Series[1].Points.AddXY(x, 0);
                chart1.Series[1].Points.AddXY(x, y);
            }
        }
        private void DrawRightRectangles()
        {
            double h = (b - a) / n;
            double x;
            double y;

            chart1.Series[1].Points.Clear();

            for (int i = 0; i < n; i++)
            {
                x = a + i * h;
                y = fuction.StandartFunction(x + h);

                // Добавляем прямоугольники на график
                chart1.Series[1].Points.AddXY(x + h, y);
                chart1.Series[1].Points.AddXY(x + h, 0);
                chart1.Series[1].Points.AddXY(x, 0);
                chart1.Series[1].Points.AddXY(x, y);
                chart1.Series[1].Points.AddXY(x + h, y);
            }
        }
        private void DrawCenterRectangles()
        {
            double h = (b - a) / n;
            double x;
            double y;

            chart1.Series[1].Points.Clear();

            for (int i = 0; i < n; i++)
            {
                x = a + i * h + h / 2;  // Средняя точка прямоугольника
                y = fuction.StandartFunction(x);

                // Добавляем прямоугольники на график
                chart1.Series[1].Points.AddXY(x - h / 2, y);
                chart1.Series[1].Points.AddXY(x + h / 2, y);
                chart1.Series[1].Points.AddXY(x + h / 2, 0);
                chart1.Series[1].Points.AddXY(x - h / 2, 0);
                chart1.Series[1].Points.AddXY(x - h / 2, y);
            }
        }
        private void DrawTrapezoids()
        {
            double h = (b - a) / n;
            double x;
            double y1, y2;

            chart1.Series[1].Points.Clear();

            for (int i = 0; i < n; i++)
            {
                x = a + i * h;
                y1 = fuction.StandartFunction(x);
                y2 = fuction.StandartFunction(x + h);

                // Добавляем трапеции на график
                chart1.Series[1].Points.AddXY(x, y1);
                chart1.Series[1].Points.AddXY(x + h, y2);
                chart1.Series[1].Points.AddXY(x + h, 0);
                chart1.Series[1].Points.AddXY(x, 0);
                chart1.Series[1].Points.AddXY(x, y1);
            }
        }
        private void ParsFormView()
        {
            try
            {
                a = Convert.ToDouble(textBoxA.Text);
                b = Convert.ToDouble(textBoxB.Text);
                epsilon = Convert.ToDouble(textBoxEpsilon.Text);
                n = Convert.ToDouble(textBoxN.Text);

                double Accuracy = Math.Log10(epsilon) * -1.0;
                AccuracyForView = Convert.ToInt32(Accuracy);
                if (AccuracyForView < 0)
                {
                    AccuracyForView = 0;
                }
            }
            catch
            {
                //MessageBox.Show("Пожалуйста, введите корректные числовые значения для a, b и точности (epsilon).", "Ошибка");
            }
        }

        private void методПравыхПрямоугольниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParsFormView();
            //ClearTextBox();

            if (epsilon <= 0)
            {
                MessageBox.Show("Введите точность через запятую", "error");
            }
            else if (n <= 0)
            {
                MessageBox.Show("Введите количество разбиений", "error");
            }
            else
            {
                if (a >= b)
                {
                    MessageBox.Show("А должно быть меньше B", "Ошибка");
                }
                else
                {
                    setupFunction();
                    Visualisation();
                    if (checkBox1.Checked == true)
                    {
                        DrawRightRectangles();
                    }
                    RightRectangle();
                }
            }
        }

        private void методЛевыхПрямоугольниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParsFormView();
            //ClearTextBox();

            if (epsilon <= 0)
            {
                MessageBox.Show("Введите точность через запятую", "error");
            } else if (n <= 0)
            {
                MessageBox.Show("Введите количество разбиений", "error");
            } else
            {
                if (a >= b)
                {
                    MessageBox.Show("А должно быть меньше B", "Ошибка");
                } else
                {
                    setupFunction();
                    Visualisation();
                    if (checkBox1.Checked == true)
                    {
                        DrawLeftRectangles();
                    }
                    LeftRectangle();
                }
            }
        }

        private void методСреднихПрямоугольниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParsFormView();
            //ClearTextBox();

            if (epsilon <= 0)
            {
                MessageBox.Show("Введите точность через запятую", "error");
            }
            else if (n <= 0)
            {
                MessageBox.Show("Введите количество разбиений", "error");
            }
            else
            {
                if (a >= b)
                {
                    MessageBox.Show("А должно быть меньше B", "Ошибка");
                }
                else
                {
                    setupFunction();
                    Visualisation();
                    if (checkBox1.Checked == true)
                    {
                        DrawCenterRectangles();
                    }
                    CentralRectangle();
                }
            }
        } 
        private void методТрапецийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParsFormView();
            //ClearTextBox();

            if (epsilon <= 0)
            {
                MessageBox.Show("Введите точность через запятую", "error");
            }
            else if (n <= 0)
            {
                MessageBox.Show("Введите количество разбиений", "error");
            }
            else
            {
                if (a >= b)
                {
                    MessageBox.Show("А должно быть меньше B", "Ошибка");
                }
                else
                {
                    setupFunction();
                    Visualisation();
                    if (checkBox1.Checked == true)
                    {
                        DrawTrapezoids();
                    }
                    TrapezoidalIntegration();
                }
            }
        }
        private void методСимпсонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParsFormView();
            //ClearTextBox();

            if (epsilon <= 0)
            {
                MessageBox.Show("Введите точность через запятую", "error");
            }
            else if (n <= 0)
            {
                MessageBox.Show("Введите количество разбиений", "error");
            }
            else
            {
                if (a >= b)
                {
                    MessageBox.Show("А должно быть меньше B", "Ошибка");
                }
                else
                {
                    setupFunction();
                    Visualisation();
                    Simpson();
                }
            }
        }
        private void TrapezoidalIntegration()
        {
            double h = (b - a) / n;
            double sum = 0;

            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                sum += fuction.StandartFunction(x);
            }

            sum += (fuction.StandartFunction(a) + fuction.StandartFunction(b)) / 2;

            var result = Round(h * sum);

            textBoxIntegral.Text = Convert.ToString(result);
        }
        private void Simpson()
        {
            var h = (b - a) / n;
            var sum1 = 0d;
            var sum2 = 0d;
            for (var k = 1; k <= n; k++)
            {
                var xk = a + k * h;
                if (k <= n - 1)
                {
                    sum1 += fuction.StandartFunction(xk);
                }

                var xk_1 = a + (k - 1) * h;
                sum2 += fuction.StandartFunction((xk + xk_1) / 2);
            }

            var result = Round(h / 3d * (1d / 2d * fuction.StandartFunction(a) + sum1 + 2 * sum2 + 1d / 2d * fuction.StandartFunction(b)));
            textBoxIntegral.Text = Convert.ToString(result);
        }
        private void CentralRectangle()
        {
            var h = (b - a) / n;
            var sum = (fuction.StandartFunction(a) + fuction.StandartFunction(b)) / 2;
            for (var i = 1; i < n; i++)
            {
                var x = a + h * i;
                sum += fuction.StandartFunction(x);
            }

            var result = Round(h * sum);
            textBoxIntegral.Text = Convert.ToString(result);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void calculToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxEpsilon.Clear();
            textBoxIntegral.Clear();
            textBoxN.Clear();
            textBoxIntegral.Clear();
            checkBox1.Checked = false;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }

        private void найтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParsFormView();
            if (a >= b)
            {
                MessageBox.Show("А должно быть меньше B", "Ошибка");
            }
            else
            {
                setupFunction();
                for (int Splitting = 1; Splitting < 10000; ++Splitting)
                {
                    n = Splitting;

                    //RightRectangle
                    var h = (b - a) / n;
                    var sum = 0d;
                    for (var i = 1; i <= n; i++)
                    {
                        var x = a + i * h;
                        sum += fuction.StandartFunction(x);
                    }

                    var resultRightRectangle = Round(h * sum);

                    //LeftRectangle
                    h = (b - a) / n;
                    sum = 0d;
                    for (var i = 0; i <= n - 1; i++)
                    {
                        var x = a + i * h;
                        sum += fuction.StandartFunction(x);
                    }
                    var resultLeftRectangle = Round(h * sum);

                    //CentralRectangle
                    h = (b - a) / n;
                    sum = (fuction.StandartFunction(a) + fuction.StandartFunction(b)) / 2;
                    for (var i = 1; i < n; i++)
                    {
                        var x = a + h * i;
                        sum += fuction.StandartFunction(x);
                    }

                    var resultCentralRectangle = Round(h * sum);

                    //Simpson
                    h = (b - a) / n;
                    var sum1 = 0d;
                    var sum2 = 0d;
                    for (var k = 1; k <= n; k++)
                    {
                        var xk = a + k * h;
                        if (k <= n - 1)
                        {
                            sum1 += fuction.StandartFunction(xk);
                        }

                        var xk_1 = a + (k - 1) * h;
                        sum2 += fuction.StandartFunction((xk + xk_1) / 2);
                    }

                    var resultSimpson = Round(h / 3d * (1d / 2d * fuction.StandartFunction(a) + sum1 + 2 * sum2 + 1d / 2d * fuction.StandartFunction(b)));

                    //TrapezoidalIntegration
                    h = (b - a) / n;
                    sum = 0;

                    for (int i = 1; i < n; i++)
                    {
                        double x = a + i * h;
                        sum += fuction.StandartFunction(x);
                    }

                    sum += (fuction.StandartFunction(a) + fuction.StandartFunction(b)) / 2;

                    var resultTrapezoidalIntegration = Round(h * sum);

                    if (resultRightRectangle == resultLeftRectangle && resultLeftRectangle == resultCentralRectangle && resultCentralRectangle == resultSimpson && resultSimpson == resultTrapezoidalIntegration)
                    {
                        textBoxN.Text = Convert.ToString(Splitting);
                        break;
                    }
                }
            }
        }

        private void textBoxN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 188)
            {
                e.Handled = true;
            }
        }

        private void RightRectangle()
        {
            var h = (b - a) / n;
            var sum = 0d;
            for (var i = 1; i <= n; i++)
            {
                var x = a + i * h;
                sum += fuction.StandartFunction(x);
            }

            var result = Round(h * sum);


            textBoxIntegral.Text = Convert.ToString(result);
        }
        private void LeftRectangle()
        {
                var h = (b - a) / n;
                var sum = 0d;
                for (var i = 0; i <= n - 1; i++)
                {
                    var x = a + i * h;
                    sum += fuction.StandartFunction(x);
                }
            var result = Round(h * sum);

            textBoxIntegral.Text = Convert.ToString(result);
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
