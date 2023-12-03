/*
 * Пример использование цикла do..while C#
 * Условия задачи: пользователь вводит с клавиатуры целые числа. До тех пор, пока пользователь не введет 0 определять минимальное из введенных значений
 * Код опубликован на странице сайта https://csharp.webdelphi.ru/cikly-c/
 */
namespace CycleDoWhile
{
	internal class Program
	{
		static void Main(string[] args)
		{
            int min = int.MaxValue;
			int num;
			do
			{
				Console.Write("Введите целое число: ");
				num = Convert.ToInt32(Console.ReadLine());
				if ((num<min) && (num != 0))
				{
				   min = num;
				}
			}
			while (num != 0);
			Console.WriteLine($"Минимальное значение {min}");
		}
	}
}
