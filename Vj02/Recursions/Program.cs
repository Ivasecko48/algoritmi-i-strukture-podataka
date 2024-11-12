using System;
using System.Diagnostics;
using System.Threading;
namespace Recursions{
	class Program{
		static int Factorial(int n)
		{
		if (n <= 1) return 1;
		return n * Factorial(n - 1);
		}
		public static int Fibonacci(int n){
			if (n<=1)
			return n;
			return Fibonacci(n-1) + Fibonacci(n-2);
		}
		
		public static int FibonacciIter(int n){
			if (n<=1)
			return n;

			int a=0, b=1, c=0;
			for (int i = 2; i <= n; i++)
			{
				c=a+b;
				a=b;
				b=c;
			}
			return c;
			}
			
			static void Main(){
			
				Stopwatch stopWatch = new Stopwatch();

				int result = Factorial(6);
				Console.WriteLine("6!=" + result);

				stopWatch.Start();
				result = Fibonacci(48);
				stopWatch.Stop();
				TimeSpan ts = stopWatch.Elapsed;    
				string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);  
				
				Console.WriteLine("Fibonacci = " + result);
				Console.WriteLine("RunTime " + elapsedTime);
				
				stopWatch.Restart();
				result = FibonacciIter(48);
				stopWatch.Stop();
				ts = stopWatch.Elapsed; 
				elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);  
				Console.WriteLine("FibonacciIter = " + result);     
				Console.WriteLine("RunTime " + elapsedTime);
        
	}
}
}