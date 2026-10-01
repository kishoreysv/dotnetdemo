using System;
using System.Windows.Forms;

namespace DotnetCalc;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        
        var form = new Form { Text = "Calculator", Width = 300, Height = 250 };
        
        var input1 = new TextBox { Top = 20, Left = 20, Width = 200, PlaceholderText = "Enter first number" };
        var input2 = new TextBox { Top = 60, Left = 20, Width = 200, PlaceholderText = "Enter second number" };
        
        var btnAdd = new Button { Text = "+", Top = 100, Left = 20, Width = 50 };
        var btnSubtract = new Button { Text = "-", Top = 100, Left = 80, Width = 50 };
        
        var lblResult = new Label { Text = "Result: ", Top = 150, Left = 20, Width = 250 };

        var engine = new CalculatorEngine();

        void ExecuteMath(string operation)
        {
            double a = double.Parse(input1.Text);
            double b = double.Parse(input2.Text);
            
            double result = engine.Calculate(a, b, operation);
            lblResult.Text = $"Result: {result}";
        }

        btnAdd.Click += (sender, e) => ExecuteMath("+");
        btnSubtract.Click += (sender, e) => ExecuteMath("-");

        form.Controls.Add(input1);
        form.Controls.Add(input2);
        form.Controls.Add(btnAdd);
        form.Controls.Add(btnSubtract);
        form.Controls.Add(lblResult);

        Application.Run(form.Show());
    }
}