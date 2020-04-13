/*
 * 由SharpDevelop创建。
 * 用户： HF01
 * 日期: 2019/10/26
 * 时间: 16:38
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Topshower
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
			this.TopMost=true;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			this.TopMost=true;
		}
		
		void MainFormClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
