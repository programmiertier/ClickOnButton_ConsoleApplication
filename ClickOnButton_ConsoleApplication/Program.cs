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
            Button kleinerButton = new Button("Button 1");
            // kleinerButton.OnClick += new Button.Clickhandler(() => { });

            // Hier soll ein Knopf gedrückt werden
            // OnClick() Darf nicht direkt angeesprochen werden!
            /* kleinerButton.click(ConsoleColor.Blue);
            ReadLine();
            Button zweiterKnopf = new Button("zweiterKnopf");
            zweiterKnopf.click(ConsoleColor.Yellow);
            ReadLine(); */
            Button zweiterKnopf = new Button("Button 2");
            kleinerButton.OnClick += new Button.Clickhandler(() => { ForegroundColor = ConsoleColor.Green; });
            kleinerButton.click(kleinerButton);

            zweiterKnopf.OnClick += new Button.Clickhandler(() => { ForegroundColor = ConsoleColor.Yellow; });
            zweiterKnopf.click(zweiterKnopf);

            ReadLine();
        }
    }
}
