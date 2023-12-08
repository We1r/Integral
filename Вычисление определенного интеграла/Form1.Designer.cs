namespace Вычисление_определенного_интеграла
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TextBoxFunction = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxEpsilon = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calculToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методПрямоугольниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методЛевыхПрямоугольниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методПравыхПрямоугольниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методСреднихПрямоугольниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методТрапецийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.методСимпсонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxIntegral = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(334, 38);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(454, 400);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // TextBoxFunction
            // 
            this.TextBoxFunction.Location = new System.Drawing.Point(101, 232);
            this.TextBoxFunction.Name = "TextBoxFunction";
            this.TextBoxFunction.Size = new System.Drawing.Size(88, 20);
            this.TextBoxFunction.TabIndex = 14;
            this.TextBoxFunction.TextChanged += new System.EventHandler(this.functionString_TextChanged);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(72, 282);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(26, 20);
            this.textBoxA.TabIndex = 15;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(72, 176);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(26, 20);
            this.textBoxB.TabIndex = 16;
            // 
            // textBoxEpsilon
            // 
            this.textBoxEpsilon.Location = new System.Drawing.Point(186, 140);
            this.textBoxEpsilon.Name = "textBoxEpsilon";
            this.textBoxEpsilon.Size = new System.Drawing.Size(100, 20);
            this.textBoxEpsilon.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.найтиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculToolStripMenuItem
            // 
            this.calculToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методПрямоугольниковToolStripMenuItem,
            this.методТрапецийToolStripMenuItem,
            this.методСимпсонаToolStripMenuItem});
            this.calculToolStripMenuItem.Name = "calculToolStripMenuItem";
            this.calculToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.calculToolStripMenuItem.Text = "Рассчитать";
            this.calculToolStripMenuItem.Click += new System.EventHandler(this.calculToolStripMenuItem_Click);
            // 
            // методПрямоугольниковToolStripMenuItem
            // 
            this.методПрямоугольниковToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.методЛевыхПрямоугольниковToolStripMenuItem,
            this.методПравыхПрямоугольниковToolStripMenuItem,
            this.методСреднихПрямоугольниковToolStripMenuItem});
            this.методПрямоугольниковToolStripMenuItem.Name = "методПрямоугольниковToolStripMenuItem";
            this.методПрямоугольниковToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.методПрямоугольниковToolStripMenuItem.Text = "Метод прямоугольников";
            // 
            // методЛевыхПрямоугольниковToolStripMenuItem
            // 
            this.методЛевыхПрямоугольниковToolStripMenuItem.Name = "методЛевыхПрямоугольниковToolStripMenuItem";
            this.методЛевыхПрямоугольниковToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.методЛевыхПрямоугольниковToolStripMenuItem.Text = "Метод левых прямоугольников";
            this.методЛевыхПрямоугольниковToolStripMenuItem.Click += new System.EventHandler(this.методЛевыхПрямоугольниковToolStripMenuItem_Click);
            // 
            // методПравыхПрямоугольниковToolStripMenuItem
            // 
            this.методПравыхПрямоугольниковToolStripMenuItem.Name = "методПравыхПрямоугольниковToolStripMenuItem";
            this.методПравыхПрямоугольниковToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.методПравыхПрямоугольниковToolStripMenuItem.Text = "Метод правых прямоугольников";
            this.методПравыхПрямоугольниковToolStripMenuItem.Click += new System.EventHandler(this.методПравыхПрямоугольниковToolStripMenuItem_Click);
            // 
            // методСреднихПрямоугольниковToolStripMenuItem
            // 
            this.методСреднихПрямоугольниковToolStripMenuItem.Name = "методСреднихПрямоугольниковToolStripMenuItem";
            this.методСреднихПрямоугольниковToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            this.методСреднихПрямоугольниковToolStripMenuItem.Text = "Метод средних прямоугольников";
            this.методСреднихПрямоугольниковToolStripMenuItem.Click += new System.EventHandler(this.методСреднихПрямоугольниковToolStripMenuItem_Click);
            // 
            // методТрапецийToolStripMenuItem
            // 
            this.методТрапецийToolStripMenuItem.Name = "методТрапецийToolStripMenuItem";
            this.методТрапецийToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.методТрапецийToolStripMenuItem.Text = "Метод трапеций";
            this.методТрапецийToolStripMenuItem.Click += new System.EventHandler(this.методТрапецийToolStripMenuItem_Click);
            // 
            // методСимпсонаToolStripMenuItem
            // 
            this.методСимпсонаToolStripMenuItem.Name = "методСимпсонаToolStripMenuItem";
            this.методСимпсонаToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.методСимпсонаToolStripMenuItem.Text = "Метод Симпсона";
            this.методСимпсонаToolStripMenuItem.Click += new System.EventHandler(this.методСимпсонаToolStripMenuItem_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(39, 137);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(100, 20);
            this.textBoxN.TabIndex = 19;
            this.textBoxN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxN_KeyPress);
            // 
            // textBoxIntegral
            // 
            this.textBoxIntegral.Location = new System.Drawing.Point(228, 232);
            this.textBoxIntegral.Name = "textBoxIntegral";
            this.textBoxIntegral.Size = new System.Drawing.Size(100, 20);
            this.textBoxIntegral.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "e";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "n";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(56, 336);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(248, 89);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Показывать разбиение";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Вычисление_определенного_интеграла.Properties.Resources.Voiceless;
            this.pictureBox1.Location = new System.Drawing.Point(28, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "dx =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Количество разбиений";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Точность";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Введите значения";
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(268, 20);
            this.найтиToolStripMenuItem.Text = "Найти разбиение с одинаковым результатом";
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.найтиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIntegral);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxEpsilon);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.TextBoxFunction);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox TextBoxFunction;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxEpsilon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calculToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методПрямоугольниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методЛевыхПрямоугольниковToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxIntegral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem методПравыхПрямоугольниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методСреднихПрямоугольниковToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методТрапецийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem методСимпсонаToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
    }
}

