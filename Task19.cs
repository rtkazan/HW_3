          Console.Clear();
          Console.Write("Введите пятизначное число: ");
          int n = Convert.ToInt32(Console.ReadLine());
          string nToString = Convert.ToString(n);
          while (nToString.Length > 4 && nToString.Length < 6)
                 
            if (nToString[0] == nToString[4] && nToString[1] == nToString[3])
            {
                Console.WriteLine("да");
                break;
            }
            else Console.WriteLine("нет");
          Console.WriteLine("не пятизначное число");
            
