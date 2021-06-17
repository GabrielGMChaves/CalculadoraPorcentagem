using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Qual é o Valor?");
		string x = Console.ReadLine();
		Console.WriteLine("Qual é o desconto sem o símbolo de %");
		string y = Console.ReadLine();
		double valorFinal = Convert.ToDouble(x)-(Convert.ToDouble(x) * (Convert.ToDouble(y) / 100));
		Console.Write("O valor final é de : " + valorFinal);
	}
}
