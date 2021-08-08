using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
	//	Можно было не создавать свой делегат TellUser в прошлой задаче, а использовать Action.Но в некоторых ситуациях Action и Func недостаточно.

	//Задача все та же — напишите определение делегата TryGet так, чтобы код скомпилировался!

	class LambdaTask
	{
		private static readonly Func<int> zero = () => 0;
		private static readonly Func<int,string> toString = (x) =>  Convert.ToString(x); 
		private static readonly Func<double,double,double> add = (x,y) => x+y;
		private static readonly Action<string> print = (str) => Console.WriteLine(str);

		static Func<T1, T3> Combine<T1, T2, T3>(Func<T1, T2> f, Func<T2, T3> g)
		{
			return x => g(f(x));
}
	}
	class DelegateTask
    {
		delegate bool TryGet<T1, T2>(string questionText, Action<string> tellUser, out int age);
		static void Main()
		{
			Run(AskUser, Console.WriteLine);
		}

		static void Run(TryGet<string,int> askUser, Action<string> tellUser)
		{
			int age;
			if (askUser("What is your age?", tellUser, out age))
				tellUser("Age: " + age);
		}

		static bool AskUser(string questionText, Action<string> tellUser, out int age)
		{
			tellUser(questionText);
			var answer = Console.ReadLine();
			return int.TryParse(answer, out age);
		}
	}
}
