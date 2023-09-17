

using System.Diagnostics.CodeAnalysis;
Console.ResetColor();
long total = 0;
string saveNumbers = ""; //Här sparar jag de numrerna som ska summeras, alltså de grönmarkerade
string saveFirstIndex = "";// Här ska då första delen av strängen sparas, dvs innan det grönmarkerade
string saveLastIndex = "";// Här sparas sista delen av strängen dvs efter det grönmarkerade


while (true) //Gjorde while loop mer för att slippa avsluta för att skriva in ny strings
{
    Console.WriteLine("");
    Console.WriteLine("Skriv in siffror och bokstäver");
    string inputString = Console.ReadLine();
    Console.WriteLine("");
    
    for (int i = 0; i < inputString.Length; i++) //Kolla igenom strängen som blivit inskriven och 
    {
        for (int j = i + 1; j < inputString.Length; j++) // Kollar de efterföljande tecken efter [i] värdet är kollat
        {
            if (!Char.IsDigit(inputString[j])) //Kollar om det är en siffra, om inte så bryter den och fortsätter med nästa tecken
            {
                break;
            }

            if (inputString[i] == inputString[j]) //Kollar om j loopens siffra är likadan som [i] och i så
            {
                if (inputString[i] == inputString[j - 1]) //Om två siffror är efter varandra precis och är lika så avbryts 
                {
                    break;
                }
                saveNumbers = inputString.Substring(i, j - i + 1); //här sparas de siffrorna som ska grönmarkers och beräknas

                long sum = 0;
                long.TryParse(saveNumbers, out sum);
                total += sum;
                saveFirstIndex = inputString.Substring(0, i); //delsträng som första numret sparas i
                saveLastIndex = inputString.Substring(j + 1, inputString.Length - j - 1); // delsträng där sista delen av stringen sparas dvs utanför den grönmarkerade delen

                Console.Write(saveFirstIndex);
                Console.ForegroundColor = ConsoleColor.Green; //grönmarkerade siffrorna
                Console.Write(saveNumbers); //Skriver ut de grönmarkerad substrängarna
                Console.ResetColor(); //återställer till vit färg
                Console.WriteLine(saveLastIndex); //Skriver ut sista delen av strängen 
                break;

            }
        }
    }
    Console.WriteLine(); 
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write($"Sum of all highlighted numbers: " + total); // Skriver ut totala summan av de grönmarkerade siffrorna
    Console.ResetColor();
}