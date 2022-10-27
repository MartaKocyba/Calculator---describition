//
using System;


double liczba1, liczba2; //tutaj wprowadzamy sobie zmienne. Double ma sens przy liczbach, bo pozwala nam na liczby i wyniki ktore maja cos po przecinku a nie sa liczba calkowita
bool sukces; //bool to okreslenie dla wartosci logicznej "true or false", czyli sa tylko dwie mozliwosci - albo cos zadziala albo nie
int dzialanie; //dzialanie to numerek wybranego dzialania wiec wystarczy nam int. bo nie bedzie nic po przecinku

System.Console.OutputEncoding = System.Text.Encoding.UTF8; //tu mamy fragment ktory pozwoli na powtorzenie loopa gdy ktos wpisze np. literke zamiast liczby
Console.WriteLine("Kalkulator prosty\n");

do
{
    Console.Write("Podaj pierwszą liczbę: ");
    sukces = double.TryParse(Console.ReadLine(), out liczba1); //stad mamy sukces, jesli zajdzie, to przechodzimy dalej, jesli nie to loop zapyta ponownie o wpisanie 1 liczby
}
while (!sukces);

do
{
    Console.Write("Podaj drugą liczbę: ");
    sukces = double.TryParse(Console.ReadLine(), out liczba2); //to samo co wyzej
}
while (!sukces);


Console.WriteLine("\n1. Dodawanie"); //tutaj oczywiscie mamy nasze pozycje do wyboru dzialania. \n1 daje nam przejscie do nastepnej linijki od wypisanych liczb zeby ladnie to wygladalo
Console.WriteLine("2. Odejmowanie");
Console.WriteLine("3. Mnożenie");
Console.WriteLine("4. Dzielenie");
Console.WriteLine("5. Procenty");
Console.WriteLine("6. Do kwadratu");
Console.WriteLine("7. Pierwiastkowanie\n"); // i tak samo \n daje nam linijke odstepu przed kolejnym komunikatem


do
{
    Console.Write("Wybierz działanie od 1 do 7: ");
    sukces = int.TryParse(Console.ReadLine(), out dzialanie); //znow mamy zmienna sukces, ktora potworzy loopa jesli wpiszemy literke lub cyfre ktora nie jest 1-7...
}
while ((dzialanie < 1) || (dzialanie > 7)); // ...czyli nie jest naszymi opcjami dzialania do wyboru

switch (dzialanie){ //tutaj zaczynaja sie funkcje ktore wykonuja dane dzialania, ja uzylam switch i case'ow, choc mozna tez if'ami, ale case wg mnie sa lepsze ;)
    case 1:
        {
            Console.WriteLine($"Wynik: {liczba1} + {liczba2} = " + (liczba1 + liczba2)); //znak $ przed Wynikiem i liczby w klamrach to tylko element kosmetyczny, ktory pozwala na wyswietlenie dzialania w jedenj linijce
            break;
        }
    case 2:
        {
            Console.WriteLine($"Wynik: {liczba1} - {liczba2} = " + (liczba1 - liczba2));
            break;
        }
    case 3:
        {
            Console.WriteLine($"Wynik: {liczba1} * {liczba2} = " + (liczba1 * liczba2));
            break;
        }
    case 4:
        {
            if (liczba2 == 0) Console.WriteLine("Nie można dzielić przez 0."); //tutaj mamy if, ktory zapobiega nam dzieleniu przez 0. Jesli ktos wybierze takie liczby, program zamknie sie
            else Console.WriteLine($"Wynik: {liczba1} / {liczba2} = " + (liczba1 / liczba2));
            break;
        }
    case 5:
        {
            Console.WriteLine($"Wynik: {liczba1}% z {liczba2} = " + (liczba1 * liczba2 / 100 ));
            break;
        }
    case 6:
        {
            int wybor; //wprowadzamy sobie zmienna "wybor"
            do
            {
                Console.Write("Której liczby chcesz użyć (1 lub 2)? ");
                sukces = int.TryParse(Console.ReadLine(), out wybor); //znow mamy funkcje tryparse tylko z int, bo wybor tez moze byc jedynie 1 lub 2, a nie liczby po przecinku.
                // funkcja ta, znow chroni nas przed wpisaniem jakiejs literki zamiast liczb
            }
            while ((wybor != 1) && (wybor != 2)); //tutaj mamy loop ktory nie pozwala na wpisanie innych liczb niz 1 lub 2. Zrobione jest to z funkcja && -and, a nie ||-or tak jak poprzednio...
           //poniewaz funkcja or zadziala jesli tylko jeden bedzie spelniony, wiec po wpisaniu 1, zadzialaloby ze ma sie NIE rownac 2 i na odwrot, co skutkuje powtorka loopa.
            if (wybor == 1)
                Console.WriteLine($"Wynik: {liczba1}\u00b2 = " + (liczba1 * liczba1)); // wyrazenie \u00b2 pozwala na zapisanie symbolu "do kwadratu"
            if (wybor == 2)
                Console.WriteLine($"Wynik: {liczba2}\u00b2 = " + (liczba2 * liczba2));
            break;
        }
    case 7:
        {
            int wybor;
            do
            {
                Console.Write("Której liczby chcesz użyć (1 lub 2)? ");
                sukces = int.TryParse(Console.ReadLine(), out wybor); //znow tryparse chroniace nas przed wpisywaniem literek 
            }
            while ((wybor != 1) && (wybor != 2)); //znow powtarzamy funkcje z wybieraniem tylko opcji 1 lub 2, a nie zadnej innej liczby
            if (wybor == 1)
                Console.WriteLine($"Wynik: \u221A{liczba1} = " + (Math.Sqrt(liczba1))); // wyrazenie \u221A pozwala na zapisanie symbolu pierwiastka
            if (wybor == 2)
                Console.WriteLine($"Wynik: \u221A{liczba2} = " + (Math.Sqrt(liczba2)));
            break;
        }
}
Console.WriteLine("Naciśnij dowolny klawisz by zamknąć program..."); 
Console.ReadKey(); //ostatnia funkcja, ktora pozwala na zczytanie dowolnego klawisza w celu zamkniecia aplikacji

