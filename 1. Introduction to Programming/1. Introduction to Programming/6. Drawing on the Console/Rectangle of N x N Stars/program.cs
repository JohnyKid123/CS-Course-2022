using System;
					
public class Program
{
	public static void Main()
	{
		var n = int.Parse(Console.ReadLine());
		for(int  i=0; i<n; i++)
		{
			Console.WriteLine(new string('*',n));
		}
			
	}
}
