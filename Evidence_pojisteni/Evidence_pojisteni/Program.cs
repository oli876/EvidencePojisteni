// See https://aka.ms/new-console-template for more information

using Evidence_pojisteni;

//instance Evidence pojištění
Evidence evidence = new Evidence();
char volba = '0';

//Hlavní cyklus
while(volba != '4')
{
    evidence.VypisHlavicku();
    Console.WriteLine();
    Console.WriteLine("Vyberte si  akci: ");
    Console.WriteLine("1 - Přidat nového pojisteného");
    Console.WriteLine("2 - Vypsat vsechny pojistené");
    Console.WriteLine("3 - Vyhledat pojisteneho");
    Console.WriteLine("4 - Konec");
    
    volba = Console.ReadKey().KeyChar;
    Console.WriteLine();
    Console.WriteLine();

    //Reakce na volbu
    switch(volba)
    {
        case '1':
            evidence.PridejPojisteny();
            break;
        case '2':
            evidence.databaze.VypisPojisteny();
            break;
        case '3':
            evidence.VyhledejPojisteny();
            break;
        case '4':
            Console.WriteLine("Libovolnou klávesou ukončíte program.");
            break;
        default:
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Neplatná volba, opakujte zadání!!!");
            Console.WriteLine("----------------------------------");
            Console.ReadKey();
            break;
    }
    Console.WriteLine();

}
Console.ReadKey();
