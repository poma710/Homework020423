// Console.WriteLine("Введите трехзначное число ");
//     while(true)
//     {
//         string input = Console.ReadLine();
//         if(!input.Equals("exit"))
//             Console.WriteLine("{0}->{1}",input, input[1]);
//         else
//             break;
//     }    Первый вариант решения

Console.WriteLine("Введите число: ");
		int number = Convert.ToInt16(Console.ReadLine());
        int second  = (number % 100) / 10;
		if (number > 99 && number <= 999)
		Console.WriteLine("Число трёхзначное");
		else
		Console.WriteLine("Число не трёхзначное");
        System.Console.WriteLine(second);




echo "# Homework-15-04" >> README.md
git init
git add README.md
git commit -m "first commit"
git branch -M main
git remote add origin https://github.com/poma710/Homework-15-04.git
git push -u origin main
