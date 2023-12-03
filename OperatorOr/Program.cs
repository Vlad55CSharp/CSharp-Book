/*
 * Пример использование оператора & в C#
 * Условия задачи: даны два числа a и b. Если хотя бы одно число больше 2, то вывести на экран их сумму, иначе - утроенную сумму.
 * Код опубликован на странице сайта https://csharp.webdelphi.ru/logicheskie-operatory-c/#_if
 */
namespace OperatorOr
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = 2;
			int b = 3;
			
			if ((a > 2) | (b > 2))
			{
				Console.WriteLine(a + b);
			}
			else
			{
				Console.WriteLine(3 * (a + b));
			}
		}
	}
}
