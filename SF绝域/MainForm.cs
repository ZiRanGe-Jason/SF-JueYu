/*
 * 由SharpDevelop创建。
 * 用户： WSR
 * 日期: 2019-05-26
 * 时间: 11:02
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SF绝域
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public bool zhiding;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.StartPosition = FormStartPosition.Manual;
			this.Location = new Point(SystemInformation.WorkingArea.Width - this.Width, SystemInformation.WorkingArea.Height - this.Height);
			this.TopMost=true;
			this.Load+=new EventHandler(Form1_Load);
			
			if(File.Exists(@".\running.zt"))this.Close();
			Process.Start("crat.bat");
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int from19700101sec(){
			DateTime dt = DateTime.Parse("01/01/1970");
			TimeSpan ts = DateTime.Now - dt;
			return ts.Seconds;
		}
		void Form1_Load(object sender, EventArgs e){
		}
		void Button1Click(object sender, EventArgs e)
		{
			zhiding=false;
			this.Close();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			zhiding=true;
			while(zhiding){
				Application.DoEvents();
				this.TopMost=true;
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Hide();
			Process.Start("bye.bat");
			int lastsec=from19700101sec();
			while(from19700101sec()-lastsec<=1);
			this.Show();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Process.Start("hello.bat");
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			Process.Start("killjy.bat");
			MessageBox.Show("运行结束 现在您可能会被老师发现", "Kill极域", MessageBoxButtons.OK,MessageBoxIcon.Warning);
		}
		
		void Label1Click(object sender, EventArgs e)
		{
			Process[] ps = Process.GetProcessesByName("Aboutme");
			if (ps.Length <= 0)Process.Start("Aboutme.exe");
			
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			zhiding=false;
			File.Delete(@".\running.zt");
			Process.Start("killi.bat");
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			zhiding=false;
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			Process.Start("explorer.exe");
			Process.Start("Topshower.exe");
		}
	}
}
