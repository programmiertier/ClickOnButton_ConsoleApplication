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
        public string name;
        private delegate void temp();
        public Button(string nam)
        {
            name = nam;
            OnClick += click_recieved;
            OnClick += changeColorAfterClick;

            Delegate[] aufrufListe = OnClick.GetInvocationList();       // alle vorhandenen
            OnClick = new Clickhandler(() => { });
            
            OnClick += (Clickhandler)aufrufListe[0];
            OnClick += (Clickhandler)aufrufListe[1];

            WriteLine("Knopf erstellt");
        }

        public void click(Button sender)
        {
            WriteLine("der Knopf {0} ", sender.name);
            OnClick();
        }

        /* public void click(ConsoleColor neueFarbe)
        {
            ConsoleColor temp = ForegroundColor;
            ForegroundColor = neueFarbe;
            OnClick();      // muss in einer Methode aufgerufen werden, darf sonst nicht angesprochen werden
            ForegroundColor = temp;
        }   */

        public void click_recieved()
        {
            WriteLine("Click wurde erkannt");
        }

        public void changeColorAfterClick()
        {
            WriteLine("Der Button wird kurz eingedrückt dargestellt");
        }
    }
}
