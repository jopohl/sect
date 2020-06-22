using System.Drawing;
using System.Drawing.Drawing2D;

namespace EllipticCurves
{
    public enum AxisType
    {
        x,
        y
    }
    public class Axis
    {
        private Point start;
        private Point end;

        private AxisType type;
        /// <summary>
        /// Distance of ticks on axis in pixels
        /// </summary>
        private readonly int dTicks;

        private readonly int minValue;
        /// <summary>
        /// Steps between two ticks in CoordinateSystem-units.
        /// For example, for step_ticks=3 the ticks would have captions 0, 3, 6, 9, ...
        /// </summary>
        private readonly int stepsTicks;

        private static readonly Font tickFont = new Font(FontFamily.GenericSansSerif, 10);

        private const int TICK_LENGTH = 5;

        private const int MIN_DISTANCE_TICK_CAPTION = 3;

        /// <summary>
        /// Distance between labeled ticks
        /// For Distance=1 every tick gets labeled for 2 only every second and so on
        /// </summary>
        public int DistanceBetweenLabeledTicks { get; set; }

        public static Font TickFont
        {
            get { return tickFont; }
        }

        /// <summary>
        /// Starting point of axis in pixel coordinated
        /// </summary>
        public Point Start
        {
            get { return start; }
        }

        /// <summary>
        /// Distance between ticks in pixels
        /// </summary>
        public int DTicks
        {
            get { return dTicks; }
        }
        /// <summary>
        /// Steps between two ticks in CoordinateSystem-units.
        /// For example, for step_ticks=3 the ticks would have captions 0, 3, 6, 9, ...
        /// </summary>
        public double StepsTicks
        {
            get { return stepsTicks; }
        }

        public Axis(Point start, Point end, AxisType type, int dTicks, int stepsTicks, int minValue)
        {
            this.start = start;
            this.end = end;
            this.type = type;
            this.dTicks = dTicks;
            this.minValue = minValue;
            this.stepsTicks = stepsTicks;
        }

        public void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color.Black))
            {
                // Draw arrow
                AdjustableArrowCap ac = new AdjustableArrowCap(3, 3);
                pen.EndCap = LineCap.ArrowAnchor;
                pen.CustomEndCap = ac;
                g.DrawLine(pen, start, end);
            }

            using (Pen pen = new Pen(Color.Black))
            {
                // Draw ticks
                double caption = minValue;
                int tickCounter = 0;
                SizeF captionSize;

                if (this.type == AxisType.x)
                {
                    for (int i = start.X; i < end.X; i += dTicks)
                    {
                        g.DrawLine(pen, i, start.Y, i, start.Y - TICK_LENGTH);

                        if (tickCounter % DistanceBetweenLabeledTicks == 0 && caption!=0)
                        {
                            string caption_str = caption.ToString();
                            g.DrawLine(pen, i, start.Y, i, start.Y - 2*TICK_LENGTH);
                            captionSize = g.MeasureString(caption_str, tickFont);
                            g.DrawString(caption_str, tickFont, new SolidBrush(Color.Black),
                                         i-captionSize.Width/2, start.Y + 2);
                        }

                        caption += stepsTicks;
                        tickCounter++;
                    }
                    captionSize = g.MeasureString("x", tickFont);
                    g.DrawString("x", tickFont, Brushes.Black, end.X - captionSize.Width / 2, end.Y + 2);
                }
                else if (this.type == AxisType.y)
                {
                    for (int i = start.Y; i > end.Y; i-=dTicks)
                    {
                        g.DrawLine(pen, start.X, i, start.X + TICK_LENGTH, i);

                        if (tickCounter % DistanceBetweenLabeledTicks == 0 && caption != 0)
                        {
                            string beschriftung = caption.ToString();
                            g.DrawLine(pen, start.X, i, start.X + 2*TICK_LENGTH, i);
                            captionSize = g.MeasureString(beschriftung, tickFont);
                            g.DrawString(beschriftung, tickFont, new SolidBrush(Color.Black),
                                         start.X - 1.3F*captionSize.Width, i - captionSize.Height/2);
                        }

                        caption += stepsTicks;
                        tickCounter++;
                    }
                    captionSize = g.MeasureString("y", tickFont);
                    g.DrawString("y", tickFont, Brushes.Black, start.X - 1.5F*captionSize.Width, end.Y - captionSize.Height/2);
                }
            }
        }

        /// <summary>
        /// Calculate optimal distance between tick labels for readability
        /// </summary>
        /// <param name="maxValue">Maximal axis value in CoordinateSystem-Coordinates</param>
        /// <param name="stepsTicks">Steps between two ticks e.g. 3 would lead to ticks 0, 3, 6, ...</param>
        /// <param name="d">Distance between ticks in pixels</param>
        /// <param name="graphics">Graphics object this axis shall be drawn upon</param>
        /// <returns>Optimal tick label distance. 1 means every tick is labeled, 2 every second tick is labeled and so on</returns>
        public static int CalcLabeledTicksDistance(int maxValue, int stepsTicks, int d, Graphics graphics)
        {
            int result = maxValue / stepsTicks;

            for (int i = 1; i < maxValue / stepsTicks; i++)
            {
                // i steps left from maximum
                int maxValueLeft = maxValue - i * stepsTicks;

                float widthmaxValue = graphics.MeasureString(maxValue.ToString(), Axis.TickFont).Width;
                float widthmaxValueLeft = graphics.MeasureString(maxValueLeft.ToString(), Axis.TickFont).Width;

                if (i * d - (widthmaxValue / 2 + widthmaxValueLeft / 2) >= MIN_DISTANCE_TICK_CAPTION)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }
    }
}
