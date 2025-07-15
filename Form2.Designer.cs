namespace Sudoku
{
	partial class Form2
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
			this.GameTitle = new System.Windows.Forms.Label();
			this.EasyRadio = new System.Windows.Forms.RadioButton();
			this.MediumRadio = new System.Windows.Forms.RadioButton();
			this.HardRadio = new System.Windows.Forms.RadioButton();
			this.DifficultiesLabel = new System.Windows.Forms.Label();
			this.StartButton = new System.Windows.Forms.Button();
			this.QuitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// GameTitle
			// 
			this.GameTitle.AutoSize = true;
			this.GameTitle.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GameTitle.Location = new System.Drawing.Point(34, 32);
			this.GameTitle.Name = "GameTitle";
			this.GameTitle.Size = new System.Drawing.Size(280, 38);
			this.GameTitle.TabIndex = 0;
			this.GameTitle.Text = "Welcome to Sudoku!";
			// 
			// EasyRadio
			// 
			this.EasyRadio.AutoSize = true;
			this.EasyRadio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EasyRadio.Location = new System.Drawing.Point(311, 95);
			this.EasyRadio.Name = "EasyRadio";
			this.EasyRadio.Size = new System.Drawing.Size(129, 27);
			this.EasyRadio.TabIndex = 1;
			this.EasyRadio.TabStop = true;
			this.EasyRadio.Text = "Level 1 (Easy)";
			this.EasyRadio.UseVisualStyleBackColor = false;
			// 
			// MediumRadio
			// 
			this.MediumRadio.AutoSize = true;
			this.MediumRadio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MediumRadio.Location = new System.Drawing.Point(311, 128);
			this.MediumRadio.Name = "MediumRadio";
			this.MediumRadio.Size = new System.Drawing.Size(154, 27);
			this.MediumRadio.TabIndex = 2;
			this.MediumRadio.TabStop = true;
			this.MediumRadio.Text = "Level 2 (Medium)";
			this.MediumRadio.UseVisualStyleBackColor = false;
			// 
			// HardRadio
			// 
			this.HardRadio.AutoSize = true;
			this.HardRadio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HardRadio.Location = new System.Drawing.Point(311, 161);
			this.HardRadio.Name = "HardRadio";
			this.HardRadio.Size = new System.Drawing.Size(135, 27);
			this.HardRadio.TabIndex = 3;
			this.HardRadio.TabStop = true;
			this.HardRadio.Text = "Level 3 (Hard)";
			this.HardRadio.UseVisualStyleBackColor = false;
			// 
			// DifficultiesLabel
			// 
			this.DifficultiesLabel.AutoSize = true;
			this.DifficultiesLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DifficultiesLabel.Location = new System.Drawing.Point(37, 95);
			this.DifficultiesLabel.Name = "DifficultiesLabel";
			this.DifficultiesLabel.Size = new System.Drawing.Size(198, 23);
			this.DifficultiesLabel.TabIndex = 4;
			this.DifficultiesLabel.Text = "Choose Game Difficulties:";
			// 
			// StartButton
			// 
			this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartButton.Location = new System.Drawing.Point(116, 228);
			this.StartButton.Name = "StartButton";
			this.StartButton.Size = new System.Drawing.Size(119, 33);
			this.StartButton.TabIndex = 5;
			this.StartButton.Text = "Start";
			this.StartButton.UseVisualStyleBackColor = true;
			// 
			// QuitButton
			// 
			this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QuitButton.Location = new System.Drawing.Point(275, 228);
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Size = new System.Drawing.Size(119, 33);
			this.QuitButton.TabIndex = 6;
			this.QuitButton.Text = "Quit";
			this.QuitButton.UseVisualStyleBackColor = true;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 318);
			this.Controls.Add(this.QuitButton);
			this.Controls.Add(this.StartButton);
			this.Controls.Add(this.DifficultiesLabel);
			this.Controls.Add(this.HardRadio);
			this.Controls.Add(this.MediumRadio);
			this.Controls.Add(this.EasyRadio);
			this.Controls.Add(this.GameTitle);
			this.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.Name = "Form2";
			this.Text = "Let\'s play Sudoku!";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label GameTitle;
		private System.Windows.Forms.RadioButton EasyRadio;
		private System.Windows.Forms.RadioButton MediumRadio;
		private System.Windows.Forms.RadioButton HardRadio;
		private System.Windows.Forms.Label DifficultiesLabel;
		private System.Windows.Forms.Button StartButton;
		private System.Windows.Forms.Button QuitButton;
	}
}