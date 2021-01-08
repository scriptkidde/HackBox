
namespace HackBox
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.host = new System.Windows.Forms.TextBox();
			this.hostTime = new System.Windows.Forms.TextBox();
			this.hostPort = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.method = new System.Windows.Forms.ComboBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// host
			// 
			this.host.Location = new System.Drawing.Point(69, 54);
			this.host.Name = "host";
			this.host.Size = new System.Drawing.Size(197, 20);
			this.host.TabIndex = 0;
			this.host.Text = "Host";
			// 
			// hostTime
			// 
			this.hostTime.Location = new System.Drawing.Point(69, 133);
			this.hostTime.Name = "hostTime";
			this.hostTime.Size = new System.Drawing.Size(197, 20);
			this.hostTime.TabIndex = 1;
			this.hostTime.Text = "Time";
			// 
			// hostPort
			// 
			this.hostPort.Location = new System.Drawing.Point(69, 93);
			this.hostPort.Name = "hostPort";
			this.hostPort.Size = new System.Drawing.Size(197, 20);
			this.hostPort.TabIndex = 2;
			this.hostPort.Text = "Port";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(110, 218);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Ddos The Retard";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// method
			// 
			this.method.FormattingEnabled = true;
			this.method.Items.AddRange(new object[] {
            "UDP",
            "TCP",
            "NTP",
            "DNS",
            "WXX (serverdowner)",
            "VPN",
            "GreN",
            "VPNKILLER",
            ""});
			this.method.Location = new System.Drawing.Point(109, 159);
			this.method.Name = "method";
			this.method.Size = new System.Drawing.Size(121, 21);
			this.method.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Page 1";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(338, 287);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.method);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.hostPort);
			this.Controls.Add(this.hostTime);
			this.Controls.Add(this.host);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form2";
			this.Text = "ddos";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox host;
		private System.Windows.Forms.TextBox hostTime;
		private System.Windows.Forms.TextBox hostPort;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox method;
		private System.Windows.Forms.Button button2;
	}
}