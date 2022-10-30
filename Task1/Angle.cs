using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Angle
    {
        int gradus;
        int min;
        int sec;
        public bool isCorrect = true;

        int Gradus
        {
            get { return gradus; }
            set
            {
                gradus = value;//Угол может быть и отрицательным
            }
        }

        int Min
        {
            get { return min; }
            set
            {
                if (value < 0)
                {
                    isCorrect = false;
                }
                else
                {
                    Gradus += value / 60;
                    min = value % 60;
                }
            }
        }

        int Sec
        {
            get { return sec; }
            set
            {
                if (value < 0)
                {
                    isCorrect = false;
                }
                else
                {
                    Min += value / 60;
                    sec = value % 60;
                }
            }
        }

        public Angle(int gradus, int min, int sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }

        public double ToRadians()
        {
            return ((double)gradus + (double)min / 60.0 + (double)sec / 3600.0) * Math.PI / 180;
        }

    }
}
