using System;

public class Unit1b
{
	public void Main()
	{
		F = new Functions();
		F.helloWorld("Noah");
	}
}

public class Functions
{
	public void helloWorld(string Name)
	{
		Console.WriteLine(Name);
	}
}
