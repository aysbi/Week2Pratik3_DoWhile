Console.Write("Lutfen bir limit sayi giriniz: ");
int Limit = int.Parse(Console.ReadLine());

int sayac = 0;

Console.WriteLine("While dongusu: ");

while (sayac <= Limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}

Console.WriteLine("Do_While dongusu: ");

do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
} while (sayac <= Limit);  

// While dongusu do_while aksine -5 degerinde calismadi cunku once kosulu kontrol etti
// do while dongusu ise ilk once 1 kere calisir 
// daha sonra kosulu kontrol eder