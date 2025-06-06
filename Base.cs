using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;

namespace Calculator
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        public object EvaluateMathExpression(string expression)
        {
            var options = ScriptOptions.Default
                .WithImports("System", "System.Math")
                .WithReferences(typeof(Math).Assembly);

            return CSharpScript.EvaluateAsync(expression, options).Result;
        }

        public void CleanButton_Click(object sender, EventArgs e)
        {
            this.textTextBox.Text = "0";
        }

        public void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textTextBox.Text;

                // Заміна символу π на Math.PI
                expression = expression.Replace("π", "Math.PI");

                expression = expression.Replace(",", ".");

                // Корінь: √(9+16) → Math.Sqrt(9+16)
                expression = Regex.Replace(expression, @"√\(([^()]+)\)", "Math.Sqrt($1)");
                expression = Regex.Replace(expression, @"√(\d+(?:[\.,]\d+)?)", "Math.Sqrt($1)");

                // Степінь: (2+1)^3 → Math.Pow((2+1),3)
                expression = Regex.Replace(expression, @"(\([^()]+\)|\d+(?:[\.,]\d+)?)\^(\([^()]+\)|\d+(?:[\.,]\d+)?)", "Math.Pow($1,$2)");

                

                // Обчислення виразу через C# Eval (DataTable не виконає Math.Pow/Sqrt)
                var result = EvaluateMathExpression(expression);

                // Відображення результату
                textTextBox.Text = result.ToString().Replace(".", ",");
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильний вираз. Перевірте введення.");
            }
        }

        public void AddTextToTextBox(string text)
        {

            string current = this.textTextBox.Text;
            char lastChar = current[current.Length - 1];
            bool isOperator = text == "+" || text == "-" || text == "*" || text == "/";
            bool isDigit = char.IsDigit(text, 0);
            bool isMathSing = text == "π" || text == "√" || text == "^";

            if (current == "0")
            {
                if (isOperator)
                {
                    this.textTextBox.Text += text;
                    return;
                }

                if (text == ",")
                {
                    this.textTextBox.Text = "0,";
                    return;
                }

                if (text == "(")
                {
                    this.textTextBox.Text = text;
                    return;
                }

                if (text == "^") return;

                if (text == ")") return;

                this.textTextBox.Text = text;
                return;
            }

            // Ділення на нуль
            if (lastChar == '/' && text == "0")
            {
                MessageBox.Show("Ділення на нуль неможливе");
                return;
            }

            // Не дозволяємо подвійні оператори
            if (isOperator)
            {
                if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    return;
                }

                if (lastChar == '(' && !(text == "-" || isDigit))
                {
                    return;
                }

                this.textTextBox.Text += text;
                return;
            }

            // Не дозволяємо подвійні математичні символи
            if (isMathSing)
            {
                if (lastChar == '^' || lastChar == 'π' || lastChar == '√')
                {
                    return;
                }
                this.textTextBox.Text += text;
                return;
            }

                // Перевірка на дужки
                if (text == "(")
            {
                // Якщо перед дужкою число, число пі або закриваюча дужка, не можна ставити відкриту дужку
                if (char.IsDigit(lastChar) || lastChar == ')' || lastChar == 'π')
                {
                    return;
                }

                this.textTextBox.Text += text;
                return;
            }

            if (text == ")")
            {
                // Після оператора не можна ставити закриваючу дужку
                if (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/')
                {
                    return;
                }

                // Перевірка балансу дужок
                int openCount = current.Count(c => c == '(');
                int closeCount = current.Count(c => c == ')');

                if (closeCount >= openCount)
                {
                    return;
                }

                this.textTextBox.Text += text;
                return;
            }

            // Десяткова крапка
            if (text == ",")
            {
                int lastOpIndex = Math.Max(current.LastIndexOf('+'),
                                    Math.Max(current.LastIndexOf('-'),
                                    Math.Max(current.LastIndexOf('*'),
                                             current.LastIndexOf('/'))));

                string lastNumber = lastOpIndex == -1 ? current : current.Substring(lastOpIndex + 1);

                if (lastNumber.Contains(","))
                {
                    return;
                }
            }

            // Перевірка на заборону написання степеня
            if (text == "^" && (lastChar == '+' || lastChar == '-' || lastChar == '*' || lastChar == '/' || lastChar == '('))
            {
                return;
            }
            // Перевірка на заборону написання кореня та числа пі
            if ((text == "π" || text == "√" ) && (char.IsDigit(lastChar) || lastChar == ')'))
            {
                return;
            }

            this.textTextBox.Text += text;
        }


    }
}
    

