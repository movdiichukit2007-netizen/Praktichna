using System;
using System.Text;

namespace ArrayLab
{
    static class ArrayHelper
    {
        public static int IndexOf<T>(T[] a, T x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Equals(x))
                    return i;
            }
            return -1;
        }

        public static void Reverse<T>(T[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n / 2; i++)
            {
                T c = a[i];
                a[i] = a[n - 1 - i];
                a[n - 1 - i] = c;
            }
        }

        public static T Min<T>(T[] a) where T : IComparable<T>
        {
            T m = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i].CompareTo(m) < 0)
                    m = a[i];
            }
            return m;
        }

        public static T Max<T>(T[] a) where T : IComparable<T>
        {
            T m = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i].CompareTo(m) > 0)
                    m = a[i];
            }
            return m;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] arr = { 5, 12, 1, 9, 20 };

            Console.WriteLine("Числа:");
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Індекс 9: " + ArrayHelper.IndexOf(arr, 9));
            Console.WriteLine("Мін: " + ArrayHelper.Min(arr));
            Console.WriteLine("Макс: " + ArrayHelper.Max(arr));

            ArrayHelper.Reverse(arr);
            Console.Write("Реверс: ");
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
            Console.WriteLine("\n");

            string[] s = { "один", "два", "три", "чотири" };

            Console.WriteLine("Рядки:");
            for (int i = 0; i < s.Length; i++) Console.Write(s[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Індекс три: " + ArrayHelper.IndexOf(s, "три"));
            Console.WriteLine("Мін: " + ArrayHelper.Min(s));
            Console.WriteLine("Макс: " + ArrayHelper.Max(s));

            ArrayHelper.Reverse(s);
            Console.Write("Реверс: ");
            for (int i = 0; i < s.Length; i++) Console.Write(s[i] + " ");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}