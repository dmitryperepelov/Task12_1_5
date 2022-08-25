using System;
using System.Linq;
using System.Threading;

namespace Task12_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Введите логин: ");
			var login = Console.ReadLine();
			var user = User.CreateUsers().FirstOrDefault(item => item.Login == login);

			if (user == null)
            {
				Console.WriteLine("Пользователь не найден!");
				Console.ReadKey();
				return;
            }

			SayHello(user);
			Console.ReadKey();
		}

		static void ShowAds()
		{
			Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
			// Остановка на 1 с
			Thread.Sleep(1000);

			Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
			// Остановка на 2 с
			Thread.Sleep(2000);

			Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
			// Остановка на 3 с
			Thread.Sleep(3000);
		}

		static void SayHello(User user)
        {
			if (!user.IsPremium)
				ShowAds();

			Console.WriteLine($"С возвращением, {user.Name}!");
        }
	}
}