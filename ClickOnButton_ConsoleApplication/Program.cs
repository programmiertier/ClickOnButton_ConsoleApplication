using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClickOnButton_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Button kleinerButton = new Button();
            kleinerButton.OnClick += new Button.Clickhandler(() => { WriteLine("noch was tun"); });

            // Hier soll ein Knopf gedrückt werden
            // OnClick() Darf nicht direkt angeesprochen werden!
            kleinerButton.click(ForegroundColor);
            

            Button zweiterKnopf = new Button();
            zweiterKnopf.click(ForegroundColor);
            

            ReadLine();
        }
    }
}
