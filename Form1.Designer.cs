namespace Sudoku
{
  partial class Sudoku
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
			this.components = new System.ComponentModel.Container();
			this.PB_BackGrid = new System.Windows.Forms.PictureBox();
			this.BTN_Pause = new System.Windows.Forms.Button();
			this.TM_Base = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.EraseButton = new System.Windows.Forms.Button();
			this.MistakeCount = new System.Windows.Forms.Label();
			this.MaxMistakeLabel = new System.Windows.Forms.Label();
			this.TimerLabel = new System.Windows.Forms.Label();
			this.QuitButton = new System.Windows.Forms.Button();
			this.TimerDisplay = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.PB_BackGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// PB_BackGrid
			// 
			this.PB_BackGrid.BackgroundImage = global::Sudoku.Properties.Resources.SudokuBlankGrid;
			this.PB_BackGrid.Location = new System.Drawing.Point(12, 11);
			this.PB_BackGrid.Name = "PB_BackGrid";
			this.PB_BackGrid.Size = new System.Drawing.Size(453, 435);
			this.PB_BackGrid.TabIndex = 0;
			this.PB_BackGrid.TabStop = false;
			// 
			// BTN_Pause
			// 
			this.BTN_Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_Pause.Location = new System.Drawing.Point(520, 359);
			this.BTN_Pause.Name = "BTN_Pause";
			this.BTN_Pause.Size = new System.Drawing.Size(110, 30);
			this.BTN_Pause.TabIndex = 1;
			this.BTN_Pause.Text = "Pause";
			this.BTN_Pause.UseVisualStyleBackColor = true;
			this.BTN_Pause.Click += new System.EventHandler(this.BTN_Pause_Click);
			// 
			// TM_Base
			// 
			this.TM_Base.Tick += new System.EventHandler(this.TM_Base_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(493, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Mistake:";
			// 
			// EraseButton
			// 
			this.EraseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EraseButton.Location = new System.Drawing.Point(520, 311);
			this.EraseButton.Name = "EraseButton";
			this.EraseButton.Size = new System.Drawing.Size(110, 30);
			this.EraseButton.TabIndex = 5;
			this.EraseButton.Text = "Erase";
			this.EraseButton.UseVisualStyleBackColor = true;
			this.EraseButton.Click += new System.EventHandler(this.EraseButton_Click);
			// 
			// MistakeCount
			// 
			this.MistakeCount.AutoSize = true;
			this.MistakeCount.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MistakeCount.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.MistakeCount.Location = new System.Drawing.Point(573, 61);
			this.MistakeCount.Name = "MistakeCount";
			this.MistakeCount.Size = new System.Drawing.Size(20, 23);
			this.MistakeCount.TabIndex = 6;
			this.MistakeCount.Text = "0";
			this.MistakeCount.Click += new System.EventHandler(this.MistakeCount_Click);
			// 
			// MaxMistakeLabel
			// 
			this.MaxMistakeLabel.AutoSize = true;
			this.MaxMistakeLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MaxMistakeLabel.ForeColor = System.Drawing.Color.MediumSeaGreen;
			this.MaxMistakeLabel.Location = new System.Drawing.Point(588, 61);
			this.MaxMistakeLabel.Name = "MaxMistakeLabel";
			this.MaxMistakeLabel.Size = new System.Drawing.Size(34, 23);
			this.MaxMistakeLabel.TabIndex = 7;
			this.MaxMistakeLabel.Text = "/ 3";
			// 
			// TimerLabel
			// 
			this.TimerLabel.AutoSize = true;
			this.TimerLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimerLabel.Location = new System.Drawing.Point(493, 27);
			this.TimerLabel.Name = "TimerLabel";
			this.TimerLabel.Size = new System.Drawing.Size(58, 23);
			this.TimerLabel.TabIndex = 8;
			this.TimerLabel.Text = "Timer:";
			// 
			// QuitButton
			// 
			this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QuitButton.Location = new System.Drawing.Point(520, 406);
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Size = new System.Drawing.Size(110, 30);
			this.QuitButton.TabIndex = 9;
			this.QuitButton.Text = "Quit";
			this.QuitButton.UseVisualStyleBackColor = true;
			this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
			// 
			// TimerDisplay
			// 
			this.TimerDisplay.AutoSize = true;
			this.TimerDisplay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TimerDisplay.ForeColor = System.Drawing.Color.Firebrick;
			this.TimerDisplay.Location = new System.Drawing.Point(573, 27);
			this.TimerDisplay.Name = "TimerDisplay";
			this.TimerDisplay.Size = new System.Drawing.Size(20, 23);
			this.TimerDisplay.TabIndex = 10;
			this.TimerDisplay.Text = "0";
			// 
			// Sudoku
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.TimerDisplay);
			this.Controls.Add(this.QuitButton);
			this.Controls.Add(this.TimerLabel);
			this.Controls.Add(this.MaxMistakeLabel);
			this.Controls.Add(this.MistakeCount);
			this.Controls.Add(this.EraseButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BTN_Pause);
			this.Controls.Add(this.PB_BackGrid);
			this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(700, 500);
			this.MinimumSize = new System.Drawing.Size(700, 500);
			this.Name = "Sudoku";
			this.Text = "Sudoku";
			((System.ComponentModel.ISupportInitialize)(this.PB_BackGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }


    #endregion

    private System.Windows.Forms.PictureBox PB_BackGrid;
    private System.Windows.Forms.Button BTN_Pause;
    private System.Windows.Forms.Timer TM_Base;
	private System.Windows.Forms.Button BTN_Erase;
	private System.Windows.Forms.Label mistakeLabel;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Button EraseButton;
	private System.Windows.Forms.Label MistakeCount;
	private System.Windows.Forms.Label MaxMistakeLabel;
	private System.Windows.Forms.Label TimerLabel;
	private System.Windows.Forms.Button QuitButton;
	private System.Windows.Forms.Label TimerDisplay;

		////Row 1
		//private System.Windows.Forms.Button R1C1;
		//private System.Windows.Forms.Button R1C2;
		//private System.Windows.Forms.Button R1C3;
		//private System.Windows.Forms.Button R1C4;
		//private System.Windows.Forms.Button R1C5;
		//private System.Windows.Forms.Button R1C6;
		//private System.Windows.Forms.Button R1C7;
		//private System.Windows.Forms.Button R1C8;
		//private System.Windows.Forms.Button R1C9;

		//// Row 2
		//private System.Windows.Forms.Button R2C1;
		//private System.Windows.Forms.Button R2C2;
		//private System.Windows.Forms.Button R2C3;
		//private System.Windows.Forms.Button R2C4;
		//private System.Windows.Forms.Button R2C5;
		//private System.Windows.Forms.Button R2C6;
		//private System.Windows.Forms.Button R2C7;
		//private System.Windows.Forms.Button R2C8;
		//private System.Windows.Forms.Button R2C9;

		//// Row 3
		//private System.Windows.Forms.Button R3C1;
		//private System.Windows.Forms.Button R3C2;
		//private System.Windows.Forms.Button R3C3;
		//private System.Windows.Forms.Button R3C4;
		//private System.Windows.Forms.Button R3C5;
		//private System.Windows.Forms.Button R3C6;
		//private System.Windows.Forms.Button R3C7;
		//private System.Windows.Forms.Button R3C8;
		//private System.Windows.Forms.Button R3C9;

		//// Row 4
		//private System.Windows.Forms.Button R4C1;
		//private System.Windows.Forms.Button R4C2;
		//private System.Windows.Forms.Button R4C3;
		//private System.Windows.Forms.Button R4C4;
		//private System.Windows.Forms.Button R4C5;
		//private System.Windows.Forms.Button R4C6;
		//private System.Windows.Forms.Button R4C7;
		//private System.Windows.Forms.Button R4C8;
		//private System.Windows.Forms.Button R4C9;

		//// Row 5
		//private System.Windows.Forms.Button R5C1;
		//private System.Windows.Forms.Button R5C2;
		//private System.Windows.Forms.Button R5C3;
		//private System.Windows.Forms.Button R5C4;
		//private System.Windows.Forms.Button R5C5;
		//private System.Windows.Forms.Button R5C6;
		//private System.Windows.Forms.Button R5C7;
		//private System.Windows.Forms.Button R5C8;
		//private System.Windows.Forms.Button R5C9;

		//// Row 6
		//private System.Windows.Forms.Button R6C1;
		//private System.Windows.Forms.Button R6C2;
		//private System.Windows.Forms.Button R6C3;
		//private System.Windows.Forms.Button R6C4;
		//private System.Windows.Forms.Button R6C5;
		//private System.Windows.Forms.Button R6C6;
		//private System.Windows.Forms.Button R6C7;
		//private System.Windows.Forms.Button R6C8;
		//private System.Windows.Forms.Button R6C9;

		//// Row 7
		//private System.Windows.Forms.Button R7C1;
		//private System.Windows.Forms.Button R7C2;
		//private System.Windows.Forms.Button R7C3;
		//private System.Windows.Forms.Button R7C4;
		//private System.Windows.Forms.Button R7C5;
		//private System.Windows.Forms.Button R7C6;
		//private System.Windows.Forms.Button R7C7;
		//private System.Windows.Forms.Button R7C8;
		//private System.Windows.Forms.Button R7C9;

		//// Row 8
		//private System.Windows.Forms.Button R8C1;
		//private System.Windows.Forms.Button R8C2;
		//private System.Windows.Forms.Button R8C3;
		//private System.Windows.Forms.Button R8C4;
		//private System.Windows.Forms.Button R8C5;
		//private System.Windows.Forms.Button R8C6;
		//private System.Windows.Forms.Button R8C7;
		//private System.Windows.Forms.Button R8C8;
		//private System.Windows.Forms.Button R8C9;

		//// Row 9
		//private System.Windows.Forms.Button R9C1;
		//private System.Windows.Forms.Button R9C2;
		//private System.Windows.Forms.Button R9C3;
		//private System.Windows.Forms.Button R9C4;
		//private System.Windows.Forms.Button R9C5;
		//private System.Windows.Forms.Button R9C6;
		//private System.Windows.Forms.Button R9C7;
		//private System.Windows.Forms.Button R9C8;
		//private System.Windows.Forms.Button R9C9;
	}
}

