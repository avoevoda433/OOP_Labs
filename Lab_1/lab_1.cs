using System;
				
public class MyClass
{
	float a = 2.3F;
	float b = 4.9F;
	
	public float A0
	{
		get { a *= b; return a; }
	}
	
	public float A1
	{
		get { return ++a; }
	}
	
	public float A2
	{
		get { return a/b; }
	}
	
}


public class Program
{
	public static void Main()
	{
		MyClass MyObject = new MyClass();
		Console.WriteLine(string.Format("A0 result: {0}\nA1 result: {1}\nA2 result: {2}\n", 
										MyObject.A0, MyObject.A1, MyObject.A2));
	}
}
