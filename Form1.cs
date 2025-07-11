using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Sudoku : Form
    {
        int[,] sudokuBoard = new int[9, 9];
        Button[,] cells = new Button[9, 9];
        Random rand = new Random();

        public Sudoku()
        {
            InitializeComponent();
            this.Load += Sudoku_Load;
            this.Start_Click.Click += Start_Click_Click;
        }

        private void Sudoku_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    string btnName = $"R{i + 1}C{j + 1}";
                    Control[] found = this.Controls.Find(btnName, true);

                    if (found.Length > 0 && found[0] is Button)
                    {
                        cells[i, j] = (Button)found[0];
                        cells[i, j].Text = "";
                        cells[i, j].Enabled = true;
                        cells[i, j].BackColor = Color.White;
                    }
                    else
                    {
                        MessageBox.Show($" Button {btnName} cannot find!", "Error  Button", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            radioButton1.Checked = true;
        }

        private bool IsSafe(int row, int col, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (sudokuBoard[row, i] == num || sudokuBoard[i, col] == num)
                    return false;
            }

            int startRow = row - row % 3;
            int startCol = col - col % 3;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (sudokuBoard[startRow + i, startCol + j] == num)
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
                    sudokuBoard[row, col] = num;
                    if (FillBoard(row, col + 1)) return true;
                    sudokuBoard[row, col] = 0;
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
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            int row = blockRow * 3 + i;
                            int col = blockCol * 3 + j;
                            if (board[row, col] != 0)
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
            int[,] puzzle = (int[,])sudokuBoard.Clone();
            int removed = 0;

            while ((81 - removed) > shownCount)
            {
                int r = rand.Next(0, 9);
                int c = rand.Next(0, 9);
                if (puzzle[r, c] != 0)
                {
                    int temp = puzzle[r, c];
                    puzzle[r, c] = 0;
                    removed++;

                    if (!HasAtLeastOneInEachGrid(puzzle))
                    {
                        puzzle[r, c] = temp;
                        removed--;
                    }
                }
            }

            return puzzle;
        }

        private void DisplayPuzzle(int[,] puzzle)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (cells[i, j] == null)
                    {
                        MessageBox.Show($"⚠️ cells[{i},{j}] have not attach ");
                        continue;
                    }

                    if (puzzle[i, j] != 0)
                    {
                        cells[i, j].Text = puzzle[i, j].ToString();
                        cells[i, j].Enabled = false;
                        cells[i, j].BackColor = Color.LightGray;
                    }
                    else
                    {
                        cells[i, j].Text = "";
                        cells[i, j].Enabled = true;
                        cells[i, j].BackColor = Color.White;
                    }
                }
            }
        }

        private void Start_Click_Click(object sender, EventArgs e)
        {
            int shown = 36;
            if (radioButton2.Checked) shown = 33;
            else if (radioButton3.Checked) shown = 30;

            sudokuBoard = new int[9, 9];
            FillBoard();
            var puzzle = GeneratePuzzle(shown);
            DisplayPuzzle(puzzle);
        }
    }
}
