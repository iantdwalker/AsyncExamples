using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAwaitTest
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
		
		private async void _buttonTestClick(object sender, EventArgs e)
		{
			int highValue = int.Parse(_textBoxValue.Text);
			for (int x = 0; x < highValue; x++)
			{
				var newValue = await CalculateValueAsync(x);
				_textBoxValue.Text = newValue.ToString();
			}
		}
		
		private async Task<int> CalculateValueAsync(int number)
		{
			await Task.Delay(3000);
			return number * 10;
		}		
	}
}
