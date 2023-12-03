/*
 * Пример использование цикла for C#
 * Условия задачи: вывести на экран все чётные числа от 1 до N включительно
 * Код опубликован на странице сайта https://csharp.webdelphi.ru/cikly-c/
 */
namespace CycleFor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int N = 10; //задаем число до которого будем проверять все числа на чётность
			for (int i = 1; i <= N; i++)
			{
				if (i % 2 == 0)
					Console.WriteLine($"Число {i} - чётное");
			}
		}
	}
}
