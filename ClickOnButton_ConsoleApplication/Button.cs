using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ClickOnButton_ConsoleApplication
{
    class Button
    {
        public delegate void Clickhandler();        // ist ein Typ, deswegen groß geschrieben
        public event Clickhandler OnClick; // = new Clickhandler(() => { });

        public Button()
        {
            OnClick += click_recieved;
            OnClick += changeColorAfterClick;
        }

        public void click_recieved()
        {
            WriteLine("Click wurde erkannt");
        }

        public void changeColorAfterClick()
        {
            WriteLine("Der Button wurd kurz eingedrückt dargestellt");
        }
    }
}
