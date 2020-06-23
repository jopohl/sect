using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using EllipticCurveTool.EC;

namespace EllipticCurveTool
{
    /// <summary>
    /// CoordinateSystem for elliptic curves
    /// The origin is always the ECPoint (0/0).
    /// Step sizes can only be integers.
    /// </summary>
    public class CoordinateSystem
    {
        private Axis xAxis;
        private Axis yAxis;

        /// <summary>
        /// Graphics-Object, this coordinate system should be drawn upon
        /// </summary>
        private Graphics graphics;

        private readonly int xmin;
        private readonly int xmax;
        private readonly int ymin;
        private readonly int ymax;

        /// <summary>
        /// Width in pixels
        /// </summary>
        private int width;

        public int Width
        {
            get { return width + border[0] + border[1]; }
            
        }

        /// <summary>
        /// Height in pixels
        /// /// </summary>
        private int height;

        public int Height
        {
            get { return height + border[2] + border[3]; }

        }

        ///<summary>
        /// Border around coordinate system in pixels
        /// Order: 0. Border left, 1. Border right, 2. Border top, 3. Border bottom
        /// </summary>
        private readonly int[] border = { 60, 30, 30, 30 };

        private readonly Color CURVE_COLOR = Color.Black;
        private readonly Color POINT_COLOR = Color.Blue;
        private readonly Color SELECTION_COLOR = Color.Orange;

        /// <summary>
        /// Thickness (Radius) of a point in pixels
        /// </summary>
        private const int POINT_THICKNESS = 6;

        /// <summary>
        /// Minimum distance between ticks in pixels
        /// </summary>
        private const int MIN_TICK_DISTANCE = 10;

        /// <summary>
        /// A picture, the coordinate system and the curve in it shall be drawn upon.
        /// </summary>
        public Bitmap Picture { get; private set; }

        public CoordinateSystem(int xmin, int xmax, int ymin, int ymax, Bitmap picture)
        {
            this.xmin = xmin;
            this.xmax = xmax;
            this.ymin = ymin;
            if (ymax == ymin)
                ymax+=2; // ensure, y-Axis does not disappear
            this.ymax = ymax;
            this.Picture = picture;
            graphics = Graphics.FromImage(Picture);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            // White Background
            graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, Picture.Width, Picture.Height);
        }

        public CoordinateSystem(int xmax, int ymax, Bitmap bild) : this(0, xmax, 0, ymax, bild) { }

        public void Draw(bool equalAspectRatio)
        {
            int dx = 0; // Tick distance on x axis in pixels
            int sx = 0; // Step size on x axis
            width = Picture.Width - (border[0] + border[1]);
            height = Picture.Height - (border[2] + border[3]);

            double xRange = xmax - xmin;
            for (int i = 1; i < xRange; i++)
            {
                dx = (int)(i / xRange * width);
                if (dx >= MIN_TICK_DISTANCE)
                {
                    sx = i;
                    break;
                }
            }

            if (dx == 0 || sx == 0)
                throw new Exception("An error occurred during calculating the ticks for the x-axis. Is the picture too small?");

            int dy = 0; // Tick distance on y axis in pixels
            int sy = 0; // Step size on y axis
            double yRange = ymax - ymin;
            for (int i = 1; i < yRange; i++)
            {
                dy = (int)(i / yRange * height);
                if (dy >= MIN_TICK_DISTANCE)
                {
                    sy = i;
                    break;
                }
            }

            if (dy == 0 || sy == 0)
                throw new Exception("An error occurred during calculating the ticks for the y-axis. Is the picture too small?");

            if (equalAspectRatio)
            {
                // Take the smaller tick distance for both axes
                float csPerPixelX = sx / (float)dx;
                float csPerPixelY = sy / (float)dy;
                if (csPerPixelX < csPerPixelY)
                {
                    dx = dy;
                    sx = sy;
                    width = (int)(dx * xRange / sx);
                }

                if (csPerPixelX > csPerPixelY)
                {
                    dy = dx;
                    sy = sx;
                    height = (int)(dy * yRange / sy);
                }
            }

            int posxAxis = (int)(Picture.Height - border[3] - (0 - ymin) / (double)sy * dy);
            int posyAxis = (int)(border[0] + (Math.Abs(0 - xmin) / (double)sx) * dx);

            xAxis = new Axis(
                new Point(border[0], posxAxis),
                new Point(width + border[0] + (int)(0.8 * border[1]), posxAxis),
                AxisType.x, dx, sx, xmin
                );

            yAxis = new Axis(
                new Point(posyAxis, Picture.Height - border[3]),
                new Point(posyAxis, Picture.Height - (height + (int)(0.8 * border[2]) + border[3])), 
                AxisType.y, dy, sy, ymin
                );

            // Distance between labeled ticks
            // 1 means every tick is labeled, 2 every second tick is labeled and so on
            xAxis.DistanceBetweenLabeledTicks = Axis.CalcLabeledTicksDistance(xmax, sx, dx, graphics);
            yAxis.DistanceBetweenLabeledTicks = Axis.CalcLabeledTicksDistance(ymax, sy, dy, graphics);

            xAxis.Draw(graphics);
            yAxis.Draw(graphics);
        }

        /// <summary>
        /// Transform pixel coordinates to CoordinateSystem-Coordinates
        /// </summary>
        /// <param name="x">The x-component of the pixel coordinate</param>
        /// <param name="y">The y-component of the pixel coordinate</param>
        /// <returns>The CoordinateSystem-Coordinates matching the pixel coordinates as a 2-tuple</returns>
        public Tuple<double, double> GetCoordinates(int x, int y)
        {
            double deltaX = (x - border[0]) / (double)xAxis.DTicks * xAxis.StepsTicks;
            double xCoord = xmin + deltaX;

            int diff = Picture.Height - (height + border[2] + border[3]);
            int heightPicture = height + diff + border[2] + border[3]; // Total height of picture

            double deltaY = ((heightPicture - y) - border[3]) / (double)yAxis.DTicks * yAxis.StepsTicks;
            double yCoord = ymin + deltaY;

            return new Tuple<double, double>(xCoord, yCoord);
        }

        /// <summary>
        /// Get the pixel coordinates from CoordinateSystem-Coordinates
        /// </summary>
        /// <param name="x">x-component of the CoordinateSystem-Coordinate</param>
        /// <param name="y">y-component of the CoordinateSystem-Coordinate</param>
        /// <returns>The pixel coordinates for the given CoordinateSystem-Coordinate as a 2-tuple</returns>
        public Tuple<double, double> GetPixelCoordinates(double x, double y)
        {
            double xPixel = border[0] + (x - xmin) / xAxis.StepsTicks * xAxis.DTicks;
            double deltaY = border[3] + (y - ymin) / yAxis.StepsTicks * yAxis.DTicks;

            int diff = Picture.Height - (height + border[2] + border[3]);
            int heightPicture = height + diff + border[2] + border[3]; // Total height of picture
            double yPixel = heightPicture - deltaY;

            return new Tuple<double, double>(xPixel, yPixel);
        }

        public void DrawECPoint(ECPoint ecPoint)
        {
            DrawPoint(ecPoint, POINT_COLOR);
        }

        public void DrawLine(Color color, ECPoint point1, ECPoint point2, DashStyle dashStyle=DashStyle.Solid)
        {
            Tuple<double, double> point1PixelCoord = GetPixelCoordinates(point1.X, point1.Y);
            Tuple<double, double> point2PixelCoord = GetPixelCoordinates(point2.X, point2.Y);
            float x1 = (float)point1PixelCoord.Item1;
            float x2 = (float)point2PixelCoord.Item1;
            float y1 = (float)point1PixelCoord.Item2;
            float y2 = (float)point2PixelCoord.Item2;

            using (Pen pen = new Pen(color))
            {
                pen.DashStyle = dashStyle;
                graphics.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        public void DrawDashedLine(Color color, ECPoint point1, ECPoint point2)
        {
            DrawLine(color, point1, point2, DashStyle.Dash);
        }

        public void DrawCurve(Point[] curvePoints)
        {
                if (curvePoints.Length > 1)
                    using (Pen pen = new Pen(CURVE_COLOR))
                        graphics.DrawCurve(pen, curvePoints);
                else if (curvePoints.Length == 1)
                        graphics.FillEllipse(Brushes.Black, curvePoints[0].X-3, curvePoints[0].Y-3, 6, 6); // Isolated ECPoint
        }

        public void SetSelection(ECPoint point)
        {
            DrawPoint(point, SELECTION_COLOR);
        }

        public void ClearSelection(ECPoint point)
        {
            DrawPoint(point, POINT_COLOR);
        }

        public void SetSummand1(ECPoint point)
        {
            FillAndLabelPoint(point, Color.Red, "P");
        }

        public void SetSummand2(ECPoint point)
        {
            FillAndLabelPoint(point, Color.Red, "Q");
        }

        public void SetFactor(ECPoint point)
        {
            FillAndLabelPoint(point, Color.Red, "S");
        }

        public void SetDoubling(ECPoint point)
        {
            FillAndLabelPoint(point, Color.Red, "P=Q");
        }

        public void SetAdditionResult(ECPoint point)
        {
            FillAndLabelPoint(point, Color.Green, "R");
        }

        public void SetMultiplicationResult(int n, ECPoint point)
        {
            FillAndLabelPoint(point, Color.Green, n + "S");
        }

        public void SetMinusResult(ECPoint point)
        {
            FillAndLabelPoint(point, Color.RoyalBlue, "-R");
        }

        private void FillAndLabelPoint(ECPoint point, Color color, string label)
        {
            if (point == null || point.IsInfinity)
                return;

            Tuple<double, double> pixelCoord = this.GetPixelCoordinates(point.X, point.Y);

            using (Brush brush = new SolidBrush(color))
            {
                float x = (float)pixelCoord.Item1 - POINT_THICKNESS / 2;
                float y = (float)pixelCoord.Item2 - POINT_THICKNESS / 2;
                graphics.FillEllipse(brush, x, y, POINT_THICKNESS, POINT_THICKNESS);

                Font font = new Font(FontFamily.GenericSansSerif, 12);
                SizeF captionSize = graphics.MeasureString(label, font);

                float direction = 1; // Place label above
                if (point.Y < 0)
                    direction = -0.5F; // Place label below

                graphics.DrawString(label, font, new SolidBrush(Color.Black), x - captionSize.Width / 2, y - direction * captionSize.Height);
            }
        }

        private void DrawPoint(ECPoint point, Color color)
        {
            if (point == null || point.IsInfinity)
                return;

            Tuple<double, double> pixelCoord = this.GetPixelCoordinates(point.X, point.Y);

            using (Pen pen = new Pen(color))
            {
                float x = (float)pixelCoord.Item1 - POINT_THICKNESS / 2;
                float y = (float)pixelCoord.Item2 - POINT_THICKNESS / 2;
                graphics.DrawEllipse(pen, x, y, POINT_THICKNESS, POINT_THICKNESS);
            }
        }

        /// <summary>
        /// Find currently selected elliptic curve point (selected by mouse hovering)
        /// </summary>
        /// <param name="pX">x-coordinate of current mouse position in pixels</param>
        /// <param name="pY">y-coordinate of current mouse position in pixels</param>
        /// <param name="ecPoints">Points of the elliptic curve that shall be checked whether selected</param>
        /// <returns>The selected ECPoint or <c>null</c>, if no ECPoint is selected by mouse.</returns>
        public ECPoint FindSelectedPoint(int pX, int pY, List<ECPoint> ecPoints)
        {
            Tuple<double, double> csCoordinates = GetCoordinates(pX, pY);

            // Find closest ECPoint to csCoordinates
            double minDist = double.MaxValue;
            ECPoint result = new ECPoint(0, 0);
            foreach (ECPoint ecPoint in ecPoints)
            {
                double xdiff = (ecPoint.X - csCoordinates.Item1);
                double ydiff = (ecPoint.Y - csCoordinates.Item2);
                double dist = xdiff * xdiff + ydiff * ydiff; // This is actually the squared distance but it suffices for comparison
                if (dist < minDist)
                {
                    result = ecPoint;
                    minDist = dist;
                }
            }

            // Set pixel range of the closest ECPoint
            Tuple<double, double> pixelCoordResult = GetPixelCoordinates(result.X, result.Y);
            double xMin = pixelCoordResult.Item1 - POINT_THICKNESS / 2;
            double xMax = pixelCoordResult.Item1 + POINT_THICKNESS / 2;
            double yMin = pixelCoordResult.Item2 - POINT_THICKNESS / 2;
            double yMax = pixelCoordResult.Item2 + POINT_THICKNESS / 2;

            if (pX > xMin && pX < xMax && pY > yMin && pY < yMax)
                return result;

            return null;
        }
    }
}
