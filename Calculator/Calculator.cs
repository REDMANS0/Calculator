using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Calculator : Form
	{
		public uint BracketsOpen = 0;
		public int TempNumberIndex;
		public string TempNumber = "";

		public Calculator()
		{
			InitializeComponent();
		}

		#region Number Click
		private void Number0_Click(object sender, EventArgs e)
		{
			Number("0");
		}

		private void Number1_Click(object sender, EventArgs e)
		{
			Number("1");
		}

		private void Number2_Click(object sender, EventArgs e)
		{
			Number("2");
		}

		private void Number3_Click(object sender, EventArgs e)
		{
			Number("3");
		}

		private void Number4_Click(object sender, EventArgs e)
		{
			Number("4");
		}

		private void Number5_Click(object sender, EventArgs e)
		{
			Number("5");
		}

		private void Number6_Click(object sender, EventArgs e)
		{
			Number("6");
		}

		private void Number7_Click(object sender, EventArgs e)
		{
			Number("7");
		}

		private void Number8_Click(object sender, EventArgs e)
		{
			Number("8");
		}

		private void Number9_Click(object sender, EventArgs e)
		{
			Number("9");
		}

		private void Number(string Number)
		{
			if (Equation.Text != "")
			{
				if (Equation.Text[Equation.Text.Length - 1] != ')')
				{
					Equation.Text += Number;
				}
			}
			else
			{
				Equation.Text += Number;
			}
		}
		#endregion

		#region Action Click
		private void ButtonEqual_Click(object sender, EventArgs e)
		{
			if (Equation.Text != "")
			{
				if (BracketsOpen == 0)
				{
					if (Equation.Text[Equation.Text.Length - 1] != '+' && Equation.Text[Equation.Text.Length - 1] != '–' && Equation.Text[Equation.Text.Length - 1] != '×' && Equation.Text[Equation.Text.Length - 1] != '÷' && Equation.Text[Equation.Text.Length - 1] != '.' && Equation.Text[Equation.Text.Length - 1] != '-')
					{
						CalculationAPI Calculate = new CalculationAPI();
						if (Calculate.Calculate(Equation.Text) != "Error")
						{
							Answer.Text = Calculate.Calculate(Equation.Text);
						}
					}
					else
					{
						MessageBox.Show("Incorrect input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Brackets missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void ButtonPlus_Click(object sender, EventArgs e)
		{
			Operation("+");
		}

		private void ButtonMinus_Click(object sender, EventArgs e)
		{
			Operation("–");
		}

		private void ButtonMultiply_Click(object sender, EventArgs e)
		{
			Operation("×");
		}

		private void ButtonDivide_Click(object sender, EventArgs e)
		{
			Operation("÷");
		}

		private void Operation(string Operator)
		{
			if (Equation.Text != "")
			{
				if (Equation.Text[Equation.Text.Length - 1] != '(' && Equation.Text[Equation.Text.Length - 1] != '.' && Equation.Text[Equation.Text.Length - 1] != '-' && Equation.Text[Equation.Text.Length - 1] != '+' && Equation.Text[Equation.Text.Length - 1] != '–' && Equation.Text[Equation.Text.Length - 1] != '×' && Equation.Text[Equation.Text.Length - 1] != '÷')
				{
					Equation.Text += Operator;
				}
			}
		}
		#endregion

		#region Delete Action Click
		private void ButtonBackspace_Click(object sender, EventArgs e)
		{
			if (Equation.Text != "")
			{
				if (Equation.Text[Equation.Text.Length - 1] == '(')
				{
					BracketsOpen--;
				}
				else if (Equation.Text[Equation.Text.Length - 1] == ')')
				{
					BracketsOpen++;
				}
				Equation.Text = Equation.Text.Remove(Equation.Text.Length - 1, 1);
			}
		}

		private void ButtonDelete_Click(object sender, EventArgs e)
		{
			if (Equation.Text != "")
			{
				Equation.Text = "";
				BracketsOpen = 0;
				Equation.Font = new Font(Equation.Font.Name, 25, FontStyle.Bold);
			}
			else if (Equation.Text == "")
			{
				Answer.Text = "";
			}
		}
		#endregion

		#region Bracket Click
		private void ButtonBracketOpen_Click(object sender, EventArgs e)
		{
			if (Equation.Text != "")
			{
				if (Equation.Text[Equation.Text.Length - 1] == '+' || Equation.Text[Equation.Text.Length - 1] == '–' || Equation.Text[Equation.Text.Length - 1] == '×' || Equation.Text[Equation.Text.Length - 1] == '÷')
				{
					Equation.Text += "(";
					BracketsOpen++;
				}
			}
			else
			{
				Equation.Text += "(";
				BracketsOpen++;
			}
		}

		private void ButtonBracketClose_Click(object sender, EventArgs e)
		{
			if (Equation.Text != "")
			{
				if (Equation.Text[Equation.Text.Length - 1] != '+' && Equation.Text[Equation.Text.Length - 1] != '–' && Equation.Text[Equation.Text.Length - 1] != '×' && Equation.Text[Equation.Text.Length - 1] != '÷' && Equation.Text[Equation.Text.Length - 1] != '(' && Equation.Text[Equation.Text.Length - 1] != '-' && Equation.Text[Equation.Text.Length - 1] != '.')
				{
					if (BracketsOpen > 0)
					{
						Equation.Text += ")";
						BracketsOpen--;
					}
				}
			}
		}
		#endregion

		#region Dot And Minus Click
		private void ButtonDot_Click(object sender, EventArgs e)
		{
			if (Equation.Text != "")
			{
				if (Equation.Text[Equation.Text.Length - 1] == '0' || Equation.Text[Equation.Text.Length - 1] == '1' || Equation.Text[Equation.Text.Length - 1] == '2' || Equation.Text[Equation.Text.Length - 1] == '3' || Equation.Text[Equation.Text.Length - 1] == '4' || Equation.Text[Equation.Text.Length - 1] == '5' || Equation.Text[Equation.Text.Length - 1] == '6' || Equation.Text[Equation.Text.Length - 1] == '7' || Equation.Text[Equation.Text.Length - 1] == '8' || Equation.Text[Equation.Text.Length - 1] == '9')
				{
					TempNumberIndex = Equation.Text.Length - 1;
					while (TempNumberIndex >= 0 && Equation.Text[TempNumberIndex] != '+' && Equation.Text[TempNumberIndex] != '–' && Equation.Text[TempNumberIndex] != '×' && Equation.Text[TempNumberIndex] != '÷' && Equation.Text[TempNumberIndex] != '(' && Equation.Text[TempNumberIndex] != ')')
					{
						TempNumber = Equation.Text[TempNumberIndex] + TempNumber;
						TempNumberIndex--;
					}
					if (!TempNumber.Contains("."))
					{
						Equation.Text += ".";
					}
				}
			}
		}

		private void ButtonNumberMinus_Click(object sender, EventArgs e)
		{
			if (Equation.Text != "")
			{
				if (Equation.Text[Equation.Text.Length - 1] == '+' || Equation.Text[Equation.Text.Length - 1] == '–' || Equation.Text[Equation.Text.Length - 1] == '×' || Equation.Text[Equation.Text.Length - 1] == '÷' || Equation.Text[Equation.Text.Length - 1] == '(')
				{
					Equation.Text += "-";
				}
			}
			else
			{
				Equation.Text += "-";
			}
		}
		#endregion

		#region Label
		private void Equation_TextChanged(object sender, EventArgs e)
		{
			Equation.Focus();
			for (int i = 0; i < 13; i++)
			{
				if (Equation.Text.Length == 14 + i)
				{
					Equation.Font = new Font(Equation.Font.Name, 24 - i, FontStyle.Bold);
				}
			}
		}
		#endregion

		#region Keyboard Press
		private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar.ToString())
			{
				case "0":
					Number("0");
					break;
				case "1":
					Number("1");
					break;
				case "2":
					Number("2");
					break;
				case "3":
					Number("3");
					break;
				case "4":
					Number("4");
					break;
				case "5":
					Number("5");
					break;
				case "6":
					Number("6");
					break;
				case "7":
					Number("7");
					break;
				case "8":
					Number("8");
					break;
				case "9":
					Number("9");
					break;
				case "+":
					Operation("+");
					break;
				case "-":
					Operation("–");
					break;
				case "*":
					Operation("×");
					break;
				case "/":
					Operation("÷");
					break;
				case ".":
					ButtonDot.PerformClick();
					break;
				case "_":
					ButtonNumberMinus.PerformClick();
					break;
				case "(":
					ButtonBracketOpen.PerformClick();
					break;
				case ")":
					ButtonBracketClose.PerformClick();
					break;
				case "=":
					ButtonEqual.PerformClick();
					break;
				case "?":
					AboutPage AboutPage = new AboutPage();
					AboutPage.Show();
					this.Hide();
					break;
			}
		}
		private void Calculator_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyData)
			{
				case Keys.Enter:
					ButtonEqual.PerformClick();
					break;
				case Keys.Back:
					ButtonBackspace.PerformClick();
					break;
				case Keys.Delete:
					ButtonDelete.PerformClick();
					break;
			}
		}
		#endregion

		#region Form Closing
		private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
		#endregion
	}
}