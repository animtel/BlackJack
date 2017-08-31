using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UkadInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VhodPointCircle
            //Point point = new Point(10, 8);
            //Point center = new Point(5, 3);
            //Circle cir = new Circle(center, 5);

            //Console.WriteLine(Vhod(cir, point));
            #endregion

            bool result = Perest("qwerty", "ttrewq");
            Console.WriteLine(result);
        }
        #region VHOD
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public class Circle
        {
            public Point Center { get; set; }
            public int R { get; set; }

            public Circle(Point center, int r)
            {
                Center = center;
                R = r;
            }
        }

        public static string Vhod(Circle cir, Point p)
        {
            double gip = 0;
            gip = Math.Sqrt(Math.Pow((double)(p.X - cir.Center.X), (double)2) + Math.Pow((double)(p.Y - cir.Center.Y), (double)2));
            if (gip < cir.R)
            {
                return "Exist in circle";
            }
            return "Doesn`t exist in circle";
        }
        #endregion

        #region Sort
        public int[] Sort(int[] nums)
        {
            int temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            return nums;
        }
        #endregion

        public static bool Perest(string first_str, string second_str)
        {
            Dictionary<char, int> first_amount = new Dictionary<char, int>();
            Dictionary<char, int> second_amount = new Dictionary<char, int>();

            bool flag = false;
            if (first_str.Length == second_str.Length)
            {
                flag = true;

                for (int i = 0; i < first_str.Length; i++)
                {
                    if (first_amount.ContainsKey(first_str[i]))
                    {
                        first_amount[first_str[i]]++;
                    }
                    else
                    {
                        first_amount.Add(first_str[i], 1);
                    }
                }
                for (int i = 0; i < second_str.Length; i++)
                {
                    if (second_amount.ContainsKey(second_str[i]))
                    {
                        second_amount[second_str[i]]++;
                    }
                    else
                    {
                        second_amount.Add(second_str[i], 1);
                    }
                }
                for (int i = 0; i < first_amount.Count; i++)
                {
                    if (first_amount[first_str[i]] != second_amount[first_str[i]])
                    {
                        flag = false;
                    }
                }
            }
            return flag;
        }
    }
}
