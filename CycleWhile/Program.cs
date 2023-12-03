/*
 * Пример использование цикла while C#
 * Условия задачи: выводить на экран четные числа, начиная с 2 до тех пор пока их сумма не станет больше 200
 * Код опубликован на странице сайта https://csharp.webdelphi.ru/cikly-c/
 */
namespace CycleWhile
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int i = 2;
			int sum = 0;
			while (sum < 200)
			{
				sum += i;
				Console.WriteLine($"Число {i} чётное");
				i += 2;
				Console.WriteLine($"Сумма чётных чисел {sum}");
			}
		}
	}
}
