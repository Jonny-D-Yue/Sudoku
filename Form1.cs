using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

    public Sudoku()
    {
      InitializeComponent();
      CreateButtonGrid();

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
          btn.Name = $"R{row}C{col}";
          btn.Size = new Size(buttonWidth, buttonHeight);
          btn.TabIndex = row * 9 + col;
          btn.UseVisualStyleBackColor = true;

          btn.Tag = new Point(row, col);
          btn.Click += Grid_Button_Click;
          btn.Font = new Font("Arial", 24);

          buttons[row, col] = btn;
          PB_BackGrid.Controls.Add(btn);
          //this.Controls.SetChildIndex(btn, 0);
        }
      }

      buttonWidth = 60;
      buttonHeight = 60;
      startX = 480;
      startY = 200;
      for (int row = 0; row < 3; row++)
      {
        for (int col = 0; col < 3; col++)
        {
          Button btn = new Button();
          btn.BackColor = Color.AliceBlue;
          btn.FlatAppearance.BorderSize = 0;
          btn.FlatStyle = FlatStyle.Flat;
          btn.Location = new Point(startX + col * buttonWidth + 4 * col, startY + row * buttonHeight + 4 * row);
          btn.Name = $"BTN_N{row * 3 + col}";
          btn.Size = new Size(buttonWidth, buttonHeight);
          //btn.TabIndex = row * 9 + col;
          btn.UseVisualStyleBackColor = true;

          btn.Tag = new Point(row, col);
          btn.Click += Number_Button_Click;
          btn.Font = new Font("Arial", 32);
          btn.ForeColor = Color.RoyalBlue;
          btn.Text = $"{row * 3 + col + 1}";

          btns[row, col] = btn;
          this.Controls.Add(btn);

        }
      }
    }

    private void Grid_Button_Click(object sender, EventArgs e)
    {
      Button clicked = sender as Button;
      Point pos = (Point)clicked.Tag;
      //MessageBox.Show($"You clicked button：{pos.X}, {pos.Y}");
      for (int i = 0; i < 9; i++)
      {
        for (int j = 0; j < 9; j++)
        {
          if (i == pos.X)
          {
            buttons[i, j].BackColor = Color.AliceBlue;
          }
          else if (j == pos.Y)
          {
            buttons[i, j].BackColor = Color.AliceBlue;
          }
          else if (i / 3 == pos.X / 3 && j / 3 == pos.Y / 3)
          {
            buttons[i, j].BackColor = Color.AliceBlue;
          }
          else
          {
            buttons[i, j].BackColor = Color.Transparent;
          }
        }
      }
      buttons[pos.X, pos.Y].BackColor = Color.LightBlue;
    }

    private void Number_Button_Click(object sender, EventArgs e)
    {
      Button clicked = sender as Button;
      Point pos = (Point)clicked.Tag;
      int number = pos.X * 3 + pos.Y + 1;
      for (int i = 0; i < 9; i++)
      {
        for (int j = 0; j < 9; j++)
        {
          if (buttons[i, j].BackColor == Color.LightBlue)
          {
            if (levelPuzzle[i, j] == 0) // Only allow placing numbers in empty cells
            {
              userBoard[i, j] = number;
              buttons[i, j].Text = number.ToString();
              if (board[i, j] == number)
              {
                buttons[i, j].ForeColor = Color.Black; // Correct entry
              }
              else
              {
                buttons[i, j].ForeColor = Color.Red; // Incorrect entry
              }
              //buttons[i, j].BackColor = Color.Transparent; // Reset color after placing number
            }
            break;
          }
        }
      }
    }

    private void BTN_Start_Click(object sender, EventArgs e)
    {
      int shown = 40;
      if (RB_Level2.Checked) shown = 30;
      else if (RB_Level3.Checked) shown = 20;

      board = new int[9, 9];
      //GenerateSudoku();
      //PrintBoard();
      FillBoard();
      //for (int i = 0; i < 9; i++)
      //{
      //  for (int j = 0; j < 9; j++)
      //  {
      //    buttons[i, j].Text = board[i, j] == 0 ? "" : board[i, j].ToString();
      //    //buttons[i, j].Enabled = board[i, j] == 0; // Disable buttons with pre-filled numbers
      //  }
      //}
      levelPuzzle = GeneratePuzzle(shown);
      userBoard = (int[,])levelPuzzle.Clone();
      DisplayPuzzle(levelPuzzle);
      TM_Base.Start();
      Console.WriteLine("Sudoku generated");
    }


    ////////
    private bool IsSafe(int row, int col, int num)
    {
      for (int i = 0; i < 9; i++)
      {
        if (board[row, i] == num || board[i, col] == num)
          return false;
      }

      int startRow = row - row % 3;
      int startCol = col - col % 3;

      for (int i = 0; i < 3; i++)
        for (int j = 0; j < 3; j++)
          if (board[startRow + i, startCol + j] == num)
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
      int[,] puzzle = (int[,])board.Clone();
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
          if (buttons[i, j] == null)
          {
            MessageBox.Show($"⚠️ cells[{i},{j}] have not attach ");
            continue;
          }

          if (puzzle[i, j] != 0)
          {
            buttons[i, j].Text = puzzle[i, j].ToString();
            buttons[i, j].Enabled = false;
            //buttons[i, j].BackColor = Color.LightGray;
          }
          else
          {
            buttons[i, j].Text = "";
            buttons[i, j].Enabled = true;
            //buttons[i, j].BackColor = Color.White;
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
      for (int i = 1; i <= 9; i++)
        nums.Add(i);

      for (int i = 0; i < nums.Count; i++)
      {
        int j = rand.Next(i, nums.Count);
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
      }

      return nums;
    }

    bool IsValid(int row, int col, int num)
    {
      for (int i = 0; i < 9; i++)
      {
        if (board[row, i] == num || board[i, col] == num)
          return false;
      }

      int startRow = (row / 3) * 3;
      int startCol = (col / 3) * 3;

      for (int i = 0; i < 3; i++)
      {
        for (int j = 0; j < 3; j++)
        {
          if (board[startRow + i, startCol + j] == num)
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
  }
}