// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// int Degree(int a, int b)
// {
//     int res = a;
//     for(int i=1; i<b; i++)
//     {  
//         res=res*a;
//     }
//     return res ;
// }


// Console.Clear();
// int a = Convert.ToInt32(Console.ReadLine());

// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write(Degree(a,b));

int Degree(int a, int b)
{
    int res = 1;
    for (int i = 0; i < b; i++)
    {
        res *= a;
    }
    return res;
}


Console.Clear();
int a = Convert.ToInt32(Console.ReadLine());

int b = Convert.ToInt32(Console.ReadLine());
Console.Write(Degree(a, b));



