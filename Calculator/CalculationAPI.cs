using System;
using System.Windows.Forms;

namespace Calculator
{
	public class CalculationAPI
	{
		public string Calculate(string Answer)
		{
			double[] Number = new double[1000];
			char[] Operation = new char[1000];
			string Text = Answer, TempNumber = "", FirstNumber = "", LastNumber = "", BracketText, BracketAnswer;
			int PlaceCounter = 0, ActionCounter = 0, OperatorIndex = 0, NumberIndex = 0, InsertFirstIndex = 0, InsertLastIndex = 0, BracketOpenIndex = 0, BracketCloseIndex = 0, BracketsOpen = 0; ;
			bool FirstNumberUsed = false, GettingBracketCloseIndex = true;
			double TempAnswer = 0;

			#region Brackets
			while (Text.Contains("(") && Text.Contains(")"))
			{
				BracketOpenIndex = Text.IndexOf('(');
				while (GettingBracketCloseIndex)
				{
					for (int i = 0; i < Text.Length; i++)
					{
						if (Text[i] == '(')
						{
							BracketsOpen++;
						}
						else if (Text[i] == ')')
						{
							BracketsOpen--;
							if (BracketsOpen == 0)
							{
								BracketCloseIndex = i;
								GettingBracketCloseIndex = false;
								break;
							}
						}
					}
				}
				GettingBracketCloseIndex = true;
				BracketText = Text.Substring(BracketOpenIndex + 1, BracketCloseIndex - 1 - BracketOpenIndex);
				CalculationAPI Calculate = new CalculationAPI();
				BracketAnswer = Calculate.Calculate(BracketText);
				Text = Text.Insert(BracketOpenIndex, BracketAnswer);
				Text = Text.Remove(BracketOpenIndex + BracketAnswer.Length, BracketCloseIndex - BracketOpenIndex + 1);
			}
			#endregion

			#region Multiply and Divide
			while (Text.Contains("×") || Text.Contains("÷"))
			{
				if (!Text.Contains("×"))
				{
					OperatorIndex = Text.IndexOf('÷');
				}
				else if (!Text.Contains("÷"))
				{
					OperatorIndex = Text.IndexOf('×');
				}
				else
				{
					OperatorIndex = Math.Min(Text.IndexOf('×'), Text.IndexOf('÷'));
				}
				NumberIndex = OperatorIndex;
				while (NumberIndex - 1 >= 0 && Text[NumberIndex - 1] != '+' && Text[NumberIndex - 1] != '–' && Text[NumberIndex - 1] != '×' && Text[NumberIndex - 1] != '÷')
				{
					FirstNumber = Text[NumberIndex - 1] + FirstNumber;
					NumberIndex--;
				}
				InsertFirstIndex = NumberIndex;
				NumberIndex = OperatorIndex;
				while (NumberIndex + 1 < Text.Length && Text[NumberIndex + 1] != '+' && Text[NumberIndex + 1] != '–' && Text[NumberIndex + 1] != '×' && Text[NumberIndex + 1] != '÷')
				{
					LastNumber += Text[NumberIndex + 1];
					NumberIndex++;
				}
				InsertLastIndex = NumberIndex;
				switch (Text[OperatorIndex])
				{
					case '×':
						TempAnswer = Double.Parse(FirstNumber) * Double.Parse(LastNumber);
						break;
					default:
						if (Double.Parse(LastNumber) != 0)
						{
							TempAnswer = Double.Parse(FirstNumber) / Double.Parse(LastNumber);
						}
						else
						{
							MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return "Error";
						}
						break;
				}
				Text = Text.Insert(InsertFirstIndex, TempAnswer.ToString());
				Text = Text.Remove(InsertFirstIndex + TempAnswer.ToString().Length, InsertLastIndex - InsertFirstIndex + 1);
				TempAnswer = 0;
				FirstNumber = "";
				LastNumber = "";
			}
			#endregion

			#region Plus and Minus
			if (Answer.Contains("+") || Answer.Contains("–"))
			{
				for (int i = 0; i < Text.Length; i++)
				{
					if (Text[i] == '+' || Text[i] == '–')
					{
						Operation[PlaceCounter] = Text[i];
						Number[PlaceCounter] = Double.Parse(TempNumber);
						PlaceCounter++;
						ActionCounter++;
						TempNumber = "";
					}
					else
					{
						TempNumber += Text[i];
						if (Text.Length - 1 == i)
						{
							Number[PlaceCounter] = Double.Parse(TempNumber);
							TempNumber = "";
						}
					}
				}
				for (int i = 0; i < ActionCounter; i++)
				{
					switch (Operation[i])
					{
						case '+':
							if (!FirstNumberUsed)
							{
								TempAnswer = Number[0] + Number[i + 1];
								FirstNumberUsed = true;
							}
							else
							{
								TempAnswer += Number[i + 1];
							}
							break;
						case '–':
							if (!FirstNumberUsed)
							{
								TempAnswer = Number[0] - Number[i + 1];
								FirstNumberUsed = true;
							}
							else
							{
								TempAnswer -= Number[i + 1];
							}
							break;
					}
				}
			}
			else
			{
				TempAnswer = Double.Parse(Text);
			}
			#endregion

			return TempAnswer.ToString();
		}
	}
}