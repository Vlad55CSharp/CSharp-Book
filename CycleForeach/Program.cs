/*
 * Пример использование цикла foreach C#
 * Условия задачи: вывести каждый символ введенной пользователем строки 
 * Код опубликован на странице сайта https://csharp.webdelphi.ru/cikly-c/
 */
namespace CycleForeach
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите строку: ");
             string str = Console.ReadLine();
			foreach (char ch in str) 
			{
				Console.WriteLine(ch);
			}
		}
	}
}
