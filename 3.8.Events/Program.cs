using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();
            CalculatorButton calcBtn = new CalculatorButton();
            // Atribute a method to be called when the event is triggered
            calcBtn.Clicked += prg.CalculatorBtnClicked;
            // Simulate Click
            calcBtn.SimulateClick();
            Console.ReadKey();
        }

        // Method that is called for the event
        public void CalculatorBtnClicked(object sender, MyButtonClickEventArgs e)
        {
            Console.WriteLine($"Caller is a CalculatorButton: {sender is CalculatorButton} and it is named {e.Name}");
        }
    }
    public class CalculatorButton
    {
        public event EventHandler<MyButtonClickEventArgs> Clicked;

        // Create to simulate the UI click
        public void SimulateClick()
        {
            // Make sure that methods is assigned to the event
            if (Clicked != null)
            {
                MyButtonClickEventArgs args = new MyButtonClickEventArgs();
                args.Name = "MyButton";

                Clicked(this, args);
            }
        }
    }

    // Custom EventArgs
    public class MyButtonClickEventArgs : EventArgs
    {
        internal string Name { get; set; }
    }
}
