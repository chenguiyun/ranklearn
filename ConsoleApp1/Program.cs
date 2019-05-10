using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        private static List<int> tList = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        static void Main(string[] args)
        {
            //var time = DateTime.Parse("2016-02-29").AddYears(-1);
            //Console.WriteLine(""+time);
            //var num = new[] {3,0,1,0};
            //int a = 1;
            //var re= ccc();
            //var aaa = tList.Select(t => t == 1 ? 0 : t).ToList();
            //var aaa=ca(tList);
            //var bbb = tList;
            ////int[][] array = new int[4][];
            ////array[0] =new []{3};
            ////array[1] = new[] { 11,2,4 };
            ////array[2] = new[] { 4,5,6 };
            ////array[3] = new[] { 10,8,-12 };
            ////diagonalDifference(array);
            ////staircase(6);
            //timeConversion("12:40:22AM");
            miniMaxSum(new []{793810624,895642170,685903712,623789054,468592370});
            Console.WriteLine();
            Console.ReadKey();
        }

        public static IList<int> TopKFrequent(int[] nums, int k)
        {
            List<int> re = new List<int>();
            var a = nums.Distinct();
            var f = new int[a.Count(), 2];
            int index = 0;
            foreach (var c in a)
            {
                var b = nums.Count(t => t.Equals(c));
                f[index, 1] = c;
                f[index, 2] = b;

            }

            for (int i = 0; i < f.Length; i++)
            {
                var bc = 0;
                var bb = 0;
                var nc = f[i, 1];
                var nb = f[i, 2];
            }

            if (re.Count == 0)
            {
                re = nums.ToList();
            }

            return re;
        }

//        public static double ccc()
//        {
//            var score = 0;
//            var p = 54.55;
//            if (p >= 80.0)
//            {
//                score = 10;
//            }
//            else if (p >= 70.0 && p < 80.0)
//            {
//                score = 8;
//            }
//            else if (p >= 60.0 && p < 70.0)
//            {
//                score = 6;
//            }
//            else if (p >= 50.0 && p < 60.0)
//            {
//                score = 4;
//            }
//            else
//            {
//                score = 0;
//            }

//;
//        }

        delegate List<int> test(List<int> list);

        private static test ca = delegate(List<int> list)
        {
            list= list.Select(t => t == 1 ? 0 : t).ToList();
            return list;
        };

        static int diagonalDifference(int[][] arr)
        {
            var li = new List<int[]>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length == arr[i].Length+1)
                {
                    li.Add(arr[i]);
                }
            }
            int[][] newInts=new int[li.Count][];
            for (int i = 0; i < newInts.Length; i++)
            {
                newInts[i] = li[i];
            }
            var a = 0;
            for (int i = 0; i < newInts.Length; i++)
            {
                for (int j = 0; j < newInts[i].Length; j++)
                {
                    if (i==j)
                    {
                        a = a + newInts[i][j];
                    }
                }
            }
            var b = 0;
            var c = newInts.Length - 1;
            for (int i = 0; i < newInts.Length; i++)
            {
                b = b+newInts[i][c];
                c--;
            }

            if (a>b)
            {
                return a - b;
            }
            else
            {
                return b - a;
            }

        }

        static void plusMinus(int[] arr)
        {
            var p = 0;
            var n = 0;
            var z = 0;
            foreach (var ar in arr)
            {
                if (ar>0)
                {
                    p++;
                }
                else if (ar==0)
                {
                    z++;
                }
                else
                {
                    n++;
                }
            }

            var len = Convert.ToDouble(arr.Length);
            Console.WriteLine($"{p/len}");
            Console.WriteLine($"{n / len}");
            Console.WriteLine($"{z / len}");
        }

        static void staircase(int n)
        {
            var re = "";
            for (int i = 0; i <n+1; i++)
            {

                if (i==0)
                {
                    continue;
                }
                for (int x = 0; x < n - i; x++)
                {
                    re = re + " ";
                }
                for (int j = 0; j <i; j++)
                {
                    re = re + "#";
                }
                Console.WriteLine(re);
                re = "";
            }
        }

        static void miniMaxSum(int[] arr)
        {
            Int64 min = 0;
            Int64 max = 0;
            Int64 all = 0;
            foreach (var a in arr)
            {
                all = all + a;
            }
            Int64[] res=new long[]{1,2,3,4,5};
            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = all-arr[i];
            }
            min = res.Min();
            max = res.Max();
            Console.Write($"{min} {max}");
        }

        static int birthdayCakeCandles(int[] ar)
        {
            var re = 0;
            var li = ar.ToList();
            li.Sort();
            re = li.Count(t => t.Equals(li[li.Count - 1]));
            return re;
        }

        static string timeConversion(string s)
        {
            /*
             * Write your code here.
             */
            bool ispm = false;
            bool isAm = false;
            foreach (var g in s)
            {
                if (g.ToString()=="P")
                {
                    ispm = true;
                }
                if (g.ToString() == "A")
                {
                    isAm = true;
                }
            }
            if (ispm)
            {
                var f = s.Substring(0, 2);
                var aa= Convert.ToInt32(f);
                if (aa<12)
                {
                    aa = aa + 12;
                    s=s.Replace(f,aa.ToString());
                }

            }
            if (isAm)
            {
                var f = s.Substring(0, 2);
                var aa = Convert.ToInt32(f);
                if (aa >= 12)
                {
                    aa = aa - 12;
                    if (aa==0)
                    {

                        s = s.Replace(f, "0" + aa.ToString());
                    }
                    else
                    {
                        s = s.Replace(f, aa.ToString());
                    }

                }
            }
            var re = s.Substring(0,8);
            return re;
        }

        static int[] gradingStudents(int[] grades)
        {
            /*
             * Write your code here.
             */
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i]>=38)
                {
                    var t = grades[i] % 5;
                    if (t>=3)
                    {
                        grades[i] = grades[i] + 5 - t;
                    }
                }
            }
            return grades;
        }
    }
}
