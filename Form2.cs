using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
	public partial class Form2 : Form
	{
		public enum GameLevel
		{
			Level1 = 1,  // Easy
			Level2 = 2,  // Medium  
			Level3 = 3   // Hard
		}

		public GameLevel SelectedLevel { get; set; } = GameLevel.Level1;

		public Form2()
		{
			InitializeComponent();
			SetupForm();
		}

		private void SetupForm()
		{

			this.StartPosition = FormStartPosition.CenterScreen;
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;

			// Set default selection to Level1 (Easy)
			EasyRadio.Checked = true;
			SelectedLevel = GameLevel.Level1;

			// Wire up event handlers
			StartButton.Click += StartButton_Click;
			QuitButton.Click += QuitButton_Click;

			// Wire up radio button events
			EasyRadio.CheckedChanged += RB_Level1_CheckedChanged;
			MediumRadio.CheckedChanged += RB_Level2_CheckedChanged;
			HardRadio.CheckedChanged += RB_Level3_CheckedChanged;

			// Add tooltips for better user experience
			ToolTip toolTip = new ToolTip();
			toolTip.SetToolTip(EasyRadio, "Level 1 - 40 numbers shown - Perfect for beginners!");
			toolTip.SetToolTip(MediumRadio, "Level 2 - 30 numbers shown - Good challenge!");
			toolTip.SetToolTip(HardRadio, "Level 3 - 20 numbers shown - For experts only!");

		}

		private void RB_Level1_CheckedChanged(object sender, EventArgs e)
		{
			if (EasyRadio.Checked)
			{
				SelectedLevel = GameLevel.Level1;
				Console.WriteLine("Level 1 (Easy) selected");
			}
		}

		private void RB_Level2_CheckedChanged(object sender, EventArgs e)
		{
			if (MediumRadio.Checked)
			{
				SelectedLevel = GameLevel.Level2;
				Console.WriteLine("Level 2 (Medium) selected");
			}
		}

		private void RB_Level3_CheckedChanged(object sender, EventArgs e)
		{
			if (HardRadio.Checked)
			{
				SelectedLevel = GameLevel.Level3;
				Console.WriteLine("Level 3 (Hard) selected");
			}
		}

		private void StartButton_Click(object sender, EventArgs e)
		{
			if (!EasyRadio.Checked && !MediumRadio.Checked && !HardRadio.Checked)
			{
				MessageBox.Show("Please select a difficulty level!", "No Level Selected",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void QuitButton_Click(object sender, EventArgs e)
		{
			// Set dialog result to Cancel and close
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		public int GetShownNumbersCount()
		{
			switch (SelectedLevel)
			{
				case GameLevel.Level1:  // Easy
					return 40;
				case GameLevel.Level2:  // Medium
					return 30;
				case GameLevel.Level3:  // Hard
					return 20;
				default:
					return 40;
			}
		}

		public string GetLevelName()
		{
			switch (SelectedLevel)
			{
				case GameLevel.Level1:
					return "Level 1 (Easy)";
				case GameLevel.Level2:
					return "Level 2 (Medium)";
				case GameLevel.Level3:
					return "Level 3 (Hard)";
				default:
					return "Level 1 (Easy)";
			}
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (this.DialogResult == DialogResult.None)
			{
				this.DialogResult = DialogResult.Cancel;
			}
			base.OnFormClosing(e);
		}
	}
}