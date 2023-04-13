//  int a, b;
 
//         Console.WriteLine("Введите два числа : ");
 
//         a = Convert.ToInt32(Console.ReadLine());
 
//         b = Convert.ToInt32(Console.ReadLine());
 
//         if (a > b)
 
//         {
 
//             Console.WriteLine("{0} наибольшее число", a);
 
//         }
 
//         else
 
//         {
 
//             Console.WriteLine("{0} наибольшее число ", b);
 
//         }
 
//         Console.ReadLine();


// Console.WriteLine("Введите первое число= ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число= ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число= ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max = a;
// if (max < b) max = b;
// if (max < c) max = c;

// System.Console.WriteLine("Максимальное из этих чисел =  "+ max);



// Console.Write("Введите число : ");
 
//             int s = int.Parse(Console.ReadLine());
 
//             if (s % 2 == 0)
 
//             {
 
//                 Console.Write("Введенное число является четным");
 
//                 Console.Read();
 
//             }
 
//             else
 
//             {
 
//                 Console.Write("Введенное число нечетное");
 
//                 Console.Read();}

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i=1;i<=n;i++)
{
if (i % 2 == 0)
System.Console.Write(i + ", ");
}