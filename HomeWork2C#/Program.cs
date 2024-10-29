using System.Text;

namespace HomeWork2C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            //Завдання 1
            //int[] A = new int[5];
            //double[,] B = new double[3, 4];
            //Random rand = new Random();

            //Console.WriteLine("Введіть 5 цілих чисел для масиву A:");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write($"A[{i}] = ");
            //    A[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("\nМасив B (заповнено випадковими дробовими числами):");
            //for (int i = 0; i < B.GetLength(0); i++)
            //{
            //    for (int j = 0; j < B.GetLength(1); j++)
            //    {
            //        B[i, j] = rand.NextDouble() * 100;
            //        Console.Write($"{B[i, j]:F2} ");
            //    }
            //    Console.WriteLine();
            //}

            //int max = Math.Max(A.Max(), (int)B.Cast<double>().Max());
            //int min = Math.Min(A.Min(), (int)B.Cast<double>().Min());
            //double sum = A.Sum() + B.Cast<double>().Sum();
            //double product = A.Aggregate(1, (acc, x) => acc * x) * B.Cast<double>().Aggregate(1.0, (acc, x) => acc * x);
            //int evenSum = A.Where(x => x % 2 == 0).Sum();
            //double oddColumnSum = 0;

            //for (int j = 1; j < B.GetLength(1); j += 2)
            //    for (int i = 0; i < B.GetLength(0); i++)
            //        oddColumnSum += B[i, j];

            //Console.WriteLine($"\nМаксимальний елемент: {max}");
            //Console.WriteLine($"Мінімальний елемент: {min}");
            //Console.WriteLine($"Сума всіх елементів: {sum}");
            //Console.WriteLine($"Добуток всіх елементів: {product}");
            //Console.WriteLine($"Сума парних елементів масиву A: {evenSum}");
            //Console.WriteLine($"Сума елементів непарних стовпців масиву B: {oddColumnSum}");

            //Завдання 2
            //int[,] array = new int[5, 5];
            //Random rand = new Random();

            //Console.WriteLine("Масив 5x5:");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        array[i, j] = rand.Next(-100, 101);
            //        Console.Write($"{array[i, j],5}");
            //    }
            //    Console.WriteLine();
            //}

            //int min = array.Cast<int>().Min();
            //int max = array.Cast<int>().Max();
            //bool between = false;
            //int sum = 0;

            //foreach (var item in array)
            //{
            //    if (item == min || item == max)
            //        between = !between;
            //    else if (between)
            //        sum += item;
            //}

            //Console.WriteLine($"\nСума елементів між мінімумом ({min}) і максимумом ({max}): {sum}");

            /*Завдання 3 (Працює на англійській)
            Console.WriteLine("Введіть текст для шифрування:");
            string input = Console.ReadLine();

            Console.WriteLine("Введіть значення зсуву:");
            if (!int.TryParse(Console.ReadLine(), out int shift))
            {
                Console.WriteLine("Невірний формат числа зсуву.");
                return;
            }

            StringBuilder encrypted = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    char shiftedChar = (char)((c + shift - offset + 26) % 26 + offset);
                    encrypted.Append(shiftedChar);
                }
                else
                {
                    encrypted.Append(c);
                }
            }
            Console.WriteLine($"Зашифрований текст: {encrypted}");

            StringBuilder decrypted = new StringBuilder();
            foreach (char c in encrypted.ToString())
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    char shiftedChar = (char)((c - shift - offset + 26) % 26 + offset);
                    decrypted.Append(shiftedChar);
                }
                else
                {
                    decrypted.Append(c);
                }
            }
            Console.WriteLine($"Розшифрований текст: {decrypted}");*/

            //Завдання 4
            //Console.WriteLine("Оберіть операцію:");
            //Console.WriteLine("1. Множення матриці на число");
            //Console.WriteLine("2. Додавання матриць");
            //Console.WriteLine("3. Добуток матриць");

            //int choice = int.Parse(Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        MultiplyMatrixByNumber();
            //        break;
            //    case 2:
            //        AddMatrices();
            //        break;
            //    case 3:
            //        MultiplyMatrices();
            //        break;
            //    default:
            //        Console.WriteLine("Неправильний вибір.");
            //        break;
            //}

            //Завдання 5
            //Console.WriteLine("Введіть арифметичний вираз (+ або -):");
            //string expression = Console.ReadLine();
            //var result = EvaluateExpression(expression);
            //Console.WriteLine($"Результат: {result}");

            /*Завдання 6(Працює на англійській)
            Console.WriteLine("Введіть текст:");
            string text = Console.ReadLine();
            string result = CapitalizeSentences(text);
            Console.WriteLine($"Результат: {result}");*/

            /*Завдання 7(Працює на англійській)
            Console.WriteLine("Введіть текст:");
            string text = Console.ReadLine();
            Console.WriteLine("Введіть заборонене слово:");
            string forbiddenWord = Console.ReadLine();

            string result = text.Replace(forbiddenWord, new string('*', forbiddenWord.Length));
            int replacements = text.Split(new[] { forbiddenWord }, StringSplitOptions.None).Length - 1;

            Console.WriteLine($"Результат: {result}");
            Console.WriteLine($"Статистика: {replacements} замін слова '{forbiddenWord}'");*/
        }



        static void MultiplyMatrixByNumber()
        {
            Console.WriteLine("Введіть розмірність матриці (рядки і стовпці):");
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            Console.WriteLine("Введіть елементи матриці:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Введіть число для множення:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат множення матриці на число:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] * number + "\t");
                }
                Console.WriteLine();
            }
        }


        static void AddMatrices()
        {
            Console.WriteLine("Введіть розмірність матриць (рядки і стовпці):");
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];

            Console.WriteLine("Введіть елементи першої матриці:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Введіть елементи другої матриці:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Результат додавання матриць:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write((matrix1[i, j] + matrix2[i, j]) + "\t");
                }
                Console.WriteLine();
            }
        }
        static void MultiplyMatrices()
        {
            Console.WriteLine("Введіть розміри першої матриці (рядки і стовпці):");
            int rows1 = int.Parse(Console.ReadLine());
            int cols1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть розміри другої матриці (рядки і стовпці):");
            int rows2 = int.Parse(Console.ReadLine());
            int cols2 = int.Parse(Console.ReadLine());

            if (cols1 != rows2)
            {
                Console.WriteLine("Множення неможливе: кількість стовпців першої матриці повинна дорівнювати кількості рядків другої матриці.");
                return;
            }

            int[,] matrix1 = new int[rows1, cols1];
            int[,] matrix2 = new int[rows2, cols2];
            int[,] result = new int[rows1, cols2];

            Console.WriteLine("Введіть елементи першої матриці:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Введіть елементи другої матриці:");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            Console.WriteLine("Результат добутку матриць:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static int EvaluateExpression(string expression)
        {
            var tokens = expression.Split(new[] { '+', '-' }, StringSplitOptions.RemoveEmptyEntries);
            var operators = expression.Where(c => c == '+' || c == '-').ToArray();
            int result = int.Parse(tokens[0]);
            for (int i = 0; i < operators.Length; i++)
            {
                int value = int.Parse(tokens[i + 1]);
                result += operators[i] == '+' ? value : -value;
            }
            return result;
        }

        static string CapitalizeSentences(string text)
        {
            var sentences = text.Split(new[] { '.', '!', '?' });
            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = sentences[i].Trim();
                if (sentences[i].Length > 0)
                {
                    sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
                }
            }
            return string.Join(". ", sentences);
        }
    }
}
