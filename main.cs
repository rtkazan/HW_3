using System;  
   
namespace HelloWorld  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
          Console.Clear();
          Console.WriteLine("Введите пятизначное число: ");
          int n = Convert.ToInt32(Console.ReadLine());
          string nToString = Convert.ToString(n);
          if (nToString[0] == nToString[4])
          {
              Console.WriteLine("да");
          }    
          else {
                Console.WriteLine("нет");
          }  
        }  
    }  
}