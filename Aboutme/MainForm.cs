/*
 * 由SharpDevelop创建。
 * 用户： wsr
 * 日期: 2019/5/26
 * 时间: 22:56
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Aboutme
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent(); 
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Label1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Process.Start("winver");
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			MessageBox.Show("此软件用于脱离“极域电子教室”","关于");
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Process.Start("cmd");
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Process.Start("powershell");
		}
	}
}
