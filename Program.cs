
Double readNumberFromUser()
{
    Double number;
    string input;
    input = Console.ReadLine();
    if (!Double.TryParse(input, out number))
    {
        do
        {
            Console.WriteLine("Sie haben keine Zahl eingegeben!");
            Console.WriteLine("Geben Sie bitte eine gültige Zahl ein:");
            input = Console.ReadLine();
        } while (Double.TryParse(input, out number));
    }
    return number;
}

while (true)
{
    Console.Clear();
    int operation;
    Console.WriteLine("Taschenrechner");
    Console.WriteLine("---------------");
    Console.WriteLine("Optionen:");
    Console.WriteLine("1) Addition");
    Console.WriteLine("2) Subtraktion");
    Console.WriteLine("---------------");
    do
    {
        operation = (int)readNumberFromUser();
        if(operation != 1 && operation != 2)
        {
            Console.WriteLine("Die Eingabe ist ungültig!");
            Console.WriteLine("Geben Sie eine gültige Operation ein:");
        }
    } while (operation != 1 && operation != 2);
    Console.WriteLine("Geben Sie die erste Zahl ein:");
    Double number1 = readNumberFromUser();
    Console.WriteLine("Geben Sie die zweite Zahl ein:");
    Double number2 = readNumberFromUser();
    Double result = 0;
    if(operation == 1)
    {
        result = number1 + number2;
    }
    else if(operation == 2)
    {
        result = number1 - number2;
    }
    Console.WriteLine("Das Resultat ist: {0:F}", result);
    Console.WriteLine("");
    Console.WriteLine("Drücken Sie eine beliebige Taste um erneut zu rechnen.");
    Console.ReadKey();
}