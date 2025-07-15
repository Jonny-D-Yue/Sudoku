using Sudoku;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Sudoku
{
	public partial class Sudoku : Form
	{
		private Button[,] buttons = new Button[9, 9];
		private Button[,] btns = new Button[3, 3];
		private int[,] board = new int[9, 9];           // Answer board
		private int[,] userBoard = new int[9, 9];       // User input board
		private int[,] levelPuzzle = new int[9, 9];
		Random rand = new Random();

		private bool isGamePaused = false;
		private Form2.GameLevel currentLevel = Form2.GameLevel.Level1;
		private int mistakeCount = 0;
		private const int MAX_MISTAKES = 3;

		public Sudoku()
		{
			InitializeComponent();
			CreateButtonGrid();
		}

		// Constructor to accept selected level from Form2
		public Sudoku(Form2.GameLevel selectedLevel) : this()
		{
			currentLevel = selectedLevel;
			// Automatically start the game with the selected level
			StartNewGame();
		}

		private void CreateButtonGrid()
		{
			int buttonWidth = 47;
			int buttonHeight = 45;
			int startX = 8;
			int startY = 8;
			int spacingX = 48;
			int spacingY = 46;

			for (int row = 0; row < 9; row++)
			{
				for (int col = 0; col < 9; col++)
				{
					Button btn = new Button();
					btn.BackColor = Color.Transparent;
					btn.FlatAppearance.BorderSize = 0;
					btn.FlatStyle = FlatStyle.Flat;
					btn.Location = new Point(startX + col * spacingX + 3 * (col / 3), startY + row * spacingY + 3 * (row / 3));
					btn.Name = string.Format("R{0}C{1}", row, col);
					btn.Size = new Size(buttonWidth, buttonHeight);
					btn.TabIndex = row * 9 + col;
					btn.UseVisualStyleBackColor = true;

					btn.Tag = new Point(row, col);
					btn.Click += Grid_Button_Click;
					btn.Font = new Font("Arial", 24);

					buttons[row, col] = btn;
					PB_BackGrid.Controls.Add(btn);
				}
			}

			// Number buttons (1-9)
			buttonWidth = 50;
			buttonHeight = 50;
			startX = 495;
			startY = 115;
			for (int row = 0; row < 3; row++)
			{
				for (int col = 0; col < 3; col++)
				{
					Button btn = new Button();
					btn.BackColor = Color.AliceBlue;
					btn.FlatAppearance.BorderSize = 0;
					btn.FlatStyle = FlatStyle.Flat;
					btn.Location = new Point(startX + col * buttonWidth + 4 * col, startY + row * buttonHeight + 4 * row);
					btn.Name = string.Format("BTN_N{0}", row * 3 + col);
					btn.Size = new Size(buttonWidth, buttonHeight);
					btn.UseVisualStyleBackColor = true;

					btn.TextAlign = ContentAlignment.MiddleCenter;
					btn.UseCompatibleTextRendering = false;

					btn.Tag = new Point(row, col);
					btn.Click += Number_Button_Click;
					btn.Font = new Font("Arial", 24, FontStyle.Bold);
					btn.ForeColor = Color.RoyalBlue;
					btn.Text = (row * 3 + col + 1).ToString();

					btns[row, col] = btn;
					this.Controls.Add(btn);
				}
			}

			UpdateMistakeDisplay();
		}

		private void Grid_Button_Click(object sender, EventArgs e)
		{
			if (isGamePaused) return;

			Button clicked = sender as Button;
			Point pos = (Point)clicked.Tag;
			int clickedRow = pos.X;
			int clickedCol = pos.Y;

			for (int row = 0; row < 9; row++)
			{
				for (int col = 0; col < 9; col++)
				{
					if (row == clickedRow)
					{
						buttons[row, col].BackColor = Color.AliceBlue;
					}
					else if (col == clickedCol)
					{
						buttons[row, col].BackColor = Color.AliceBlue;
					}
					else if (row / 3 == clickedRow / 3 && col / 3 == clickedCol / 3)
					{
						buttons[row, col].BackColor = Color.AliceBlue;
					}
					else
					{
						buttons[row, col].BackColor = Color.Transparent;
					}
				}
			}
			buttons[clickedRow, clickedCol].BackColor = Color.LightBlue;
		}

		private void Number_Button_Click(object sender, EventArgs e)
		{
			if (isGamePaused) return;

			Button clicked = sender as Button;
			Point pos = (Point)clicked.Tag;
			int number = pos.X * 3 + pos.Y + 1;
			for (int row = 0; row < 9; row++)
			{
				for (int col = 0; col < 9; col++)
				{
					if (buttons[row, col].BackColor == Color.LightBlue)
					{
						if (levelPuzzle[row, col] == 0) // Only allow placing numbers in empty cells
						{
							int previousNumber = userBoard[row, col];
							bool hadPreviousEntry = previousNumber != 0;
							bool previousWasCorrect = hadPreviousEntry && (board[row, col] == previousNumber);

							userBoard[row, col] = number;
							buttons[row, col].Text = number.ToString();

							bool newIsCorrect = (board[row, col] == number);

							if (newIsCorrect)
							{
								buttons[row, col].ForeColor = Color.Black; // Correct entry
							}
							else
							{
								buttons[row, col].ForeColor = Color.Red; // Incorrect entry

								// Only increment mistake count if:
								// 1. There was no previous entry, OR
								// 2. Previous entry was correct (now making it wrong)
								if (!hadPreviousEntry || previousWasCorrect)
								{
									mistakeCount++;
									UpdateMistakeDisplay();

									if (mistakeCount >= MAX_MISTAKES)
									{
										GameOver();
									}
								}
							}
						}
						break;
					}
				}
			}
		}

		private void EraseButton_Click(object sender, EventArgs e)
		{
			if (isGamePaused) return;

			for (int row = 0; row < 9; row++)
			{
				for (int col = 0; col < 9; col++)
				{
					if (buttons[row, col].BackColor == Color.LightBlue)
					{
						if (levelPuzzle[row, col] == 0) // Only allow erasing user entries
						{
							userBoard[row, col] = 0;
							buttons[row, col].Text = "";
							buttons[row, col].ForeColor = Color.Black;
						}
						break;
					}
				}
			}
		}

		private void BTN_Pause_Click(object sender, EventArgs e)
		{
			if (isGamePaused)
			{
				ResumeGame();
			}
			else
			{
				PauseGame();
			}
		}
		private void QuitButton_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
				"Are you sure you want to quit the game?",
				"Quit Game",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void StartNewGame()
		{
			using (Form2 tempForm = new Form2())
			{
				tempForm.SelectedLevel = currentLevel; // Set to current level
				int shown = tempForm.GetShownNumbersCount();
				string levelName = tempForm.GetLevelName();

				board = new int[9, 9];
				FillBoard();
				levelPuzzle = GeneratePuzzle(shown);
				userBoard = (int[,])levelPuzzle.Clone();
				DisplayPuzzle(levelPuzzle);

				isGamePaused = false;
				mistakeCount = 0;
				UpdateMistakeDisplay();

				TM_Base.Start();

				EnableNumberButtons(true);
				EraseButton.Enabled = true;

				this.Text = string.Format("Sudoku - {0}", levelName);

				Console.WriteLine(string.Format("Sudoku generated and started - {0} with {1} numbers shown", levelName, shown));
			}
		}

		private void PauseGame()
		{
			isGamePaused = true;
			TM_Base.Stop();
			BTN_Pause.Text = "Resume";

			EnableNumberButtons(false);
			HideGameGrid(true);

			Console.WriteLine("Game paused");
		}

		private void ResumeGame()
		{
			isGamePaused = false;
			TM_Base.Start();
			BTN_Pause.Text = "Pause";

			EnableNumberButtons(true);
			HideGameGrid(false);

			Console.WriteLine("Game resumed");
		}

		private void EnableNumberButtons(bool enabled)
		{
			for (int row = 0; row < 3; row++)
			{
				for (int col = 0; col < 3; col++)
				{
					btns[row, col].Enabled = enabled;
				}
			}

			if (EraseButton != null)
			{
				EraseButton.Enabled = enabled;
			}
		}

		private void HideGameGrid(bool hide)
		{
			for (int row = 0; row < 9; row++)
			{
				for (int col = 0; col < 9; col++)
				{
					if (hide)
					{
						buttons[row, col].Text = "";
						buttons[row, col].BackColor = Color.Gray;
					}
					else
					{
						if (levelPuzzle[row, col] != 0)
						{
							buttons[row, col].Text = levelPuzzle[row, col].ToString();
						}
						else if (userBoard[row, col] != 0)
						{
							buttons[row, col].Text = userBoard[row, col].ToString();
							buttons[row, col].ForeColor = (board[row, col] == userBoard[row, col]) ? Color.Black : Color.Red;
						}
						else
						{
							buttons[row, col].Text = "";
						}
						buttons[row, col].BackColor = Color.Transparent;
					}
				}
			}
		}

		private void ResetGame()
		{
			isGamePaused = false;
			mistakeCount = 0;
			UpdateMistakeDisplay();
			TM_Base.Stop();
			BTN_Pause.Text = "Pause";

			for (int row = 0; row < 9; row++)
			{
				for (int col = 0; col < 9; col++)
				{
					buttons[row, col].Text = "";
					buttons[row, col].BackColor = Color.Transparent;
					buttons[row, col].Enabled = true;
				}
			}

			EnableNumberButtons(true);
		}

		private void UpdateMistakeDisplay()
		{
			if (MistakeCount != null)
			{
				MistakeCount.Text = mistakeCount.ToString();
			}
		}

		private void GameOver()
		{
			TM_Base.Stop();
			EnableNumberButtons(false);

			DialogResult result = MessageBox.Show(
				"Game Over! You made maximum 3 mistakes.\n\nWould you like to start a new game?",
				"Game Over",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Information);

			if (result == DialogResult.Yes)
			{
				// Start a new game
				ResetGame();
				ShowLevelAndReStart();
			}
			else
			{
				// Player chose No - close the application
				Application.Exit();
			}
		}

		private void ShowLevelAndReStart()
		{
			using (Form2 levelForm = new Form2())
			{
				if (levelForm.ShowDialog() == DialogResult.OK)
				{
					currentLevel = levelForm.SelectedLevel;
					StartNewGame();
				}
			}
		}

		////////
		private bool IsSafe(int row, int col, int num)
		{
			for (int checkCol = 0; checkCol < 9; checkCol++)
			{
				if (board[row, checkCol] == num || board[checkCol, col] == num)
					return false;
			}

			int startRow = row - row % 3;
			int startCol = col - col % 3;

			for (int blockRow = 0; blockRow < 3; blockRow++)
				for (int blockCol = 0; blockCol < 3; blockCol++)
					if (board[startRow + blockRow, startCol + blockCol] == num)
						return false;

			return true;
		}

		private bool FillBoard(int row = 0, int col = 0)
		{
			if (row == 9) return true;
			if (col == 9) return FillBoard(row + 1, 0);

			var numbers = Enumerable.Range(1, 9).OrderBy(x => rand.Next()).ToList();

			foreach (int num in numbers)
			{
				if (IsSafe(row, col, num))
				{
					board[row, col] = num;
					if (FillBoard(row, col + 1)) return true;
					board[row, col] = 0;
				}
			}

			return false;
		}

		private bool HasAtLeastOneInEachGrid(int[,] board)
		{
			for (int blockRow = 0; blockRow < 3; blockRow++)
			{
				for (int blockCol = 0; blockCol < 3; blockCol++)
				{
					bool found = false;
					for (int row = 0; row < 3; row++)
					{
						for (int col = 0; col < 3; col++)
						{
							int actualRow = blockRow * 3 + row;
							int actualCol = blockCol * 3 + col;
							if (board[actualRow, actualCol] != 0)
							{
								found = true;
								break;
							}
						}
					}
					if (!found) return false;
				}
			}
			return true;
		}

		private int[,] GeneratePuzzle(int shownCount)
		{
			int[,] puzzle = (int[,])board.Clone();
			int removed = 0;

			while ((81 - removed) > shownCount)
			{
				int randomRow = rand.Next(0, 9);
				int randomCol = rand.Next(0, 9);
				if (puzzle[randomRow, randomCol] != 0)
				{
					int temp = puzzle[randomRow, randomCol];
					puzzle[randomRow, randomCol] = 0;
					removed++;

					if (!HasAtLeastOneInEachGrid(puzzle))
					{
						puzzle[randomRow, randomCol] = temp;
						removed--;
					}
				}
			}

			return puzzle;
		}

		private void DisplayPuzzle(int[,] puzzle)
		{
			for (int row = 0; row < 9; row++)
			{
				for (int col = 0; col < 9; col++)
				{
					if (buttons[row, col] == null)
					{
						MessageBox.Show(string.Format("⚠️ cells[{0},{1}] have not attach", row, col));
						continue;
					}

					if (puzzle[row, col] != 0)
					{
						buttons[row, col].Text = puzzle[row, col].ToString();
						buttons[row, col].Enabled = false;
					}
					else
					{
						buttons[row, col].Text = "";
						buttons[row, col].Enabled = true;
					}
				}
			}
		}

		////////
		bool GenerateSudoku()
		{
			for (int row = 0; row < 9; row++)
			{
				for (int col = 0; col < 9; col++)
				{
					if (board[row, col] == 0)
					{
						List<int> numbers = GetShuffledNumbers();

						foreach (int num in numbers)
						{
							if (IsValid(row, col, num))
							{
								board[row, col] = num;

								if (GenerateSudoku())
									return true;

								board[row, col] = 0;
							}
						}
						return false;
					}
				}
			}
			return true; // Sudoku is solved  
		}

		List<int> GetShuffledNumbers()
		{
			List<int> nums = new List<int>();
			for (int num = 1; num <= 9; num++)
				nums.Add(num);

			for (int currentIndex = 0; currentIndex < nums.Count; currentIndex++)
			{
				int randomIndex = rand.Next(currentIndex, nums.Count);
				int temp = nums[currentIndex];
				nums[currentIndex] = nums[randomIndex];
				nums[randomIndex] = temp;
			}

			return nums;
		}

		bool IsValid(int row, int col, int num)
		{
			for (int checkCol = 0; checkCol < 9; checkCol++)
			{
				if (board[row, checkCol] == num || board[checkCol, col] == num)
					return false;
			}

			int startRow = (row / 3) * 3;
			int startCol = (col / 3) * 3;

			for (int blockRow = 0; blockRow < 3; blockRow++)
			{
				for (int blockCol = 0; blockCol < 3; blockCol++)
				{
					if (board[startRow + blockRow, startCol + blockCol] == num)
						return false;
				}
			}

			return true;
		}

		void PrintBoard()
		{
			for (int row = 0; row < 9; row++)
			{
				for (int col = 0; col < 9; col++)
				{
					Console.Write(board[row, col] + " ");
				}
				Console.WriteLine();
			}
		}

		private void TM_Base_Tick(object sender, EventArgs e)
		{

		}

		private void RB_Level1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void MistakeCount_Click(object sender, EventArgs e)
		{

		}

	}
}