using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Lab17
{
    internal class DrawEngine
    {
        private float valueA { get; set; }
        private float valueB { get; set; }

        private Graphics graphics;

        public DrawEngine() : this(0.0f, 0.0f)
        { }

        public DrawEngine(float valueA, float valueB)
        {
            this.valueA = valueA;
            this.valueB = valueB;
        }

        public void Draw(Graphics graphics, Pen pen)
        {
            //Graphics graphics = this.graphics;
            int retreat = 50;

            float valueC = (float)Math.Sqrt(valueA * valueA - valueB * valueB / 4);

            if(2 * valueA > valueB && valueB != 0 )
            {
                graphics.DrawLine(pen, valueB * 0.5f + retreat, retreat, valueB + retreat, valueC + retreat);
                graphics.DrawLine(pen, valueB + retreat, valueC + retreat, valueB * 0.5f + retreat, valueC * 2 + retreat);
                graphics.DrawLine(pen, valueB * 0.5f + retreat, valueC * 2 + retreat, retreat, valueC + retreat);
                graphics.DrawLine(pen, retreat, valueC + retreat, valueB * 0.5f + retreat, retreat);

            }


        }
    }
}
