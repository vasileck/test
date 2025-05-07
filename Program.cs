   public class Program
   {

       public static int FindSum(int[] arr)
       {
           if (arr.Length < 2)
               throw new ArgumentException("Массив должен содержать минимум два элемента.");

           Array.Sort(arr);
           int first = arr[0];
           int second = arr[1];
           return first + second;
       }

       static void Main(string[] args)
       {
           int[] newarray = { };

           try
           {
               Console.WriteLine(FindSum(newarray));
           }
           catch (ArgumentException)
           {
               Console.WriteLine("Не хватает данных для обработки массива");
           }


       }
   }