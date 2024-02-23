//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

 void Mas(int [] a, int b) 
    { 
      if (b > 0) 
      { 
      	Console.Write(a[b] + " "); 
      	Mas(a, b - 1); 
      } 
      else Console.WriteLine(a[0]); 
    } 
    
      int [] num = {1, 2, 5, 0, 10, 34}; 
      Mas(num, num.Length - 1); 
   