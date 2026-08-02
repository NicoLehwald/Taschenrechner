namespace Taschenrechner
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=================================\r\n        Taschenrechner\r\n=================================");
           
            Console.WriteLine("Bitte geben Sie die erste Zahl ein.");
            string ersteEingabe = Console.ReadLine();

            double ersteZahl = Convert.ToDouble(ersteEingabe);

            Console.WriteLine("Bitte geben Sie die zweite Zahl ein.");
            string zweiteEingabe = Console.ReadLine();

            double zweiteZahl = Convert.ToDouble(zweiteEingabe);

            Console.WriteLine("Bitte geben Sie die gewünschte Operation (+,-,*,/) ein.");
            string operation = Console.ReadLine();

            double ergebnis;

            switch(operation) 
            {
                case "+":
                   ergebnis =  ersteZahl + zweiteZahl;
                    break;
                case "-":
                    ergebnis = ersteZahl - zweiteZahl;
                    break;
                case "*":
                    ergebnis = ersteZahl * zweiteZahl;
                    break;
                case "/":
                    ergebnis = ersteZahl / zweiteZahl;
                    break;
                default:
                    Console.WriteLine("Die Eingabe ist ungültig. Es wurde eine falsche Operation ausgewählt. Bitte wiederholen Sie den Vorgang erneut.");
                    ergebnis = 0;
                    break;
            }

            Console.WriteLine("Das Ergebnis der Operation lautet: " + ergebnis);

        }
    }
}
