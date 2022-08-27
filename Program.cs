// Напишите программу, которая принимает на вход координаты точки (X Y), причем X!=0 и Y!=0 и выдает
// номер четверти плоскости, в которой находится эта точка. 
// public class Task1{
//     public static void Main(string[] args){
//         ViewQuarterNumber();
//     }
//     static void ViewQuarterNumber(){

//      Console.Write("Введите X: ");
//      int X = int.Parse(Console.ReadLine());
//      Console.Write("Введите Y: ");
//      int Y = int.Parse(Console.ReadLine());
//      if (X > 0 && Y > 0)
//      {
//          Console.WriteLine("1 четверть");
//      }
//      else if (X < 0 && Y > 0)
//      {
//          Console.WriteLine("2 четверть");
//      }
//      else if (X < 0 && Y < 0)
//      {
//          Console.WriteLine("3 четверть");
//      }
//      else if (X > 0 && Y < 0)
//      {
//          Console.WriteLine("4 четверть");
//      }
// }
// }

// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x,y)

//  System.Console.Write("Введите четверть: ");
//  int quarternumber = int.Parse(Console.ReadLine());

//  if(quarternumber == 1)
//  {
//      System.Console.WriteLine("x > 0; y > 0");
//  }
//  else if(quarternumber == 2)
//  {
//      System.Console.WriteLine("x < 0; y > 0");
//  }
//  else if(quarternumber == 3)
//  {
//      System.Console.WriteLine("x < 0; y < 0");
//  }
//  else if(quarternumber == 4)
//  {
//      System.Console.WriteLine("x > 0; y < 0");
//  }
//  else{
//      System.Console.WriteLine("Такой четверти не существует");
//  }

// Напишите программу, которая принимает на вход координаты 2ч точек и 
// находит расстояние между ними в 2D пространстве.
// public class Program{
//      public static void Main(string[] args)
//      {
//          VectorLength();
//      }
//         static void VectorLength()
//         {
//         //     Console.Clear();
//         // Console.Write("Введите x1: ");
//         // int x1 = int.Parse(Console.ReadLine());
//         // Console.Write("Введите y1: ");
//         // int y1 = int.Parse(Console.ReadLine());  
//         // Console.Write("Введите x2: ");
//         // int x2 = int.Parse(Console.ReadLine());
//         // Console.Write("Введите y2: ");
//         // int y2 = int.Parse(Console.ReadLine());
//         // double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//         // Console.WriteLine($"Длина вектора A({x1},{y1}); B({x2},{y2}) = {result}");
//         Console.Clear();
//         Console.WriteLine("Введите координаты: x1: ,y1: ,x2: ,y2: ");
//         int x1 = int.Parse(Console.ReadLine());
//         int y1 = int.Parse(Console.ReadLine());
//         int x2 = int.Parse(Console.ReadLine());
//         int y2 = int.Parse(Console.ReadLine());
//         double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
//         Console.WriteLine($"Длина вектора A({x1},{y1}); B({x2},{y2}) = {result:f3}");
//         }
// }


// Задача: Напишите программу, которая принмимает на вход число (N)
//  и выдает таблицу квадратов чисел от 1 до N.

    // Console.Clear();
    // System.Console.Write("Введите число N: ");
    // int N = Convert.ToInt32(Console.ReadLine());
    // System.Console.Write("Таблица квадратов: ");

    // for (int i = 1; i <= N; i++)
    // {
    //     System.Console.Write($"{Math.Pow(i, 2)} ");
    // }
     
     