using Microsoft.AspNetCore.Components;

namespace Workshop8.Components.Pages
{
    public partial class CalculatorPartial : ComponentBase
    {
        private double Number1 { get; set; }
        private double Number2 { get; set; }
        private double Result { get; set; }

        private void Add() => Result = Number1 + Number2;
        private void Subtract() => Result = Number1 - Number2;
        private void Multiply() => Result = Number1 * Number2;
        private void Divide()
        {
            if (Number2 != 0)
                Result = Number1 / Number2;
            else
                Result = 0;
        }
    }
}
