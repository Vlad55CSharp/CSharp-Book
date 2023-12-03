namespace ReturnValues
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int value = Sum(10, 4); //присвоили переменной значение, возвращаемое методом
			Console.WriteLine(value); //вывели значение в консоль	
			Console.WriteLine(Sum(5,5)); //рассчитали сумму и сразу вывели в консоль вызвав метод Console.WriteLine()
			
			CheckAge(15);
			Console.WriteLine("Вышли из метода CheckAge");
		}

		static int Sum(int a, int b) => a + b;

		static void CheckAge(int age)
		{
			if (age < 18) 
			{
				Console.WriteLine("Этот контент имеет ограничение 18+");
				return; 
			}
			Console.WriteLine("Вы достигли необходимого возраста - наслаждайтесь");
		}

	}
}
