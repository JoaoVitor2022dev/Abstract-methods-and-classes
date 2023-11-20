using System;
using System.Globalization;
using Primeiro.Entities;
using Primeiro.Entities.Enums;

namespace Primeiro
{
    class Program
    {
       static void Main()
        { 
           // instaciamento da lista
           List<Shape> list = new List<Shape>();

           // entrada de dados 
           Console.Write("Enter the number shape: ");
           int n = int.Parse(Console.ReadLine());

           for (int i = 1; i <= n; i++)
           {
               Console.WriteLine($"Shape #{i} data: "); 
               Console.Write("Rectangle or circle (r/c) ? ");
               char cha = char.Parse(Console.ReadLine());
               Console.Write("Color (Black/Blue/Red): ");
               Color color = Enum.Parse<Color>(Console.ReadLine());

              if (cha == 'r')
              {
                 Console.Write("Width: ");
                 double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 Console.Write("Height: ");
                 double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                 list.Add( new Rectangle(width, height, color));
              }
              else 
              {
                Console.Write("Radius: ");
                double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add( new Circle(radius, color));
              }
           } 

             // saida de dados 

              Console.WriteLine();
              Console.WriteLine("Shape Areas: ");

              foreach (Shape shap in list)
              {
                 Console.WriteLine(shap.Area().ToString("F2", CultureInfo.InvariantCulture));
              }
        }
    }
}

