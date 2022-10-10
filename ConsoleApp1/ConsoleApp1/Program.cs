// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Runtime.Serialization.Formatters;

Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);
//
// //Variables et constantes
// int a = 50;
// string b = "Bonjour";
// double c = 3.1415;
// char d = 'a';
// bool e = true;
// // const int k = 10; k = 15;
// // int x = 10 ,y = 50;
// // Console.WriteLine(x+y);
// // Console.WriteLine(x-y);
// // Console.WriteLine(x*y);
// // Console.WriteLine(x/y);
// string str1 ="Chock";
// string str2 =" Me Daddy";
// string str3 = str1 + str2;
// Console.WriteLine(str3);
// str1 += str2;
// Console.WriteLine(str1);
// int ab, bc, ca;
// char char3 = str1[2];
// string input = Console.ReadLine();
// Console.WriteLine(input);
//
//
// //Conditions
// Console.WriteLine("Choisissez une valeur x et y :");
// Console.Write("x : ");
// int x =Convert.ToInt32(Console.ReadLine());
// Console.Write("y : ");
// int y =Convert.ToInt32(Console.ReadLine());
// bool fact;
// if (x > y)
// {
//     Console.WriteLine("HelloWorld");
//     Console.WriteLine("1");
//     fact = true;
//     Console.WriteLine(fact);
// }
//     else if (x < y)
//     {
//         Console.WriteLine("2");
//         fact = false;
//         Console.WriteLine(fact);
//     }
//         else
//         {
//             Console.WriteLine("3");
//         }
//
// bool fact2 = x > y ? true :  false; 
// Console.WriteLine(fact2 ? "Checked" : "Not checked");
//
// Console.WriteLine("Choisissez une valeur entre 1 et 5");
// int choix =Convert.ToInt32(Console.ReadLine());
// switch (choix)
// {
//     case 1 : Console.WriteLine("Cc");
//         break;
//     case 2 : Console.WriteLine("Heeey");
//         break;
//     case 3 : Console.WriteLine("Bon chance");
//         break;
//     case 4 : Console.WriteLine("Miaou");
//         break;
//     case 5 : Console.WriteLine("Yep");
//         break;
//     default: Console.WriteLine("Try again");
//         break;
// }
//
// //Boucles
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine("Hey");
// }
//
// int iy = 1;
// while (iy < 6)
// {
//     Console.WriteLine(iy);
//     iy++;
// }
//
// int i2 = 1;
// do
// {
//     Console.WriteLine(i2);
//     i2++;
// }
// while(i2 < 5);
//
// Console.WriteLine("Choisissez une valeur x :");
// Console.Write("x : ");
// int i3 = 0;
// int x1 =Convert.ToInt32(Console.ReadLine());
// do
// {
//     if (i3 == (x1 - 3))
//     {
//         i3 += 1;
//     }
//     Console.WriteLine(i3);
//         i3++;
// }
// while(i3 < x1);


// for (int i = 0; i < 5; i++)
// {
//     int j = 0;
//     Console.WriteLine("i : " + i);
//     while (j < 4) 
//     {
//         Console.WriteLine($"j : {j}");
//         j++;
//     }
// }

// string[] fruits = {"banane", "pomme", "pêche", "poire", "fraise", "raisin"};
// char[] a = {'a', 'b', 'c', 'd', 'e'};
// char[] be;
// be = new char[5]{'a', 'b', 'c', 'd', 'e'};
// int[] nums = {5, 50, 12, 66, 666};
// Array.Sort(nums);
// foreach (var i in nums)
// {
//     Console.WriteLine(i+ " ");
// }
// int[,] multiDimensionalArray = new int[2,3]{{1,2,3}, {4,5,6}};
// for (int i = 0; i < 2; i++)
// {
//     Console.WriteLine("");
//     for (int j = 0; j < 3; j++)
//     {
//         Console.Write(" | "+ multiDimensionalArray[i, j] +" | ");
//     }
// }
//
//
// Console.WriteLine("Veuiller entrer des valeurs(0 pour arreter) : ");
// int[] userinput = new int[0];
// int i1 = 0;
// while (true)
// {
//     int input = int.Parse(Console.ReadLine());
//     if (input == 0)
//     {
//         break;
//     }
//     Array.Resize(ref userinput, userinput.Length + 1);
//     userinput[i1] = input;
//     i1++;
// }
// Array.Reverse(userinput);
// foreach (var i in userinput)
// {
//     Console.WriteLine(i+ " ");
// }

//
// var size = 3;
// var randomNumbers = new int[size];
// var random = new Random();
//
// do
// {
//     for (var i = 0; i < randomNumbers.Length; i++)
//     {
//         var randomNumber = random.Next(1, 7);
//         randomNumbers[i] = randomNumber;
//     }
//
//     Console.WriteLine(string.Join(", ", randomNumbers));
//
// randomNumbers = randomNumbers
//     .GroupBy(x => x)
//     .Where(x => !x.Skip(1).Any())
//     .Select(x => x.Key)
//     .ToArray();
// if (randomNumbers.Length == 1 && randomNumbers[0] == 6) break;
// } while (randomNumbers.Length > 0);


// static void HelloWorld()
// {
//     Console.WriteLine("HelloWorld");
// }
//
// static int Add(int x, int y, int z)
// {
//     return x + y + z;
// }
//
// static void Recur1(int x)
// {
//   
// }
// static int yep(int x, int y)
// {
//     return x + y;
// }
// static double yep(double xy, double yx)
// {
//     return x + y;
// }

// ...

// class Test
// {
//     public int Un(int x, int y)
//     {
//         return x + y;
//     }
//     public double Un(double x, double y)
//     {
//         return x + y;
//     }
// }

// static void Main(string[] args)
// {
//     Add(2,5,7);
//     HelloWorld();
//     Recur1(5);
// }
//
// Main(args);

class Voiture
{
    
    public string Color;
    public int Annee;
    public string Marque;
    private int _vitesse = 10;
    public Voiture (string marque, string color, int annee)
    {
        Marque = marque;
        Color = color;
        Annee = annee;
    }
    public int getVitesse()
    {
        return _vitesse;
    }
    public void setVitesse(int vitesse)
    {
        _vitesse = vitesse;
    }
}

class Programm
{
    static void Display(Voiture voiture)
    {
        Console.WriteLine("La voiture est de la marque " + voiture.Marque + " de couleur " + voiture.Color +
                          " et de l'année " + voiture.Annee);
    }
    
   
    static void Main(string[] args)
    {
        Voiture voiture1 = new Voiture("Renault", "Rouge", 2010);
        Display(voiture1);
        Epicier.Display2(new Fruit("Banane", "France"));
        Viande.Manger();
        Legumes.Manger();
    }

    
}

class Aliment
{
    public string Origine;
    public void Manger()
    {
        Console.WriteLine("Je mange");
    }
}
class Fruit : Aliment
{
    public string Name;
    public Fruit(string name, string origine)
    {
        Name = name;
        Origine = origine;
    }
    public void Manger()
    {
        Console.WriteLine("Je mange un fruit");
    }
}

class Epicier
{
    public static void Display2 (Fruit fruit)
    {
        Console.WriteLine("Le fruit est de l'origine " + fruit.Origine + " et de nom " + fruit.Name);
    }
}

class Legumes : Aliment
{
    public static void Manger()
    {
        Console.WriteLine("Je mange un légume");
    }
}
class Viande : Aliment
{
     public static void Manger()
    {
        Console.WriteLine("Je mange de la viande");
    }
}


interface IInterface
{
    void System();
}
public abstract class A7 : IInterface
{
    public abstract void System();
}

enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}