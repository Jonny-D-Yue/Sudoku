using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Show Form2 (level selection) first
			using (Form2 levelSelectionForm = new Form2())
			{
				if (levelSelectionForm.ShowDialog() == DialogResult.OK)
				{
					// Start the main Sudoku game with selected level
					Application.Run(new Sudoku(levelSelectionForm.SelectedLevel));
				}
				// If user clicks Quit or closes the form, application will exit
			}
		}
	}
}