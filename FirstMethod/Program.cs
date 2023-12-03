using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.CodeDom.Compiler;

namespace FirstMethod
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string hello = "Привет, мир!";
			ConsoleColor red = ConsoleColor.Red;
			WriteColorText(hello); //будет выведена строка с красным цветом текста
			WriteColorText(hello, ConsoleColor.Blue); //будет выведена строка с синим цветом текста
			WriteColorText(text: "Красный текст с отступом", insertTab: true); 

			WriteText("Привет, мир!");
			WriteText("Это наш первый метод C#");
			WriteColorText("А это красный текст", ConsoleColor.Red);
			WriteText("Это снова белый цвет");
			WriteColorText("А это зеленый текст", ConsoleColor.Green);
		}

		static void WriteText(string text)
		{
			Console.WriteLine(text);
		}

		static void WriteColorText(string text, ConsoleColor color = ConsoleColor.Red, bool insertTab = false)
		{
			
			ConsoleColor oldColor = Console.ForegroundColor; //запоминаем текущий увет текста
			Console.ForegroundColor = color; //устанавливаем новый цвет текста
			if (insertTab)
			{
				WriteText($"\t{text}"); //выводим текст в консоль
			}
			else
				WriteText($"{text}"); //выводим текст в консоль

			Console.ForegroundColor = oldColor; //возвращаем старый цвет
		}
	}
}
