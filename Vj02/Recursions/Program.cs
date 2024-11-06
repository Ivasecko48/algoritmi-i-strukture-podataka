using System;
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
				int result = Factorial(6);
				Console.WriteLine("6!=" + result);
				result = Fibonacci(6);
				Console.WriteLine("Fibonacci od 6 = " + result);
				result = FibonacciIter(6);
				Console.WriteLine("FibonacciIter od 6 = " + result);
			}
	}
}