using ConsoleApp2;

internal class Program
{
    public static void Main(string[] args)
    {   
        Console.Write("Введите размер массива: ");
        string a = Console.ReadLine();
        int max=0, value=0;
        try
        {
            if (Int32.TryParse(a, out int b))
            {
                try
                {
                    if (b > 0)
                    {                       
                        int[] array = new int[b];
                        for (int i = 0; i < array.Length; i++)
                        {
                            Console.Write($"Введите {i + 1} элемент массива: ");
                            if (Int32.TryParse(Console.ReadLine(), out int c))
                            {
                                array[i] = c;
                                if (array[i]>max)
                                {
                                    max= array[i];
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ввод некорректен.");
                                i--;
                                continue;
                            }
                        }
                        Console.WriteLine("\nВаш введенный массив: ");
                        for (int i = 0;i < array.Length;i++)
                        {
                            Console.Write(array[i]+" ");
                        }
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i]==max)
                            {
                                array[i] = 0;
                            }
                        }
                        for (int i = 0; i < array.Length; i++)
                        {
                            if (array[i]>value)
                            {
                                value = array[i]; 
                            }
                        }
                        Console.WriteLine($"\nВторой наибольший элемент в массиве = {value}");
                    }
                    else
                    {
                        throw new MinusInputException();
                    }
                }
                catch (MinusInputException) 
                {
                    Console.WriteLine();
                    Console.WriteLine("Некорректно ввели размер массива: значение не должно быть отрицательным, либо равным нулю.");
                }
            }
            else
            {
                throw new ParseErrorException();
            }
        }
        catch (ParseErrorException) 
        {
            Console.WriteLine();
            Console.WriteLine("Некорректно ввели размер массива: значение не должно превышать 2 147 483 647, быть отрицательным, либо равным нулю, а так же включать текстовые значения.");
        }

   
     


    }
}