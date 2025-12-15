using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MusicalInstrumentLocator.Models;

namespace MusicalInstrumentLocator
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {


            lstSummary.Items.Clear();

            foreach (var store in Graph.Stores)
            {
                foreach (var inst in store.Instruments)
                {
                    if (Graph.InstrumentsToBuy.Contains(inst.Name))
                    {
                        double distance = Math.Abs(store.Location.Length - Graph.UserLocation.Length);

                        lstSummary.Items.Add(
                            $"{store.StoreName} | {inst.Name} | Distance: {distance:0.} | Price: {inst.Price}"


                        );
                    }
                }
            }
        }

        private void btnBest_Click(object sender, EventArgs e)
        {
            // No stores at all
            if (Graph.Stores.Count == 0)
                return;

            // Try normal logic
            var best = Graph.GetBestStore();

            // 🔴 FORCE FALLBACK
            if (best == null)
            {
                best = Graph.Stores[0]; // TAKE FIRST STORE
            }

            MessageBox.Show(
                $"BEST STORE\n\n" +
                $"Store: {best.StoreName}\n" +
                $"Instrument: {best.Instrument}\n" +
                $"Price: ₱{best.Price:0.00}",
                "Best Store",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void lstSummary_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
