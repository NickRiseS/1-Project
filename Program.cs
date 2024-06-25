using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main()
        {
            float rublesInWallet;
            float dollarsInWallet;

            float rubToUsd = 89.50f;
            float usdToRub = 89.96f;

            float howMutchToExchange;

            string operation;

            Console.WriteLine("Добро пожаловать в обменник валют!");

            Console.Write("\nВведите сколько рублей у вас на кошельке: ");
            rublesInWallet = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите сколько долларов у вас на кошельке: ");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\nВведите операцию которую хотите выбрать: ");
            Console.WriteLine("1 - Обмен рубли на доллары");
            Console.WriteLine("2 - Обмен доллары на рубли");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    Console.WriteLine("\nВы выбрали операцию обмена рубли на доллары");
                    Console.Write("Сколько рублей вы хотите обменять? ");
                    howMutchToExchange = Convert.ToSingle(Console.ReadLine());
                    if (rublesInWallet >= howMutchToExchange)
                    {
                        rublesInWallet -= howMutchToExchange;
                        dollarsInWallet += howMutchToExchange / rubToUsd;
                        Console.WriteLine("\nОперация прошла успешно!");
                        Console.WriteLine($"Теперь на вашем кошельке {rublesInWallet} рублей" +
                            $" и {dollarsInWallet} долларов!");
                    }
                    else
                        Console.WriteLine("\nУ вас недостаточно средств, попробуйте еще раз!");
                    break;
                case "2":
                    Console.WriteLine("\nВы выбрали операцию обмена долларов на рубли");
                    Console.Write("Сколько долларов вы хотите обменять? ");
                    howMutchToExchange = Convert.ToSingle(Console.ReadLine());
                    if (dollarsInWallet >= howMutchToExchange)
                    {
                        dollarsInWallet -= howMutchToExchange;
                        rublesInWallet += howMutchToExchange * usdToRub;
                        Console.WriteLine("\nОперация прошла успешно!");
                        Console.WriteLine($"Теперь на вашем кошельке {rublesInWallet} рублей" +
                            $" и {dollarsInWallet} долларов!");
                    }
                    else
                        Console.WriteLine("\nУ вас недостаточно средств, попробуйте еще раз!");


                    break;
                default:
                    Console.WriteLine("\nВведена неверная операция, попробуйте еще раз!");
                    break;
            }






        }
    }
}