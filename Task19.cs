Console.Clear();
          Console.Write("Введите пятизначное число: ");
          int n = Convert.ToInt32(Console.ReadLine());
          string nToString = Convert.ToString(n);
          if (nToString[0] == nToString[4] && nToString[1] == nToString[3])
          {
              Console.WriteLine("да");
          }    
          else {
              Console.WriteLine("нет");
          }
