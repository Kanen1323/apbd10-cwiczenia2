
using System;
Console.WriteLine("Pizza hut");

int Margaritta = 30;
int Salami = 45;
int Hawajska = 42;

Console.WriteLine("Chose the  pizza you want: " +
                  "1-margarita " + 
                  "2-Salami " +
                  "3-Hawajska ");
String choise = Console.ReadLine();

if (int.TryParse(choise, out int number))
{
    switch (number)
    {
        case 1:
            Console.WriteLine("You chose margaritta ");
            break;
        case 2:
            Console.WriteLine("You chose salami ");
            break;
        case 3:
            Console.WriteLine("You chose hawajska ");
            break;
        
    }
    
}

static double GetAverage(int[] arr)
{

    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
    
}

int[] numbers = { 1, 2, 3, 4, 5, 6 };

Console.WriteLine("our Average is " + GetAverage(numbers));



