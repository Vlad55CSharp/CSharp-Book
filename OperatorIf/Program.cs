/*
 * Пример использование условного оператора if в C#
 * Условия задачи: заданы два числа a и b, если a меньше b, то необходимо вывести на экран их сумму, иначе - вывести на экран их разность
 * Код опубликован на странице сайта https://csharp.webdelphi.ru/logicheskie-operatory-c/#_if
 */
namespace OperatorIf
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = 3; //задаем значение переменной a
			int b = 4; //задаем значение переменной b
			if (a < b) //проверяем условие: a меньше, чем b
			{
				Console.WriteLine(a + b); //если условие соблюдается 
			}
			else 
			{
				Console.WriteLine(a - b); //если условие НЕ соблюдается 
			}
		}
	}
}
