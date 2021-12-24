//Необходимо создать метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж):
//Имя;
//Фамилия;
//Возраст;
//Наличие питомца;
//Если питомец есть, то запросить количество питомцев;
//Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек (заполнение с клавиатуры);
//Запросить количество любимых цветов;
//Вызвать метод, который возвращает массив любимых цветов по их количеству (заполнение с клавиатуры);
//Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
//Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
//Корректный ввод: ввод числа типа int больше 0.
//Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
//Вызов методов из метода Main.



namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            var User = EnterUser();
            OutUser(User);
        }

        //Метод для анкетирования
        static (string Name, string lastName, int Age, string[] NamePets, int favCount, string[] favcolors) EnterUser()
        {
            (string Name, string lastName, int Age, string[] NamePets, int favCount, string[] favcolors) User;


            Console.WriteLine("Введите ваше имя: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию: ");
            User.lastName = Console.ReadLine();

            Console.WriteLine("Введите возраст: ");
            int intAges = EnterNumbers();
            User.Age = intAges;

            while (User.Age <= 0)
            {
                Console.WriteLine("Введите корректное значение возраста_");
                User.Age = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Есть ли у вас животные? Да/Нет");
            string IsHasPet = Console.ReadLine();

            if(IsHasPet == "Да")
            {
                Console.WriteLine("Укажите, пожалуйста, количество ваших питомцев_");
                int countOfPets = EnterNumbers();
                var nPets = PetsName(countOfPets);
                User.NamePets = nPets;


            }
            else
            {
                User.NamePets = new string[1] { "Pets are not found" };
            }

            Console.Write("Укажите количество любимых цветов. Ниже указан список.");
            Console.WriteLine("Выберите из списка номер подходящих цветов: 1 - green, 2 - dark_red, 3- khaki, 4 - cyan, 5 - yellow, 6 - red, 7 - magneta, 8 - gray");
            int favcol = EnterNumbers();
            User.favCount = favcol;
            User.favcolors = ColorNum(favcol);


            Console.WriteLine("Выберите из списка номер подходящих цветов: 1 - green, 2 - dark_red, 3- khaki, 4 - cyan, 5 - yellow, 6 - red, 7 - magneta, 8 - gray");
            foreach (var colors in User.favcolors)
            {
                switch (colors)
                {
                    case "1":
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case "2":
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        break;
                    case "3":
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        break;
                    case "4":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        break;
                    case "5":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        break;
                    case "6":
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case "7":
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        break;
                    case "8":
                        Console.BackgroundColor = ConsoleColor.Gray;
                        break;
                    default:
                        Console.WriteLine("Такого цвета нет в списке.");
                        break;
                        
                }
                Console.WriteLine(colors);
            }
            return User;

        }


        static void OutUser((string Name, string lastName, int Age, string[] NamePets, int favCount, string[] favcolors) User)
        {
            Console.WriteLine("Ваша анкета:");
            Console.WriteLine($"Ваше имя - {User.Name}");
            Console.WriteLine($"Ваша фамилия - {User.lastName}");
            Console.WriteLine($"Ваш возраст - {User.Age}");
            Console.WriteLine("Ваши домашние питомцы:");

            foreach(var Pet in User.NamePets)
                Console.WriteLine(Pet);

            Console.WriteLine("Ваши любимые цвета:");
            foreach (var favorite in User.favcolors)
                Console.WriteLine(favorite);
        }

       
        static int EnterNumbers()
        {
            int intNumber;
            string Number;

            do
            {
                Number = Console.ReadLine();
                if(int.TryParse(Number, out int Num))
                {
                    if(Num > 0)
                    {
                        intNumber = Num;
                        break;
                    }
                }
                Console.WriteLine("Format error.Try again!");
  
            }while(true);
            return intNumber;

        }


        static string[] PetsName(int nums)
        {
            var Array0 = new string[nums];
            for (int n = 0; n < Array0.Length; n++)
            {
                Console.WriteLine("Ваш питомец N: ", n+1);
                Array0[n] = Console.ReadLine();
            }
            return Array0;
        }


        static string[] ColorNum(int numbers)
        {
            var Array1 = new string[numbers];
            for(int i = 0; i < Array1.Length; i++)
            {
                Console.WriteLine($"Номер любимого цвета: {i+1} ");
                Array1[i] = Console.ReadLine();
            }
            return Array1;
        }
    }
}
