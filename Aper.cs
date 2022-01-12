using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD
{
    class Aper : @base
    {
        private double[] result = null;

        /* переменные для пользования внутри класса */
        public double koeff_Kp { get; private set; }
        public double koeff_Tu { get; private set; }
        public int point_proc_c { get; private set; }
        public int start_time_c { get; private set; }
        public int end_time_c { get; private set; }
        /* конец обозначения переменных */

        /* добавление данных для пользования внутри класса в переменные */
        public Aper(double Kp, double Tu, int point_proc, int start_time, int end_time)
        {
            koeff_Kp = Kp; //коэффициент передачи
            koeff_Tu = Tu; //коэффициент обратной связи
            point_proc_c = point_proc;
            start_time_c = start_time;
            end_time_c = end_time;
        }
        /* конец добавления */

        /* вычисления */
        public double[] calc(double[] a_c, double[] b_c)
        {
            Array.Resize(ref result, point_proc_c);
            for (int i = 0; i < point_proc_c; i++)
            {
                double srznach = ((start_time_c - 1) + end_time_c) / point_proc_c; // среднее для нормальной работы интеграла

                
                result[i] = koeff_Kp * (1 - Math.Exp(-(start_time_c + srznach * i) / koeff_Tu)); // переходная апериодического звена
            };

            return result; //вывод значения из класса
        }
    }
}
