using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Database_v2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t1 = new Ticket();
            t1.ShowDialog();
		}

        private void button2_Click(object sender, EventArgs e)
        {
            var w1 = new Wait();
            w1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var r1 = new Route();
            r1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var t1 = new Train();
            t1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var pt1 = new PlaceTrain();
            pt1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var p1 = new Passengers();
            p1.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var s1 = new Stations();
            s1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var t1 = new Type();
            t1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var t1 = new Trace();
            t1.ShowDialog();
        }
		
		protected override void OnClosing(CancelEventArgs wArgs)
		{
		}

		private void Main_Load(object sender, EventArgs e)
		{
		}

		private void button18_Click(object sender, EventArgs e)
		{
			var t = new TicketSell();
			t.ShowDialog();
		}

		private void button15_Click(object sender, EventArgs e)
		{
			var b = new Train();
			b.ShowDialog();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			var t = new StationsNew();
			t.ShowDialog();
		}

		private void button16_Click(object sender, EventArgs e)
		{
			var t = new RouteNew();
			t.ShowDialog();
		}

		private void button11_Click(object sender, EventArgs e)
		{
		}
	}
}
