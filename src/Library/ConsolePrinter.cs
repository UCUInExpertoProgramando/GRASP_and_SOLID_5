using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {
        public void PrintRecipe(ITextProvider textProvider)
        {   
            string  textToPrint = textProvider.GetTextToPrint();
            Console.WriteLine(textToPrint);
        }
    }
}