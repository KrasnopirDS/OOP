using OOP_Lab2;
using static System.Runtime.InteropServices.JavaScript.JSType;



// -------------Zdania 1-----------start
Licz licz1 = new Licz(5);
Licz licz2 = new Licz(8);

licz1.Dodaj(5);
licz2.Dodaj(8);

licz1.Odejm(8);
licz2.Odejm(10);

licz1.StanValue();
licz2.StanValue();



// -------------Zdania 1-----------end


// -------------Zdania 2-----------start



/*
Sumator tablica = new Sumator();
double[] newTabl = tablica.Tablica(liczby_konstr: [1, 5, 3, 6, 5]);
Console.WriteLine($"Suma elementów = {tablica.Suma_tabl(newTabl)}");
Console.WriteLine($"Suma elementów podzielnych przez 2 = {tablica.SumaPodziel2(newTabl)}");
Console.WriteLine($"Ilość elementów w tablice = {tablica.IleElementów(newTabl)}");
tablica.Wyswietl();
Console.Write("Podaj mniejszy indeks: ");
int lowindex = Convert.ToInt32(Console.ReadLine());
Console.Write("Podaj większy indeks: ");
int highindex = Convert.ToInt32(Console.ReadLine());
tablica.Zakres(lowindex, highindex);*/



// -------------Zdania 2-----------end



// -------------Zdania 3-----------start

Data data = new Data();

Console.WriteLine("Teraz: " + data.PobiezBiezDate());

data.PrzesDoTyl();
Console.WriteLine("Tydzień temu: " + data.PobiezBiezDate());

data.PrzesDoPrzod();
Console.WriteLine("Tydzień po: " + data.PobiezBiezDate());



// -------------Zdania 3-----------end

// -------------Zdania 4-----------start



// -------------Zdania 4-----------end