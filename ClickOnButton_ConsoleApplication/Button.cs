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
                // event ist abgeleitet von delegate        
                // static! sonst,wird OnClick in der Program.cs angeboten

        public Button()
        {
            OnClick += click_recieved;
            OnClick += changeColorAfterClick;
            WriteLine("Knopf erstellt");
        }

        public void click()
        {
            OnClick();      // muss in einer Methode aufgerufen werden, darf sonst nicht angesprochen werden
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
