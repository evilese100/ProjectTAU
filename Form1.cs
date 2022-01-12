using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[0].Points.AddXY(0, 0);
            chart2.Series[0].Points.AddXY(0, 0);
            chart3.Series[0].Points.AddXY(0, 0);

        }

        public double[] a;
        public double[] b;
        public double srznach;
        public double[] vihod1;
        public double[] vihod2;

        private void btn_calc_Click(object sender, EventArgs e)
        {
            //Первое звено
            //Combobox: Пропорциональное Интегральное Изодромное - type_zv1
            if (type_zv1.Text == "")
            {
                MessageBox.Show("Задайте тип звена");
            }

            if (type_zv1.Text == "Пропорциональное")
            {
                vihod1 = null;
                loop_sys l = new loop_sys(Convert.ToDouble(kp.Text), Convert.ToDouble(Tu.Text), Convert.ToInt32(point_num.Text), Convert.ToInt32(start_time.Text), Convert.ToInt32(end_time.Text));
                vihod1 = l.calc(a, b);
                lb_exit.Text = "Выходные значения";
                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++) { 
                    lb_exit.Text += "\n" + Math.Round(Convert.ToDouble(vihod1[i]), 3) ;
                }
                //отрисовка графика
                chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    srznach = ((Convert.ToInt32(start_time.Text) - 1) + Convert.ToInt32(end_time.Text)) / Convert.ToInt32(point_num.Text);
                    double x = (Convert.ToDouble(start_time.Text) + srznach * i);
                    double y = Convert.ToDouble(vihod1[i]);
                    chart1.Series[0].Points.AddXY(x, y);
                }
            }
            if (type_zv1.Text == "Идеальное")
            {
                vihod1 = null;
                outrage l = new outrage(Convert.ToDouble(kp.Text), Convert.ToDouble(Tu.Text), Convert.ToInt32(point_num.Text), Convert.ToInt32(start_time.Text), Convert.ToInt32(end_time.Text));
                vihod1 = l.calc(a, b);
                lb_exit.Text = "Выходные значения";
                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    lb_exit.Text += "\n" + Math.Round(Convert.ToDouble(vihod1[i]), 3);
                }
                //отрисовка графика
                chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    srznach = ((Convert.ToInt32(start_time.Text) - 1) + Convert.ToInt32(end_time.Text)) / Convert.ToInt32(point_num.Text);
                    double x = (Convert.ToDouble(start_time.Text) + srznach * i);
                    double y = Convert.ToDouble(vihod1[i]);
                    chart1.Series[0].Points.AddXY(x, y);
                }

            }
            if (type_zv1.Text == "Изодромное")
            {
                vihod1 = null;
                err_sys l = new err_sys(Convert.ToDouble(kp.Text), Convert.ToDouble(Tu.Text), Convert.ToInt32(point_num.Text), Convert.ToInt32(start_time.Text), Convert.ToInt32(end_time.Text));
                vihod1 = l.calc(a, b);
                lb_exit.Text = "Выходные значения";
                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    lb_exit.Text += "\n" + Math.Round(Convert.ToDouble(vihod1[i]), 3);
                }
                //отрисовка графика
                chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    srznach = ((Convert.ToInt32(start_time.Text) - 1) + Convert.ToInt32(end_time.Text)) / Convert.ToInt32(point_num.Text);
                    double x = (Convert.ToDouble(start_time.Text) + srznach * i);
                    double y = Convert.ToDouble(vihod1[i]);
                    chart1.Series[0].Points.AddXY(x, y);
                }
            }
            if (type_zv1.Text == "С замедлением")
            {
                vihod1 = null;
                Outrage_Z l = new Outrage_Z(Convert.ToDouble(kp.Text), Convert.ToDouble(Tu.Text), Convert.ToInt32(point_num.Text), Convert.ToInt32(start_time.Text), Convert.ToInt32(end_time.Text));
                vihod1 = l.calc(a, b);
                lb_exit.Text = "Выходные значения";
                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    lb_exit.Text += "\n" + Math.Round(Convert.ToDouble(vihod1[i]), 3);
                }
                //отрисовка графика
                chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    srznach = ((Convert.ToInt32(start_time.Text) - 1) + Convert.ToInt32(end_time.Text)) / Convert.ToInt32(point_num.Text);
                    double x = (Convert.ToDouble(start_time.Text) + srznach * i);
                    double y = Convert.ToDouble(vihod1[i]);
                    chart1.Series[0].Points.AddXY(x, y);
                }
            }

            if (type_zv1.Text == "Апериодическое")
            {
                vihod1 = null;
                Aper l = new Aper(Convert.ToDouble(kp.Text), Convert.ToDouble(Tu.Text), Convert.ToInt32(point_num.Text), Convert.ToInt32(start_time.Text), Convert.ToInt32(end_time.Text));
                vihod1 = l.calc(a, b);
                lb_exit.Text = "Выходные значения";
                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    lb_exit.Text += "\n" + Math.Round(Convert.ToDouble(vihod1[i]), 3);
                }
                //отрисовка графика
                chart1.Series[0].Points.Clear();
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    srznach = ((Convert.ToInt32(start_time.Text) - 1) + Convert.ToInt32(end_time.Text)) / Convert.ToInt32(point_num.Text);
                    double x = (Convert.ToDouble(start_time.Text) + srznach * i);
                    double y = Convert.ToDouble(vihod1[i]);
                    chart1.Series[0].Points.AddXY(x, y);
                }
            }
        }

        private void btn_calc2_Click(object sender, EventArgs e)
        {
            //Второе звено
            //Combobox type_zv2
            if (type_zv2.Text == "")
            {
                MessageBox.Show("Задайте тип звена");
            }

            if (type_zv2.Text == "Пропорциональное")
            {
                vihod2 = null;
                loop_sys l = new loop_sys(Convert.ToDouble(kp2.Text), Convert.ToDouble(Tu2.Text), Convert.ToInt32(point_num.Text), Convert.ToInt32(start_time.Text), Convert.ToInt32(end_time.Text));
                vihod2 = l.calc(a, b);
                lb_exit2.Text = "Выходные значения";
                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    lb_exit2.Text += "\n" + Math.Round(Convert.ToDouble(vihod2[i]), 3);
                }
                //отрисовка графика
                chart2.Series[0].Points.Clear();
                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    srznach = ((Convert.ToInt32(start_time.Text) - 1) + Convert.ToInt32(end_time.Text)) / Convert.ToInt32(point_num.Text);
                    double x = (Convert.ToDouble(start_time.Text) + srznach * i);
                    double y = Convert.ToDouble(vihod2[i]);
                    chart2.Series[0].Points.AddXY(x, y);
                }
            }
            if (type_zv2.Text == "Идеальное")
            {
                vihod2 = null;
                outrage l = new outrage(Convert.ToDouble(kp2.Text), Convert.ToDouble(Tu2.Text), Convert.ToInt32(point_num.Text), Convert.ToInt32(start_time.Text), Convert.ToInt32(end_time.Text));
                vihod2 = l.calc(a, b);
                lb_exit2.Text = "Выходные значения";
                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    lb_exit2.Text += "\n" + Math.Round(Convert.ToDouble(vihod2[i]), 3);
                }
                //отрисовка графика
                chart2.Series[0].Points.Clear();
                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    srznach = ((Convert.ToInt32(start_time.Text) - 1) + Convert.ToInt32(end_time.Text)) / Convert.ToInt32(point_num.Text);
                    double x = (Convert.ToDouble(start_time.Text) + srznach * i);
                    double y = Convert.ToDouble(vihod2[i]);
                    chart2.Series[0].Points.AddXY(x, y);
                }
            }
            if (type_zv2.Text == "С замедлением")
            {
                vihod2 = null;
                Outrage_Z l = new Outrage_Z(Convert.ToDouble(kp2.Text), Convert.ToDouble(Tu2.Text), Convert.ToInt32(point_num.Text), Convert.ToInt32(start_time.Text), Convert.ToInt32(end_time.Text));
                vihod2 = l.calc(a, b);
                lb_exit2.Text = "Выходные значения";
                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    lb_exit2.Text += "\n" + Math.Round(Convert.ToDouble(vihod2[i]), 3);
                }
                //отрисовка графика
                chart2.Series[0].Points.Clear();
                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    srznach = ((Convert.ToInt32(start_time.Text) - 1) + Convert.ToInt32(end_time.Text)) / Convert.ToInt32(point_num.Text);
                    double x = (Convert.ToDouble(start_time.Text) + srznach * i);
                    double y = Convert.ToDouble(vihod2[i]);
                    chart2.Series[0].Points.AddXY(x, y);
                }
            }
            if (type_zv2.Text == "Изодромное")
            {
                vihod2 = null;
                err_sys l = new err_sys(Convert.ToDouble(kp2.Text), Convert.ToDouble(Tu2.Text), Convert.ToInt32(point_num.Text), Convert.ToInt32(start_time.Text), Convert.ToInt32(end_time.Text));
                vihod2 = l.calc(a, b);
                lb_exit2.Text = "Выходные значения";
                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    lb_exit2.Text += "\n" + Math.Round(Convert.ToDouble(vihod2[i]), 3);
                }
                //отрисовка графика
                chart2.Series[0].Points.Clear();
                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    srznach = ((Convert.ToInt32(start_time.Text) - 1) + Convert.ToInt32(end_time.Text)) / Convert.ToInt32(point_num.Text);
                    double x = (Convert.ToDouble(start_time.Text) + srznach * i);
                    double y = Convert.ToDouble(vihod2[i]);
                    chart2.Series[0].Points.AddXY(x, y);
                }
            }
            if (type_zv2.Text == "Апериодическое")
            {
                vihod2 = null;
                Aper l = new Aper(Convert.ToDouble(kp2.Text), Convert.ToDouble(Tu2.Text), Convert.ToInt32(point_num.Text), Convert.ToInt32(start_time.Text), Convert.ToInt32(end_time.Text));
                vihod2 = l.calc(a, b);
                lb_exit2.Text = "Выходные значения";
                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    lb_exit2.Text += "\n" + Math.Round(Convert.ToDouble(vihod2[i]), 3);
                }
                //отрисовка графика
                chart2.Series[0].Points.Clear();
                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
                {
                    srznach = ((Convert.ToInt32(start_time.Text) - 1) + Convert.ToInt32(end_time.Text)) / Convert.ToInt32(point_num.Text);
                    double x = (Convert.ToDouble(start_time.Text) + srznach * i);
                    double y = Convert.ToDouble(vihod2[i]);
                    chart2.Series[0].Points.AddXY(x, y);
                }
            }
        }

        private void btn_calc3_Click(object sender, EventArgs e)
        {
            double[] result = new double[Convert.ToInt32(point_num.Text)];
            label6.Text = "Выходные значения";
            //Общая переходная
            chart3.Series[0].Points.Clear();
            chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

            for (int i = 0; i < Convert.ToInt32(point_num.Text); i++)
            {
                result[i] = (vihod1[i] * vihod2[i])/(1+(vihod1[i] * vihod2[i]));
                label6.Text += "\n" + result[i];
                double x = (Convert.ToDouble(start_time.Text) + srznach * i);
                double y = Convert.ToDouble(result[i]);
                chart3.Series[0].Points.AddXY(x, y);
            }
        }
    }
}
