using System;

namespace Botik
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("data.txt");
            var questions = lines
                .Select(line => line.Split('|'))
                .Select(line => (line[0], line[1]))
                .ToList();
            var random = new Random();
            var count = questions.Count;
            var score = 0;
            while (true)
            {
                var index = random.Next(count - 1);
                var question = questions[index];

                var opened = 0;
                while (opened < question.Item2.Length)
                {
                    Console.WriteLine($"{question.Item1}: {question.Item2.Length} букв");
                    var answer = question.Item2
                        .Substring(0, opened)
                        .PadRight(question.Item2.Length, '_');
                    Console.WriteLine(question);
                    var tryAnswer = Console.ReadLine();
                    if (tryAnswer == question.Item2)
                    {
                        score++;
                        Console.WriteLine("You are correct!");
                        Console.WriteLine($"У вас {score} очков");
                    }
                    else
                    {
                        Console.WriteLine("It's Wrong!");
                    }
                    var tryAnswer = Console.ReadLine().ToLower().Replace('ё', 'е');
                    if (tryAnswer == question.Item2)
                    {
                        score++;
                        Console.WriteLine("You are correct!");
                        Console.WriteLine($"У вас {score} очков");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("It's Wrong!");
                        opened++;
                    }
                }

                if (opened == question.Item2.Length)
                {
                    Console.WriteLine($"Вы не смогли отгадать! Правильный ответ: {question.Item2}");
                }
              
            }
              
            
            
        }
    }
}
