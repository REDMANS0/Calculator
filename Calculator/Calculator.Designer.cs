
namespace Calculator
{
	partial class Calculator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
			this.Background = new System.Windows.Forms.Panel();
			this.Answer = new System.Windows.Forms.Label();
			this.ButtonMinus = new System.Windows.Forms.Button();
			this.ButtonBracketOpen = new System.Windows.Forms.Button();
			this.ButtonBracketClose = new System.Windows.Forms.Button();
			this.ButtonDelete = new System.Windows.Forms.Button();
			this.ButtonBackspace = new System.Windows.Forms.Button();
			this.ButtonDivide = new System.Windows.Forms.Button();
			this.ButtonMultiply = new System.Windows.Forms.Button();
			this.ButtonPlus = new System.Windows.Forms.Button();
			this.ButtonEqual = new System.Windows.Forms.Button();
			this.Number9 = new System.Windows.Forms.Button();
			this.Number8 = new System.Windows.Forms.Button();
			this.Number7 = new System.Windows.Forms.Button();
			this.Number6 = new System.Windows.Forms.Button();
			this.Number5 = new System.Windows.Forms.Button();
			this.Number4 = new System.Windows.Forms.Button();
			this.Number3 = new System.Windows.Forms.Button();
			this.Number2 = new System.Windows.Forms.Button();
			this.Number1 = new System.Windows.Forms.Button();
			this.ButtonDot = new System.Windows.Forms.Button();
			this.Number0 = new System.Windows.Forms.Button();
			this.ButtonNumberMinus = new System.Windows.Forms.Button();
			this.Equation = new System.Windows.Forms.Label();
			this.Background.SuspendLayout();
			this.SuspendLayout();
			// 
			// Background
			// 
			this.Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
			this.Background.Controls.Add(this.Answer);
			this.Background.Controls.Add(this.ButtonMinus);
			this.Background.Controls.Add(this.ButtonBracketOpen);
			this.Background.Controls.Add(this.ButtonBracketClose);
			this.Background.Controls.Add(this.ButtonDelete);
			this.Background.Controls.Add(this.ButtonBackspace);
			this.Background.Controls.Add(this.ButtonDivide);
			this.Background.Controls.Add(this.ButtonMultiply);
			this.Background.Controls.Add(this.ButtonPlus);
			this.Background.Controls.Add(this.ButtonEqual);
			this.Background.Controls.Add(this.Number9);
			this.Background.Controls.Add(this.Number8);
			this.Background.Controls.Add(this.Number7);
			this.Background.Controls.Add(this.Number6);
			this.Background.Controls.Add(this.Number5);
			this.Background.Controls.Add(this.Number4);
			this.Background.Controls.Add(this.Number3);
			this.Background.Controls.Add(this.Number2);
			this.Background.Controls.Add(this.Number1);
			this.Background.Controls.Add(this.ButtonDot);
			this.Background.Controls.Add(this.Number0);
			this.Background.Controls.Add(this.ButtonNumberMinus);
			this.Background.Controls.Add(this.Equation);
			this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Background.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Background.ForeColor = System.Drawing.Color.White;
			this.Background.Location = new System.Drawing.Point(0, 0);
			this.Background.Name = "Background";
			this.Background.Size = new System.Drawing.Size(319, 541);
			this.Background.TabIndex = 0;
			// 
			// Answer
			// 
			this.Answer.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Answer.Location = new System.Drawing.Point(0, 87);
			this.Answer.Name = "Answer";
			this.Answer.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.Answer.Size = new System.Drawing.Size(319, 54);
			this.Answer.TabIndex = 0;
			this.Answer.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// ButtonMinus
			// 
			this.ButtonMinus.FlatAppearance.BorderSize = 0;
			this.ButtonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonMinus.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonMinus.Location = new System.Drawing.Point(240, 300);
			this.ButtonMinus.Name = "ButtonMinus";
			this.ButtonMinus.Size = new System.Drawing.Size(79, 80);
			this.ButtonMinus.TabIndex = 0;
			this.ButtonMinus.TabStop = false;
			this.ButtonMinus.Text = "–";
			this.ButtonMinus.UseVisualStyleBackColor = true;
			this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
			// 
			// ButtonBracketOpen
			// 
			this.ButtonBracketOpen.FlatAppearance.BorderSize = 0;
			this.ButtonBracketOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonBracketOpen.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonBracketOpen.Location = new System.Drawing.Point(0, 141);
			this.ButtonBracketOpen.Name = "ButtonBracketOpen";
			this.ButtonBracketOpen.Size = new System.Drawing.Size(40, 80);
			this.ButtonBracketOpen.TabIndex = 0;
			this.ButtonBracketOpen.TabStop = false;
			this.ButtonBracketOpen.Text = "(";
			this.ButtonBracketOpen.UseVisualStyleBackColor = true;
			this.ButtonBracketOpen.Click += new System.EventHandler(this.ButtonBracketOpen_Click);
			// 
			// ButtonBracketClose
			// 
			this.ButtonBracketClose.FlatAppearance.BorderSize = 0;
			this.ButtonBracketClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonBracketClose.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonBracketClose.Location = new System.Drawing.Point(40, 141);
			this.ButtonBracketClose.Name = "ButtonBracketClose";
			this.ButtonBracketClose.Size = new System.Drawing.Size(40, 80);
			this.ButtonBracketClose.TabIndex = 0;
			this.ButtonBracketClose.TabStop = false;
			this.ButtonBracketClose.Text = ")";
			this.ButtonBracketClose.UseVisualStyleBackColor = true;
			this.ButtonBracketClose.Click += new System.EventHandler(this.ButtonBracketClose_Click);
			// 
			// ButtonDelete
			// 
			this.ButtonDelete.FlatAppearance.BorderSize = 0;
			this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonDelete.Location = new System.Drawing.Point(80, 141);
			this.ButtonDelete.Name = "ButtonDelete";
			this.ButtonDelete.Size = new System.Drawing.Size(80, 80);
			this.ButtonDelete.TabIndex = 0;
			this.ButtonDelete.TabStop = false;
			this.ButtonDelete.Text = "C";
			this.ButtonDelete.UseVisualStyleBackColor = true;
			this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
			// 
			// ButtonBackspace
			// 
			this.ButtonBackspace.FlatAppearance.BorderSize = 0;
			this.ButtonBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonBackspace.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonBackspace.Image = global::Calculator.Properties.Resources.Backspace;
			this.ButtonBackspace.Location = new System.Drawing.Point(161, 141);
			this.ButtonBackspace.Name = "ButtonBackspace";
			this.ButtonBackspace.Size = new System.Drawing.Size(79, 80);
			this.ButtonBackspace.TabIndex = 0;
			this.ButtonBackspace.TabStop = false;
			this.ButtonBackspace.UseVisualStyleBackColor = true;
			this.ButtonBackspace.Click += new System.EventHandler(this.ButtonBackspace_Click);
			// 
			// ButtonDivide
			// 
			this.ButtonDivide.FlatAppearance.BorderSize = 0;
			this.ButtonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonDivide.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonDivide.Location = new System.Drawing.Point(240, 141);
			this.ButtonDivide.Name = "ButtonDivide";
			this.ButtonDivide.Size = new System.Drawing.Size(79, 80);
			this.ButtonDivide.TabIndex = 0;
			this.ButtonDivide.TabStop = false;
			this.ButtonDivide.Text = "÷";
			this.ButtonDivide.UseVisualStyleBackColor = true;
			this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
			// 
			// ButtonMultiply
			// 
			this.ButtonMultiply.FlatAppearance.BorderSize = 0;
			this.ButtonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonMultiply.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonMultiply.Location = new System.Drawing.Point(240, 221);
			this.ButtonMultiply.Name = "ButtonMultiply";
			this.ButtonMultiply.Size = new System.Drawing.Size(79, 80);
			this.ButtonMultiply.TabIndex = 0;
			this.ButtonMultiply.TabStop = false;
			this.ButtonMultiply.Text = "×";
			this.ButtonMultiply.UseVisualStyleBackColor = true;
			this.ButtonMultiply.Click += new System.EventHandler(this.ButtonMultiply_Click);
			// 
			// ButtonPlus
			// 
			this.ButtonPlus.FlatAppearance.BorderSize = 0;
			this.ButtonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonPlus.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonPlus.Location = new System.Drawing.Point(240, 381);
			this.ButtonPlus.Name = "ButtonPlus";
			this.ButtonPlus.Size = new System.Drawing.Size(79, 80);
			this.ButtonPlus.TabIndex = 0;
			this.ButtonPlus.TabStop = false;
			this.ButtonPlus.Text = "+";
			this.ButtonPlus.UseVisualStyleBackColor = true;
			this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
			// 
			// ButtonEqual
			// 
			this.ButtonEqual.FlatAppearance.BorderSize = 0;
			this.ButtonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonEqual.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonEqual.Location = new System.Drawing.Point(240, 461);
			this.ButtonEqual.Name = "ButtonEqual";
			this.ButtonEqual.Size = new System.Drawing.Size(79, 80);
			this.ButtonEqual.TabIndex = 0;
			this.ButtonEqual.TabStop = false;
			this.ButtonEqual.Text = "=";
			this.ButtonEqual.UseVisualStyleBackColor = true;
			this.ButtonEqual.Click += new System.EventHandler(this.ButtonEqual_Click);
			// 
			// Number9
			// 
			this.Number9.FlatAppearance.BorderSize = 0;
			this.Number9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Number9.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number9.Location = new System.Drawing.Point(160, 221);
			this.Number9.Name = "Number9";
			this.Number9.Size = new System.Drawing.Size(80, 80);
			this.Number9.TabIndex = 0;
			this.Number9.TabStop = false;
			this.Number9.Text = "9";
			this.Number9.UseVisualStyleBackColor = true;
			this.Number9.Click += new System.EventHandler(this.Number9_Click);
			// 
			// Number8
			// 
			this.Number8.FlatAppearance.BorderSize = 0;
			this.Number8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Number8.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number8.Location = new System.Drawing.Point(80, 221);
			this.Number8.Name = "Number8";
			this.Number8.Size = new System.Drawing.Size(80, 80);
			this.Number8.TabIndex = 0;
			this.Number8.TabStop = false;
			this.Number8.Text = "8";
			this.Number8.UseVisualStyleBackColor = true;
			this.Number8.Click += new System.EventHandler(this.Number8_Click);
			// 
			// Number7
			// 
			this.Number7.FlatAppearance.BorderSize = 0;
			this.Number7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Number7.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number7.Location = new System.Drawing.Point(0, 221);
			this.Number7.Name = "Number7";
			this.Number7.Size = new System.Drawing.Size(80, 80);
			this.Number7.TabIndex = 0;
			this.Number7.TabStop = false;
			this.Number7.Text = "7";
			this.Number7.UseVisualStyleBackColor = true;
			this.Number7.Click += new System.EventHandler(this.Number7_Click);
			// 
			// Number6
			// 
			this.Number6.FlatAppearance.BorderSize = 0;
			this.Number6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Number6.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number6.Location = new System.Drawing.Point(160, 300);
			this.Number6.Name = "Number6";
			this.Number6.Size = new System.Drawing.Size(80, 80);
			this.Number6.TabIndex = 0;
			this.Number6.TabStop = false;
			this.Number6.Text = "6";
			this.Number6.UseVisualStyleBackColor = true;
			this.Number6.Click += new System.EventHandler(this.Number6_Click);
			// 
			// Number5
			// 
			this.Number5.FlatAppearance.BorderSize = 0;
			this.Number5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Number5.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number5.Location = new System.Drawing.Point(80, 300);
			this.Number5.Name = "Number5";
			this.Number5.Size = new System.Drawing.Size(80, 80);
			this.Number5.TabIndex = 0;
			this.Number5.TabStop = false;
			this.Number5.Text = "5";
			this.Number5.UseVisualStyleBackColor = true;
			this.Number5.Click += new System.EventHandler(this.Number5_Click);
			// 
			// Number4
			// 
			this.Number4.FlatAppearance.BorderSize = 0;
			this.Number4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Number4.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number4.Location = new System.Drawing.Point(0, 300);
			this.Number4.Name = "Number4";
			this.Number4.Size = new System.Drawing.Size(80, 80);
			this.Number4.TabIndex = 0;
			this.Number4.TabStop = false;
			this.Number4.Text = "4";
			this.Number4.UseVisualStyleBackColor = true;
			this.Number4.Click += new System.EventHandler(this.Number4_Click);
			// 
			// Number3
			// 
			this.Number3.FlatAppearance.BorderSize = 0;
			this.Number3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Number3.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number3.Location = new System.Drawing.Point(160, 381);
			this.Number3.Name = "Number3";
			this.Number3.Size = new System.Drawing.Size(80, 80);
			this.Number3.TabIndex = 0;
			this.Number3.TabStop = false;
			this.Number3.Text = "3";
			this.Number3.UseVisualStyleBackColor = true;
			this.Number3.Click += new System.EventHandler(this.Number3_Click);
			// 
			// Number2
			// 
			this.Number2.FlatAppearance.BorderSize = 0;
			this.Number2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Number2.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number2.Location = new System.Drawing.Point(80, 381);
			this.Number2.Name = "Number2";
			this.Number2.Size = new System.Drawing.Size(80, 80);
			this.Number2.TabIndex = 0;
			this.Number2.TabStop = false;
			this.Number2.Text = "2";
			this.Number2.UseVisualStyleBackColor = true;
			this.Number2.Click += new System.EventHandler(this.Number2_Click);
			// 
			// Number1
			// 
			this.Number1.FlatAppearance.BorderSize = 0;
			this.Number1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Number1.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number1.Location = new System.Drawing.Point(0, 381);
			this.Number1.Name = "Number1";
			this.Number1.Size = new System.Drawing.Size(80, 80);
			this.Number1.TabIndex = 0;
			this.Number1.TabStop = false;
			this.Number1.Text = "1";
			this.Number1.UseVisualStyleBackColor = true;
			this.Number1.Click += new System.EventHandler(this.Number1_Click);
			// 
			// ButtonDot
			// 
			this.ButtonDot.FlatAppearance.BorderSize = 0;
			this.ButtonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonDot.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonDot.Location = new System.Drawing.Point(160, 461);
			this.ButtonDot.Name = "ButtonDot";
			this.ButtonDot.Size = new System.Drawing.Size(80, 80);
			this.ButtonDot.TabIndex = 0;
			this.ButtonDot.TabStop = false;
			this.ButtonDot.Text = ".";
			this.ButtonDot.UseVisualStyleBackColor = true;
			this.ButtonDot.Click += new System.EventHandler(this.ButtonDot_Click);
			// 
			// Number0
			// 
			this.Number0.FlatAppearance.BorderSize = 0;
			this.Number0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Number0.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Number0.Location = new System.Drawing.Point(80, 461);
			this.Number0.Name = "Number0";
			this.Number0.Size = new System.Drawing.Size(80, 80);
			this.Number0.TabIndex = 0;
			this.Number0.TabStop = false;
			this.Number0.Text = "0";
			this.Number0.UseVisualStyleBackColor = true;
			this.Number0.Click += new System.EventHandler(this.Number0_Click);
			// 
			// ButtonNumberMinus
			// 
			this.ButtonNumberMinus.FlatAppearance.BorderSize = 0;
			this.ButtonNumberMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ButtonNumberMinus.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ButtonNumberMinus.Location = new System.Drawing.Point(0, 461);
			this.ButtonNumberMinus.Name = "ButtonNumberMinus";
			this.ButtonNumberMinus.Size = new System.Drawing.Size(80, 80);
			this.ButtonNumberMinus.TabIndex = 0;
			this.ButtonNumberMinus.TabStop = false;
			this.ButtonNumberMinus.Text = "-";
			this.ButtonNumberMinus.UseVisualStyleBackColor = true;
			this.ButtonNumberMinus.Click += new System.EventHandler(this.ButtonNumberMinus_Click);
			// 
			// Equation
			// 
			this.Equation.Dock = System.Windows.Forms.DockStyle.Top;
			this.Equation.Font = new System.Drawing.Font("Microsoft Tai Le", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Equation.ForeColor = System.Drawing.Color.White;
			this.Equation.Location = new System.Drawing.Point(0, 0);
			this.Equation.Name = "Equation";
			this.Equation.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.Equation.Size = new System.Drawing.Size(319, 87);
			this.Equation.TabIndex = 0;
			this.Equation.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.Equation.TextChanged += new System.EventHandler(this.Equation_TextChanged);
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 541);
			this.Controls.Add(this.Background);
			this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Calculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculator_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculator_KeyPress);
			this.Background.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel Background;
		private System.Windows.Forms.Button ButtonNumberMinus;
		private System.Windows.Forms.Button Number0;
		private System.Windows.Forms.Button Number1;
		private System.Windows.Forms.Button ButtonDot;
		private System.Windows.Forms.Button Number4;
		private System.Windows.Forms.Button Number3;
		private System.Windows.Forms.Button Number2;
		private System.Windows.Forms.Button Number9;
		private System.Windows.Forms.Button Number8;
		private System.Windows.Forms.Button Number7;
		private System.Windows.Forms.Button Number6;
		private System.Windows.Forms.Button Number5;
		private System.Windows.Forms.Button ButtonEqual;
		private System.Windows.Forms.Button ButtonDivide;
		private System.Windows.Forms.Button ButtonMultiply;
		private System.Windows.Forms.Button ButtonPlus;
		private System.Windows.Forms.Button ButtonBackspace;
		private System.Windows.Forms.Button ButtonDelete;
		private System.Windows.Forms.Button ButtonBracketOpen;
		private System.Windows.Forms.Button ButtonBracketClose;
		private System.Windows.Forms.Label Equation;
		private System.Windows.Forms.Button ButtonMinus;
		private System.Windows.Forms.Label Answer;
	}
}

