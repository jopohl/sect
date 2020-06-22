using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using EllipticCurves.EC;

namespace EllipticCurves
{
    /// <summary>
    /// Ein CoordinateSystem zur Darstellung von elliptischen Kurven auf Z_n.
    /// Der Ursprung des Koordinatensystems ist immer der ECPoint (0/0).
    /// Die Schrittweiten können nur ganze Zahlen sein.
    /// </summary>
    public class CoordinateSystem
    {
        private Axis xAchse;
        private Axis yAchse;

        /// <summary>
        /// Das Graphics-Objekt, auf dem das KS gezeichnet wird
        /// </summary>
        private Graphics graphics;
        private readonly int xmin;
        private readonly int xmax;
        private readonly int ymin;
        private readonly int ymax;

        /// <summary>
        /// Breite des KS in Pixeln
        /// </summary>
        private int breite;

        public int Breite
        {
            get { return breite + rand[0] + rand[1]; }
            
        }

        /// <summary>
        /// Höhe des KS in Pixeln
        /// </summary>
        private int hoehe;

        public int Hoehe
        {
            get { return hoehe + rand[2] + rand[3]; }

        }

        ///<summary>
        /// Der Rand um das Koordinatenystem in Pixeln.
        /// Reihenfolge: 0. Rand links, 1. Rand rechts, 2. Rand oben, 3. Rand unten
        /// </summary>
        private readonly int[] rand = { 60, 30, 30, 30 };

        /// <summary>
        /// Die Farbe, in der die Points gezeichnet werden sollen
        /// </summary>
        private readonly Color PUNKT_FARBE = Color.Blue;
        /// <summary>
        /// Die Farbe, die ein ECPoint annimmt, wenn er selektiert ist
        /// </summary>
        private readonly Color SELEKTION_FARBE = Color.Orange;

        /// <summary>
        /// Gibt den Mindestabstand der Ticks auf x- und y-Achse in Pixeln an
        /// </summary>
        private const int MINDESTABSTAND_TICKS = 10;

        public readonly Color KURVEN_FARBE = Color.Black;
        /// <summary>
        /// Dicke (Radius) der gezeichneten Points in Pixeln
        /// </summary>
        private const int PUNKT_DICKE = 6;

        /// <summary>
        /// Das Bild, auf dem das CoordinateSystem und die darin enthaltene Kurve gezeichnet werden soll.
        /// </summary>
        public Bitmap Bild { get; private set; }

        public CoordinateSystem(int xmin, int xmax, int ymin, int ymax, Bitmap bild)
        {
            this.xmin = xmin;
            this.xmax = xmax;
            this.ymin = ymin;
            if (ymax == ymin)
                ymax+=2; // stelle sicher, dass y-Achse nicht verschwindet
            this.ymax = ymax;
            this.Bild = bild;
            graphics = Graphics.FromImage(Bild);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            // Weiße Grundfläche
            graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, Bild.Width, Bild.Height);
        }

        public CoordinateSystem(CoordinateSystem old)
        {
            if (old == null)
                return;
            
            this.xmin = old.xmin;
            this.xmax = old.xmax;
            this.ymin = old.ymin;
            this.ymax = old.ymax;
            this.Bild = old.Bild;
            graphics = Graphics.FromImage(Bild);
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            // Weiße Grundfläche
            graphics.FillRectangle(new SolidBrush(Color.White), 0, 0, Bild.Width, Bild.Height);
        }

        /// <summary>
        /// Erzeugt ein neues CoordinateSystem mit xmin=0 und ymin=0
        /// </summary>
        /// <param name="xmax">Maximaler x-Wert in KS-Koordinaten</param>
        /// <param name="ymax">Maximaler y-Wert in KS-Koordinaten</param>
        public CoordinateSystem(int xmax, int ymax, Bitmap bild) : this(0, xmax, 0, ymax, bild) { }

        /// <summary>
        /// Zeichnet das CoordinateSystem
        /// </summary>
        /// <param name="gleichesSeitenverhaeltnis">Gibt an ob x und y Achse in dem CoordinateSystem gleichlang sein sollen </param>
        public void Draw(bool gleichesSeitenverhaeltnis)
        {
            int dx = 0; // Abstand der Ticks auf der x-Achse in Pixeln
            int sx = 0; // Schrittweite auf der x-Achse
            breite = Bild.Width - (rand[0] + rand[1]);
            hoehe = Bild.Height - (rand[2] + rand[3]);

            double xBereich = xmax - xmin;
            for (int i = 1; i < xBereich; i++)
            {
                dx = (int)(i / xBereich * breite);
                if (dx >= MINDESTABSTAND_TICKS)
                {
                    sx = i;
                    break;
                }
            }

            if (dx == 0 || sx == 0)
                throw new Exception("Fehler bei der Tick-Berechnung für x-Achse. Bild zu klein?");

            int dy = 0; // Abstand der Ticks auf der y-Achse in Pixeln
            int sy = 0; // Schrittweite auf der y-Achse
            double yBereich = ymax - ymin;
            for (int i = 1; i < yBereich; i++)
            {
                dy = (int)(i / yBereich * hoehe);
                if (dy >= MINDESTABSTAND_TICKS)
                {
                    sy = i;
                    break;
                }
            }

            if (dy == 0 || sy == 0)
                throw new Exception("Fehler bei der Tick-Berechnung für y-Achse. Bild zu klein?");

            if (gleichesSeitenverhaeltnis)
            {
                // Nimm den kleineren Tickabstand für beide Achsen
                float ksProPixelX = sx/(float)dx;
                float ksProPixelY = sy / (float)dy;
                if (ksProPixelX < ksProPixelY)
                {
                    // x-Tickabstand anpassen
                    dx = dy;
                    sx = sy;
                    // Länge der x-Achse anpassen
                    breite = (int)(dx * xBereich / sx);
                }

                if (ksProPixelX > ksProPixelY)
                {
                    // y-Tickabstand anpassen
                    dy = dx;
                    sy = sx;
                    // Länge der y-Achse anpassen
                    hoehe = (int)(dy * yBereich / sy);
                }
            }

            int posxAchse = (int)(Bild.Height - rand[3] - (0 - ymin) / (double)sy * dy);
            int posyAchse = (int)(rand[0] + (System.Math.Abs(0 - xmin) / (double)sx) * dx);

            xAchse = new Axis(new Point(rand[0], posxAchse),
                                new Point(breite + rand[0] + (int)(0.8 * rand[1]), posxAchse),
                                AxisType.x, dx, sx, xmin);

            yAchse = new Axis(new Point(posyAchse, Bild.Height - rand[3]),
                                new Point(posyAchse, Bild.Height - (hoehe + (int)(0.8 * rand[2]) + rand[3])), AxisType.y, dy, sy, ymin);

            // Abstand zwischen beschrifteten Ticks
            // Bei 1 werden alle Ticks der Achse beschriftet, bei 2 nur jeder zweite usw.
            xAchse.DistanceBetweenLabeledTicks = Axis.CalcLabeledTicksDistance(xmax, sx, dx, graphics);
            yAchse.DistanceBetweenLabeledTicks = Axis.CalcLabeledTicksDistance(ymax, sy, dy, graphics);

            xAchse.Draw(graphics);
            yAchse.Draw(graphics);
        }

        /// <summary>
        /// Liefert zu einem Pixel-Koordinatenpaar die entsprechenden CoordinateSystem-Koordinaten
        /// </summary>
        /// <param name="x">Die x-Koordinate des Pixelkoordinatenpaars</param>
        /// <param name="y">Die y-Koordinate des Pixelkoordinatenpaars</param>
        /// <returns>Die CoordinateSystem-Koordinaten zum Pixelkoordinatenpaar</returns>
        public Tuple<double, double> GetKoordinaten(int x, int y)
        {
            double deltaX = (x - rand[0]) / (double)xAchse.DTicks * xAchse.StepsTicks;
            double xKoord = xmin + deltaX;

            int diff = Bild.Height - (hoehe + rand[2] + rand[3]);
            int hoeheBild = hoehe + diff + rand[2] + rand[3]; // Gesamthöhe des Bildes

            double deltaY = ((hoeheBild - y) - rand[3]) / (double)yAchse.DTicks * yAchse.StepsTicks;
            double yKoord = ymin + deltaY;

            return new Tuple<double, double>(xKoord, yKoord);
        }

        /// <summary>
        /// Liefert zu einem Koordinatenpaar die entsprechenden Pixel-Koordinaten
        /// </summary>
        /// <param name="x">Die x-Koordinate des Koordinatenpaars</param>
        /// <param name="y">Die y-Koordinate des Koordinatenpaars</param>
        /// <returns>Die Pixel-Koordinaten zum Koordinatenpaar</returns>
        public Tuple<double, double> GetPixelCoordinates(double x, double y)
        {
            double xPixel = rand[0] + (x - xmin) / xAchse.StepsTicks * xAchse.DTicks;
            double deltaY = rand[3] + (y - ymin) / yAchse.StepsTicks * yAchse.DTicks;

            int diff = Bild.Height - (hoehe + rand[2] + rand[3]);
            int hoeheBild = hoehe + diff + rand[2] + rand[3]; // Gesamthöhe des Bildes
            double yPixel = hoeheBild - deltaY;

            return new Tuple<double, double>(xPixel, yPixel);
        }

        /// <summary>
        /// Zeichnet einen ECPoint (CoordinateSystem-Koordinaten) in das CoordinateSystem.
        /// </summary>
        /// <param name="punkt">Der zu zeichnenede ECPoint mit CoordinateSystem-Koordinaten</param>
        public void DrawECPoint(ECPoint punkt)
        {
            DrawPunkt(punkt, PUNKT_FARBE);
        }

        public void DrawLine(Color farbe, ECPoint punkt1, ECPoint punkt2)
        {
            Tuple<double, double> punkt1PixelKoord = GetPixelCoordinates(punkt1.X, punkt1.Y);
            Tuple<double, double> punkt2PixelKoord = GetPixelCoordinates(punkt2.X, punkt2.Y);
            float x1 = (float)punkt1PixelKoord.Item1;
            float x2 = (float)punkt2PixelKoord.Item1;
            float y1 = (float)punkt1PixelKoord.Item2;
            float y2 = (float)punkt2PixelKoord.Item2;

            using (Pen pen = new Pen(farbe))
                graphics.DrawLine(pen, x1, y1, x2, y2);
        }

        public void DrawDashedLine(Color farbe, ECPoint punkt1, ECPoint punkt2)
        {
            Tuple<double, double> punkt1PixelKoord = GetPixelCoordinates(punkt1.X, punkt1.Y);
            Tuple<double, double> punkt2PixelKoord = GetPixelCoordinates(punkt2.X, punkt2.Y);
            float x1 = (float)punkt1PixelKoord.Item1;
            float x2 = (float)punkt2PixelKoord.Item1;
            float y1 = (float)punkt1PixelKoord.Item2;
            float y2 = (float)punkt2PixelKoord.Item2;

            using (Pen pen = new Pen(farbe))
            {
                pen.DashStyle = DashStyle.Dash;
                graphics.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        public void DrawCurve(Point[] kurvenpunkte)
        {
                if (kurvenpunkte.Length>1)
                    using (Pen pen = new Pen(KURVEN_FARBE))
                        graphics.DrawCurve(pen, kurvenpunkte);
                else if (kurvenpunkte.Length == 1)
                        graphics.FillEllipse(Brushes.Black, kurvenpunkte[0].X-3, kurvenpunkte[0].Y-3, 6, 6); // Isolierter ECPoint
        }

        /// <summary>
        /// Zeichnet einen ECPoint mit der Selektierungsfarbe, um darzustellen, dass er ausgewählt ist
        /// </summary>
        /// <param name="punkt">Der zu selektierende ECPoint</param>
        public void SetSelection(ECPoint punkt)
        {
            DrawPunkt(punkt, SELEKTION_FARBE);
        }

        public void ClearSelection(ECPoint punkt)
        {
            DrawPunkt(punkt, PUNKT_FARBE);
        }

        public void SetSummand1(ECPoint punkt)
        {
            FillAndLabelPoint(punkt, Color.Red, "P");
        }

        public void SetSummand2(ECPoint punkt)
        {
            FillAndLabelPoint(punkt, Color.Red, "Q");
        }

        public void SetFactor(ECPoint punkt)
        {
            FillAndLabelPoint(punkt, Color.Red, "S");
        }

        public void SetDoubling(ECPoint punkt)
        {
            FillAndLabelPoint(punkt, Color.Red, "P=Q");
        }

        public void SetAdditionResult(ECPoint punkt)
        {
            FillAndLabelPoint(punkt, Color.Green, "R");
        }

        public void SetMultiplicationResult(int n, ECPoint punkt)
        {
            FillAndLabelPoint(punkt, Color.Green, n + "S");
        }

        public void SetMinusResult(ECPoint punkt)
        {
            FillAndLabelPoint(punkt, Color.RoyalBlue, "-R");
        }

        /// <summary>
        /// Füllt einen ECPoint mit der angegebenen Farbe und beschriftet ihn mit der angegebenen Beschriftung.
        /// Wenn der ECPoint oberhalb oder auf der y-Achse liegt, wird die Beschriftung oberhalb des Punktes, ansonsten
        /// unterhalb des Punktes platziert
        /// </summary>
        /// <param name="punkt"></param>
        /// <param name="farbe"></param>
        /// <param name="label"></param>
        private void FillAndLabelPoint(ECPoint punkt, Color farbe, string label)
        {
            if (punkt == null || punkt.IsInfinity)
                return;

            Tuple<double, double> pixelKoord = this.GetPixelCoordinates(punkt.X, punkt.Y);

            using (Brush brush = new SolidBrush(farbe))
            {
                float x = (float)pixelKoord.Item1 - PUNKT_DICKE / 2;
                float y = (float)pixelKoord.Item2 - PUNKT_DICKE / 2;
                graphics.FillEllipse(brush, x, y, PUNKT_DICKE, PUNKT_DICKE);

                Font font = new Font(FontFamily.GenericSansSerif, 12);
                SizeF groesseBeschriftung = graphics.MeasureString(label, font);

                float richtung = 1; // Beschriftung oberhalb anbringen
                if (punkt.Y < 0)
                    richtung = -0.5F; // Beschriftung unterhalb anbringen

                graphics.DrawString(label, font, new SolidBrush(Color.Black), x - groesseBeschriftung.Width / 2, y - richtung * groesseBeschriftung.Height);
            }
        }

        private void DrawPunkt(ECPoint punkt, Color farbe)
        {
            if (punkt == null || punkt.IsInfinity)
                return;

            Tuple<double, double> pixelKoord = this.GetPixelCoordinates(punkt.X, punkt.Y);

            using (Pen pen = new Pen(farbe))
            {
                float x = (float)pixelKoord.Item1 - PUNKT_DICKE / 2;
                float y = (float)pixelKoord.Item2 - PUNKT_DICKE / 2;
                graphics.DrawEllipse(pen, x, y, PUNKT_DICKE, PUNKT_DICKE);
            }
        }

        /// <summary>
        /// Diese Methode ob durch die übergebenen Pixelkoordinaten (aktuelle Position des Mauszeigers) ein ECPoint
        /// des Koordinatensystems selektiert ist. Ist ein ECPoint selektiert wird dieser ECPoint zurückgeliefert.
        /// </summary>
        /// <param name="pX">Die x-Koordinate der aktuellen Mauszeigerposition</param>
        /// <param name="pY">Die y-Koordinate der aktuellen Mauszeigerposition</param>
        /// <param name="punkte">Die Points der elliptischen Kurve, die auf Selektion geprüft werden sollen</param>
        /// <returns>Den selektierten ECPoint oder <c>null</c>, wenn durch die Pixelkoordinaten kein ECPoint aus der übergebenen Punktliste selektiert ist.</returns>
        public ECPoint FindSelectedPoint(int pX, int pY, List<ECPoint> punkte)
        {
            Tuple<double, double> ksKoordinaten = GetKoordinaten(pX, pY);

            // Finde dichtesten ECPoint zu ksKoordinaten
            double minDist = double.MaxValue;
            ECPoint result = new ECPoint(0, 0);
            foreach (ECPoint punkt in punkte)
            {
                double xdiff = (punkt.X - ksKoordinaten.Item1);
                double ydiff = (punkt.Y - ksKoordinaten.Item2);
                double dist = xdiff * xdiff + ydiff * ydiff; // Das ist eig. das Quadrat des Abstands, reicht aber für Vergleich
                if (dist < minDist)
                {
                    result = punkt;
                    minDist = dist;
                }
            }

            // Pixelbereich des dichtesten Punktes festlegen
            Tuple<double, double> pixelKoordResult = GetPixelCoordinates(result.X, result.Y);
            double xMin = pixelKoordResult.Item1 - PUNKT_DICKE / 2;
            double xMax = pixelKoordResult.Item1 + PUNKT_DICKE / 2;
            double yMin = pixelKoordResult.Item2 - PUNKT_DICKE / 2;
            double yMax = pixelKoordResult.Item2 + PUNKT_DICKE / 2;

            if (pX > xMin && pX < xMax && pY > yMin && pY < yMax)
                return result;

            return null;
        }
    }
}
