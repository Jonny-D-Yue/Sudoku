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
      this.BTN_Start = new System.Windows.Forms.Button();
      this.RB_Level1 = new System.Windows.Forms.RadioButton();
      this.RB_Level2 = new System.Windows.Forms.RadioButton();
      this.RB_Level3 = new System.Windows.Forms.RadioButton();
      this.TM_Base = new System.Windows.Forms.Timer(this.components);
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
      // BTN_Start
      // 
      this.BTN_Start.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.BTN_Start.Location = new System.Drawing.Point(480, 395);
      this.BTN_Start.Name = "BTN_Start";
      this.BTN_Start.Size = new System.Drawing.Size(190, 50);
      this.BTN_Start.TabIndex = 1;
      this.BTN_Start.Text = "Start";
      this.BTN_Start.UseVisualStyleBackColor = true;
      this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
      // 
      // RB_Level1
      // 
      this.RB_Level1.AutoSize = true;
      this.RB_Level1.Checked = true;
      this.RB_Level1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.RB_Level1.Location = new System.Drawing.Point(530, 66);
      this.RB_Level1.Name = "RB_Level1";
      this.RB_Level1.Size = new System.Drawing.Size(94, 26);
      this.RB_Level1.TabIndex = 2;
      this.RB_Level1.TabStop = true;
      this.RB_Level1.Text = "Level1";
      this.RB_Level1.UseVisualStyleBackColor = true;
      // 
      // RB_Level2
      // 
      this.RB_Level2.AutoSize = true;
      this.RB_Level2.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.RB_Level2.Location = new System.Drawing.Point(530, 98);
      this.RB_Level2.Name = "RB_Level2";
      this.RB_Level2.Size = new System.Drawing.Size(94, 26);
      this.RB_Level2.TabIndex = 3;
      this.RB_Level2.Text = "Level2";
      this.RB_Level2.UseVisualStyleBackColor = true;
      // 
      // RB_Level3
      // 
      this.RB_Level3.AutoSize = true;
      this.RB_Level3.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      this.RB_Level3.Location = new System.Drawing.Point(530, 130);
      this.RB_Level3.Name = "RB_Level3";
      this.RB_Level3.Size = new System.Drawing.Size(94, 26);
      this.RB_Level3.TabIndex = 4;
      this.RB_Level3.Text = "Level3";
      this.RB_Level3.UseVisualStyleBackColor = true;
      // 
      // TM_Base
      // 
      this.TM_Base.Tick += new System.EventHandler(this.TM_Base_Tick);
      // 
      // Sudoku
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.ClientSize = new System.Drawing.Size(684, 456);
      this.Controls.Add(this.RB_Level3);
      this.Controls.Add(this.RB_Level2);
      this.Controls.Add(this.RB_Level1);
      this.Controls.Add(this.BTN_Start);
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
    private System.Windows.Forms.Button BTN_Start;
    private System.Windows.Forms.RadioButton RB_Level1;
    private System.Windows.Forms.RadioButton RB_Level2;
    private System.Windows.Forms.RadioButton RB_Level3;
    private System.Windows.Forms.Timer TM_Base;

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

