using System;

namespace ProgramToFindMinAndMaxInArray
{
	class Program
	{
		static void Main(string[]args)
		{
			var numbers = new int[10];
			var rnd = new Random();
			int min, max;
			
			for(int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = rnd.Next(1, 100);
				Console.WriteLine(numbers);
			}
			min = numbers[0];
			max = numbers[0];
			
			foreach(int number in numbers)
			{
				if(min > number)
					min = number;
				if(max < number)
					max = number;
			}
			Console.WriteLine("===========================");
			Console.WriteLine("The highest number in the array: > > > " + max);
			Console.WriteLine("The lowest number in the array: > > > " + min);
            Console.ReadKey();
        }
	}
}