/*
 * Пример использование оператора continue в цикле C#
 * Условия задачи: пользователь вводит с клавиатуры числа. Считать сумму только чисел больше 0. 
 * Условием выхода из программы является ввод числа 0
 * Код опубликован на странице сайта https://csharp.webdelphi.ru/cikly-c/
 */
namespace CycleContinue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			int num;
			do
			{
				Console.Write("Введите число: ");
				num = Convert.ToInt32(Console.ReadLine());
				if (num <= 0)
					continue;
				sum += num;
			}
			while (num != 0);
			Console.Write($"Сумма введенных чисел: {sum}");
		}
	}
}
