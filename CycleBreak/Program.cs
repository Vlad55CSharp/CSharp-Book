/*
 * Пример использование оператора break в цикле C#
 * Условия задачи: Выводить все символы строки до тех пор, пока не встретится символ !
 * Условием выхода из программы является ввод числа 0
 * Код опубликован на странице сайта https://csharp.webdelphi.ru/cikly-c/
 */
namespace CycleBreak
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите любую строку:");
			string str = Console.ReadLine();
			foreach (char ch in str)
			{
				if (ch == '!')
					break;
				Console.WriteLine(ch);
			}
		}
	}
}
