using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            for (int j = 0; j < 3; j++)
            {

                Console.WriteLine("Введите имя :");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию :");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин :");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;

                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                var result = Console.ReadLine();

                if (result == "Да" || result == "да")
                {
                    User.HasPet = true;
                }
                else if (result == "Нет" || result == "нет")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                    Console.WriteLine("Так дело дальше не пойдёт");
                }
                Console.WriteLine("Введите ваш возраст: ");
                User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];
                Console.WriteLine("Введите три любимых цвета пользователя: ");

                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }

            }


            Console.ReadKey();
        }
    } 
}
