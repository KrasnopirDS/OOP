
all_Menues();
static void all_Menues()
{
    Console.Clear();
    Console.WriteLine("Wybierz operacje:");
    Console.WriteLine("1. Kalkulator.");
    Console.WriteLine("2. Tablica z sortowaniem.");
    Console.WriteLine("3. Tablica z obliczeniami.");
    Console.WriteLine("4. Wyświetli liczby od 20-0, z wyłączeniem liczb {2,6,9,15,19}.");
    Console.WriteLine("5. Program który w nieskończoność pyta użytkownika o liczby całkowite.");
    Console.WriteLine("6. Program umożliwiający wprowadzanie n liczb oraz sortujący te liczby.");
    Console.WriteLine("7. Wyjscie");
    Console.Write("Wybierz aplikacje: ");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    wyb_Operacji();
}

static void wyb_Operacji()
{
    while (true)
    {
        switch (Global_var.operacja)
        {
            case 1:
                menu_Kalkul();
                break;
            case 2:
                menu_Tablicy();
                break;
            case 3:
                menu_Tablicy_Zdanie4();
                break;
            case 4:
                menu_Zdanie5();
                break;
            case 5:
                menu_Zdanie6();
                break;
            case 6:
                menu_Zdanie7();
                break;
            case 7:
                Environment.Exit(0);
                break;
            default: Environment.Exit(0); break;
        }
    }
}

//Zdanie 2
static void menu_Kalkul()
{
    Console.Clear();
    Console.WriteLine("Wybierz operacje:");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Roznica");
    Console.WriteLine("3. Iloczyn");
    Console.WriteLine("4. Iloraz");
    Console.WriteLine("5. Potega");
    Console.WriteLine("6. Pierwiastek kwadratowa");
    Console.WriteLine("7. Trygonometria");
    Console.WriteLine("8. Wyjscie");
    Console.Write("Twoj wybor: ");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    kalkul();
}

//Zdanie 3
static void menu_Tablicy()
{
    Console.Clear();
    Console.WriteLine("Wybierz operacje:");
    Console.WriteLine("1. Wyswietlanie tablicy od pierwszego do ostatniego indeksu.");
    Console.WriteLine("2. Wyswietlanie tablicy od ostatniego do pierwszego indeksu.");
    Console.WriteLine("3. Wyswietlanie elementow o nieparzystych indeksach.");
    Console.WriteLine("4. Wyswietlanie elementow o parzystych indeksach.");
    Console.WriteLine("5. Wyjscie");
    Console.Write("Twoj wybor: ");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    tablica();
}

//Zdanie 4
static void menu_Tablicy_Zdanie4()
{
    Console.Clear();
    Console.WriteLine("Wybierz operacje:");
    Console.WriteLine("1. Oblicz sumę elementów tablicy.");
    Console.WriteLine("2. Oblicz iloczyn elementów tablicy.");
    Console.WriteLine("3. Wyznacz wartość średnią.");
    Console.WriteLine("4. Wyznacz wartość minimalną.");
    Console.WriteLine("5. Wyznacz wartość maksymalną.");
    Console.WriteLine("6. Wyjscie");
    Console.Write("Twoj wybor: ");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    tablica_Zadanie4();
}

//Zdanie 5
static void menu_Zdanie5()
{
    Console.Clear();
    Console.WriteLine("Wybierz operacje:");
    Console.WriteLine("1. Wyświetli liczby od 20-0, z wyłączeniem liczb {2,6,9,15,19}.");
    Console.WriteLine("2. Wyjscie");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    kod_Zadanie5();
}

//Zdanie 6
static void menu_Zdanie6()
{
    Console.Clear();
    Console.WriteLine("Wybierz operacje:");
    Console.WriteLine("1. Program który w nieskończoność pyta użytkownika o liczby całkowite.");
    Console.WriteLine("2. Wyjscie");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    kod_Zadanie6();
}


//Zdanie 7  Program umożliwiający wprowadzanie n liczb oraz sortujący te liczby
static void menu_Zdanie7()
{
    Console.Clear();
    Console.WriteLine("Wybierz operacje:");
    Console.WriteLine("1. Program umożliwiający wprowadzanie n liczb oraz sortujący te liczby.");
    Console.WriteLine("2. Wyjscie");
    Global_var.operacja = Convert.ToInt32(Console.ReadLine());
    kod_Zadanie7();
}


//---------------Kod tablicy, Zdanie 7----------start
static void kod_Zadanie7()
{
    while (true)
    {
        switch (Global_var.operacja)
        {
            case 1:
                tworzenie_Zd7();
                break;
            case 2:
                koniec_Aplikac();
                break;
            default:
                koniec_Aplikac();
                break;
        }
    }
}

static void tworzenie_Zd7()
{
    Console.WriteLine("Podaj liczbę elementów do posortowania:");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] table = new int[n];
    Console.WriteLine("Podaj liczby do posortowania:");
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Element {i + 1}: ");
        table[i] = Convert.ToInt32(Console.ReadLine());
    }

    BubbleSort(table);

    Console.WriteLine("Posortowane liczby:");
    foreach (var liczba in table)
    {
        Console.Write($"{liczba} ");
    }
    Console.ReadKey();
}
static int[] BubbleSort(int[] table)
{
    var n = table.Length;
    for (int i = 0; i < n - 1; i++)
        for (int j = 0; j < n - i - 1; j++)
            if (table[j] > table[j + 1])
            {
                var tempVar = table[j];
                table[j] = table[j + 1];
                table[j + 1] = tempVar;
            }
    return table;
}
//---------------Kod tablicy, Zdanie 7----------end

//---------------Kod tablicy, Zdanie 6----------start


static void kod_Zadanie6()
{
    while (true)
    {
        switch (Global_var.operacja)
        {
            case 1:
                tworzenie_Zd6();
                break;
            case 2:
                koniec_Aplikac();
                break;
            default:
                koniec_Aplikac();
                break;
        }
    }
}

static void tworzenie_Zd6()
{
    double item = input();

    while (true)
    {

        if (item - Convert.ToInt32(item) == 0 && item < 0)
        {
            Console.WriteLine($"To naturalna liczba: {item}");
            break;
        }
        else
        {
            if (item % 2 == 0)
            {
                Console.WriteLine($"To naturalna liczba: {item}");
            }
            item = input();
        }
    }
    koniec_Aplikac();

}

//---------------Kod tablicy, Zdanie 6----------end


//---------------Kod tablicy, Zdanie 5----------start

static void kod_Zadanie5()
{
    while (true)
    {
        switch (Global_var.operacja)
        {
            case 1:
                tworzenie_Zd5();
                Console.ReadKey();
                menu_Zdanie5();
                break;
            case 2:
                koniec_Aplikac();
                break;
            default:
                koniec_Aplikac();
                break;
        }
    }
}


static void tworzenie_Zd5()
{
    //int[] intTabl = Array.Empty<int>();

    //{2,6,9,15,19}
    Console.WriteLine("Wyświetlający liczby od 20-0, z wyłączeniem liczb {2,6,9,15,19}:");
    for (int i = 20; i > 0; i--)
    {
        if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
        {
            continue;
        }
        Console.Write(i + " ");
    }
}



//---------------Kod tablicy, Zdanie 5----------end


//---------------Kod tablicy, Zdanie 4----------start


static void tablica_Zadanie4()
{
    while (true)
    {
        double[] tabl = new double[10];
        if (Global_var.operacja == 1 || Global_var.operacja == 2 || Global_var.operacja == 3 || Global_var.operacja == 4 || Global_var.operacja == 5)
        {
            Console.WriteLine("Tworzenie tablicy.");
            Console.WriteLine("Podaj 10 liczb: ");
            for (int i = 0; i < tabl.Length; i++)
            {
                tabl[i] = input();
            }
        }


        switch (Global_var.operacja)
        {
            case 1:
                Console.WriteLine($"Suma liczb z tablicy: {suma_Tablicy(tabl)}");
                koniec_Dzialania_TablicyZd4();
                break;
            case 2:
                Console.WriteLine($"Iloczyn liczb z tablicy: {iloczyn_Tablicy(tabl)}");
                koniec_Dzialania_TablicyZd4();
                break;
            case 3:
                Console.WriteLine($"Sriednia liczb tablicy: {srednie_Tablicy(tabl)}");
                koniec_Dzialania_TablicyZd4();
                break;
            case 4:
                min_Tablicy(tabl);
                Console.WriteLine($"Minimalna wartosc tablicy: {min_Tablicy(tabl)}");
                koniec_Dzialania_TablicyZd4();
                break;
            case 5:
                max_Tablicy(tabl);
                Console.WriteLine($"Maxsymalna wartosc tablicy: {max_Tablicy(tabl)}");
                koniec_Dzialania_TablicyZd4();
                break;
            case 6:
                koniec_Aplikac();
                break;
            default:
                koniec_Aplikac();
                break;
        }
    }
}

static double suma_Tablicy(double[] tabl)
{
    double suma_argum = 0;
    for (int i = 0; i < tabl.Length; i++)
    {
        suma_argum += tabl[i];
    }
    return suma_argum;
}
static double iloczyn_Tablicy(double[] tabl)
{
    double suma_argum = 1;
    for (int i = 0; i < tabl.Length; i++)
    {
        suma_argum *= tabl[i];
    }
    return suma_argum;
}
static double srednie_Tablicy(double[] tabl)
{
    return suma_Tablicy(tabl) / (tabl.Length - 1);
}

static double min_Tablicy(double[] tabl)
{
    double min_argum = tabl[0];
    for (int i = 1; i < tabl.Length; i++)
    {
        if (min_argum > tabl[i])
        {
            min_argum = tabl[i];
        }
    }
    return min_argum;
}
static double max_Tablicy(double[] tabl)
{
    double max_argum = tabl[0];
    for (int i = 1; i < tabl.Length; i++)
    {
        if (max_argum < tabl[i])
        {
            max_argum = tabl[i];
        }
    }
    return max_argum;
}



//---------------Kod tablicy, Zdanie 4----------end



//---------------Kod tablicy, Zdanie 3----------start

static void tablica()
{
    while (true)
    {
        double[] tabl = new double[10];
        if (Global_var.operacja == 1 || Global_var.operacja == 2 || Global_var.operacja == 3 || Global_var.operacja == 4 || Global_var.operacja == 5)
        {
            Console.WriteLine("Tworzenie tablicy.");
            Console.WriteLine("Podaj 10 liczb: ");
            for (int i = 0; i < tabl.Length; i++)
            {
                tabl[i] = input();
            }
        }

        if (Global_var.operacja == 1)
        {
            print_Tabl(tabl);
        }
        else
        {
            if (Global_var.operacja == 2)
            {
                print_UnTabl(tabl);
            }
            else
            {
                if (Global_var.operacja == 3)
                {
                    print_Tabl_Par(tabl);
                }
                else
                {
                    if (Global_var.operacja == 4)
                    {
                        print_Tabl_NiePar(tabl);
                    }
                    else
                    {
                        if (Global_var.operacja == 5)
                        {
                            koniec_Aplikac(); break;
                        }
                        else
                        {
                            koniec_Aplikac(); break;
                        }
                    }
                }
            }
        }
    }
}

//Punkt 1
static void print_Tabl(double[] tabl)
{
    Console.WriteLine("Tablicy od pierwszego do ostatniego indeksu:");
    for (int i = 0; i < tabl.Length; i++)
    {
        Console.Write(tabl[i] + " ");
    }
    Console.WriteLine();
    koniec_Dzialania_Tablicy();
}
//Punkt 2
static void print_UnTabl(double[] tabl)
{
    Console.WriteLine("Tablicy od ostatniego do pierwszego indeksu:");
    for (int i = tabl.Length - 1; i >= 0; i--)
    {
        Console.Write(tabl[i] + " ");
    }
    Console.WriteLine();
    koniec_Dzialania_Tablicy();
}
//Punkt 3
static void print_Tabl_Par(double[] tabl)
{
    Console.WriteLine("Wyswietlanie elementow o nieparzystych indeksach:");
    for (int i = 0; i < tabl.Length; i++)
    {
        if (tabl[i] % 2 == 0)
        {
            Console.Write(tabl[i] + " ");
        }
    }
    Console.WriteLine();
    koniec_Dzialania_Tablicy();
}
//Punkt 4
static void print_Tabl_NiePar(double[] tabl)
{
    Console.WriteLine("Wyswietlanie elementow o nieparzystych indeksach:");
    for (int i = 0; i < tabl.Length; i++)
    {
        if (tabl[i] % 2 != 0)
        {
            Console.Write(tabl[i] + " ");
        }
    }
    Console.WriteLine();
    koniec_Dzialania_Tablicy();
}

//---------------Kod tablicy, Zdanie 3----------end



//-----------Kalkulator cod, Zdanie 2------------start
static void kalkul()
{
    while (true)
    {
        //Console.ReadKey();
        //menu_Kalkul();
        switch (Global_var.operacja)
        {
            case 1:
                double num1 = input();
                double num11 = input();
                Console.WriteLine($"Suma {num1} + {num11} = {suma(num1, num11)}");
                koniec_Dzialania_Kalkul();
                break;
            case 2:
                double num2 = input();
                double num22 = input();
                Console.WriteLine($"Odejmowanie {num2} - {num22} = {odejm(num2, num22)}");
                koniec_Dzialania_Kalkul();
                break;
            case 3:
                double num3 = input();
                double num33 = input();
                Console.WriteLine($"Iloczyn {num3} * {num33} = {iloczyn(num3, num33)}");
                koniec_Dzialania_Kalkul();
                break;
            case 4:
                double num4 = input();
                double num44 = input();
                Console.WriteLine($"Iloraz {num4} / {num44} = {iloraz(num4, num44)}");
                koniec_Dzialania_Kalkul();
                break;
            case 5:
                double num5 = input();
                double num55 = input();
                Console.WriteLine($"Potenga {num5} ^ {num55} = {potenga(num5, num55)}");
                koniec_Dzialania_Kalkul();
                break;
            case 6:
                double num6 = input();
                Console.WriteLine($"Pierwiastek kwadratowy od {num6} = {pierwiastek(num6)}");
                koniec_Dzialania_Kalkul();
                break;
            case 7:
                double num7 = input();
                trygonometria(num7);
                koniec_Dzialania_Kalkul();
                break;
            case 8:
                koniec_Aplikac();
                break;
            default: koniec_Aplikac(); break;
        }
    }
}

static double suma(double a, double b)
{
    return a + b;
}
static double odejm(double a, double b)
{
    return a - b;
}
static double iloczyn(double a, double b)
{
    return a * b;
}
static double iloraz(double a, double b)
{
    return a / b;
}
static double potenga(double a, double b)
{
    return Math.Pow(a, b);
}

static double pierwiastek(double a)
{
    return Math.Sqrt(a);
}


static void trygonometria(double a)
{
    double rad = a * Math.PI / 180;
    Console.WriteLine($"Sinus  od {a} = {Math.Sin(rad)}");
    Console.WriteLine($"Cosinus  od {a} = {Math.Cos(rad)}");
    Console.WriteLine($"Tangens  od {a} = {Math.Tan(rad)}");
    Console.WriteLine($"Cotangens  od {a} = {1 / Math.Tan(rad)}");
}

//-----------Kalkulator cod, Zdanie 2------------end


static double input()
{
    Console.Write("Podaj liczbe: ");
    double a = Convert.ToInt32(Console.ReadLine());
    return a;
}

static void koniec_Aplikac()
{
    Console.Clear();
    all_Menues();
}
static void koniec_Dzialania_TablicyZd4()
{
    Console.ReadKey();
    menu_Tablicy_Zdanie4();
}
static void koniec_Dzialania_Tablicy()
{
    Console.ReadKey();
    menu_Tablicy();
}
static void koniec_Dzialania_Kalkul()
{
    Console.ReadKey();
    menu_Kalkul();
}
public static class Global_var
{
    public static Int32 operacja;
}