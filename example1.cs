using System;

public class Class1
{
	public Class1()
	{
		static void Main()
        {
			int num;
			Console.WriteLine("enter number where to stop");
			num = Convert.ToInt32(Console.ReadLine());
			for (int i=0;i>=num;i++)
            {
				Console.WriteLine(i);
            }
        }
	}
}
