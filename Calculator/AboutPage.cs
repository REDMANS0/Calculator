using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Calculator
{
	public partial class AboutPage : Form
	{
		public AboutPage()
		{
			InitializeComponent();
		}

		#region Link Clicks
		private void AboutText_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Background.Focus();
			Process.Start("https://github.com/REDMANS0");
		}

		private void IconAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Background.Focus();
			Process.Start("https://www.iconfinder.com/Tempebacem");
		}

		private void IconLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Background.Focus();
			Process.Start("https://www.iconfinder.com/icons/2824440/calculator_math_school_tool_icon");
		}

		private void IconLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Background.Focus();
			Process.Start("https://creativecommons.org/licenses/by/3.0/");
		}
		#endregion

		#region Form Management
		private void AboutPage_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void AboutPage_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Escape)
			{
				Calculator Calculator = new Calculator();
				Calculator.Show();
				this.Hide();
			}
		}
		#endregion
	}
}
