using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MusicalInstrumentLocator.Models;
using System.Linq;






namespace MusicalInstrumentLocator
{
    public partial class Form3 : Form
    {
        System.Windows.Forms.Timer routeTimer = new System.Windows.Forms.Timer();
        Point animatedEndPoint;
        Point bestStorePosition;
        int animationStep = 0;
        bool animateBestRoute = false;
        Point userPosition = Graph.UserPosition;
        private void DrawLocationPin(Graphics g, Brush brush, Point p)
        {
            int size = 10;

            // Circle head
            g.FillEllipse(brush, p.X - size, p.Y - size, size * 2, size * 2);

            // Triangle tail
            Point[] triangle =
            {
        new Point(p.X, p.Y + size),
        new Point(p.X - size / 2, p.Y + size * 2),
        new Point(p.X + size / 2, p.Y + size * 2)
    };

            g.FillPolygon(brush, triangle);
        }


        public Form3()

        {

            InitializeComponent();
            this.DoubleBuffered = true;
            pnlMap.GetType()
                .GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(pnlMap, true, null);

            pnlMap.Paint += pnlMap_Paint;
            btnSummary.Enabled = false;
            btnBack.Enabled = false;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var bestStore = Graph.GetBestStore();


            if (bestStore != null)
            {
                bestStorePosition = bestStore.Position;
                animateBestRoute = true;
                routeTimer.Start();

            }


            userPosition = new Point(pnlMap.Width / 2, pnlMap.Height / 2);

            routeTimer = new System.Windows.Forms.Timer();
            routeTimer.Interval = 30;
            routeTimer.Tick += RouteTimer_Tick;

            // find best store (example)
            var BestStore = Graph.Stores.FirstOrDefault();
            if (bestStore != null)
            {
                bestStorePosition = bestStore.Position;
                animatedEndPoint = userPosition;
                animateBestRoute = true;
                routeTimer.Start();


            }

            pnlMap.Invalidate();
            btnSummary.Enabled = true;
            btnBack.Enabled = true;
        }

        private void RouteTimer_Tick(object sender, EventArgs e)
        {
            animationStep += 5;
            routeTimer.Interval = 40; // NOT 1, NOT 5

            int dx = bestStorePosition.X - userPosition.X;
            int dy = bestStorePosition.Y - userPosition.Y;

            double distance = Math.Sqrt(dx * dx + dy * dy);

            if (animationStep >= distance)
            {
                animatedEndPoint = bestStorePosition;
                routeTimer.Stop();
                animationStep = 0;

            }
            else
            {
                animatedEndPoint = new Point(
                    userPosition.X + (int)(dx * animationStep / distance),
                    userPosition.Y + (int)(dy * animationStep / distance)
                );
            }

            pnlMap.Invalidate();

            if (!animateBestRoute)
            {
                routeTimer.Stop();
                return;

                routeTimer.Stop();
                animateBestRoute = false;

            }

        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
        private void DrawUserMarker(Graphics g, Point p)
        {
            int size = 10;
            g.FillEllipse(Brushes.Gold, p.X - size, p.Y - size, size * 2, size * 2);
            g.DrawEllipse(Pens.Black, p.X - size, p.Y - size, size * 2, size * 2);
        }




        private void pnlMap_Paint(object sender, PaintEventArgs e)

        {
            Point userPosition = Graph.UserPosition;

            Graphics g = e.Graphics;

            // DRAW USER
            g.FillEllipse(Brushes.Red, userPosition.X - 8, userPosition.Y - 8, 16, 16);

            g.DrawString("YOU", Font, Brushes.Red, userPosition.X + 10, userPosition.Y);

            foreach (var store in Graph.Stores)
            {
                // 1️⃣ DRAW ALL STORES (ALWAYS)
                g.DrawString(store.StoreName, Font, Brushes.Black,
                    store.Position.X + 10, store.Position.Y);
                using (Brush brush = new SolidBrush(store.StoreColor))
                {
                    g.FillEllipse(brush,
                        store.Position.X - 8,
                        store.Position.Y - 8,
                        16, 16);
                    DrawLocationPin(e.Graphics, new SolidBrush(store.StoreColor), store.Position);

                    {


                    }
                }

                // 2️⃣ CHECK IF STORE HAS WANTED INSTRUMENT
                bool hasWantedInstrument = store.Instruments.Any(inst =>
                    Graph.InstrumentsToBuy.Any(w =>
                        w.Equals(inst.Name, StringComparison.OrdinalIgnoreCase)));


                // 3️⃣ DRAW ROUTE ONLY IF MATCHED
                if (hasWantedInstrument)
                {
                    // ROUTE LINE
                    using (Pen routePen = new Pen(Color.DarkBlue, 4)) // thickness = 4
                    {
                        e.Graphics.DrawLine(routePen, userPosition, store.Position);
                    }
                    // DISTANCE
                    double distance = Math.Sqrt(
                        Math.Pow(store.Position.X - userPosition.X, 2) +
                        Math.Pow(store.Position.Y - userPosition.Y, 2)
                    );

                    Point mid = new Point(
                        (userPosition.X + store.Position.X) / 2,
                        (userPosition.Y + store.Position.Y) / 2

                    );

                    g.DrawString(distance.ToString("0.0"),
                        Font, Brushes.Green, mid);

                    pnlMap.Invalidate();


                }

            }
        }

        private void btnSummary_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
