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
            //miniMaxSum(new []{793810624,895642170,685903712,623789054,468592370});
            //var re = kangaroo(4523, 8092, 9419, 8076);
            //var a = new int[5];
            //for (int i= 0; i < a.Length; i++){
            //    a[i] = i;
            //}
            //var re = rotLeft(a, 4);
            //var re = reverseArray(new int[8] { 1,2,3,4,5,6,7,8 });
            //var s = "";
            //foreach (var i in re)
            //{
            //    s = s + " " + i;
            //}
            int[][] a = new int[3][] { new int[] { 4, 9, 2 }, new int[] { 3, 5, 7 }, new int[] { 8, 1, 5 } };
            var f = 0;
            //var s = new List<int>();
            //for (int i = 1; i <= 9; i++)
            //{

            //    s.Add(i);
            //    if (i % 3 == 0)
            //    {
            //        a[f] = s.ToArray();
            //        f++;
            //        s.Clear();
            //    }
            //}
            var re = formingMagicSquare(a);
            //Console.WriteLine(s);
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

        private static test ca = delegate (List<int> list)
        {
            list = list.Select(t => t == 1 ? 0 : t).ToList();
            return list;
        };

        static int diagonalDifference(int[][] arr)
        {
            var li = new List<int[]>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length == arr[i].Length + 1)
                {
                    li.Add(arr[i]);
                }
            }
            int[][] newInts = new int[li.Count][];
            for (int i = 0; i < newInts.Length; i++)
            {
                newInts[i] = li[i];
            }
            var a = 0;
            for (int i = 0; i < newInts.Length; i++)
            {
                for (int j = 0; j < newInts[i].Length; j++)
                {
                    if (i == j)
                    {
                        a = a + newInts[i][j];
                    }
                }
            }
            var b = 0;
            var c = newInts.Length - 1;
            for (int i = 0; i < newInts.Length; i++)
            {
                b = b + newInts[i][c];
                c--;
            }

            if (a > b)
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
                if (ar > 0)
                {
                    p++;
                }
                else if (ar == 0)
                {
                    z++;
                }
                else
                {
                    n++;
                }
            }

            var len = Convert.ToDouble(arr.Length);
            Console.WriteLine($"{p / len}");
            Console.WriteLine($"{n / len}");
            Console.WriteLine($"{z / len}");
        }

        static void staircase(int n)
        {
            var re = "";
            for (int i = 0; i < n + 1; i++)
            {

                if (i == 0)
                {
                    continue;
                }
                for (int x = 0; x < n - i; x++)
                {
                    re = re + " ";
                }
                for (int j = 0; j < i; j++)
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
            Int64[] res = new long[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                res[i] = all - arr[i];
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
                if (g.ToString() == "P")
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
                var aa = Convert.ToInt32(f);
                if (aa < 12)
                {
                    aa = aa + 12;
                    s = s.Replace(f, aa.ToString());
                }

            }
            if (isAm)
            {
                var f = s.Substring(0, 2);
                var aa = Convert.ToInt32(f);
                if (aa >= 12)
                {
                    aa = aa - 12;
                    if (aa == 0)
                    {

                        s = s.Replace(f, "0" + aa.ToString());
                    }
                    else
                    {
                        s = s.Replace(f, aa.ToString());
                    }

                }
            }
            var re = s.Substring(0, 8);
            return re;
        }

        static int[] gradingStudents(int[] grades)
        {
            /*
             * Write your code here.
             */
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= 38)
                {
                    var t = grades[i] % 5;
                    if (t >= 3)
                    {
                        grades[i] = grades[i] + 5 - t;
                    }
                }
            }
            return grades;
        }

        //todo 未完全通过
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            int x = v1;
            int v = v2;
            var re = "NO";
            var x1li = new List<int>();
            var x2li = new List<int>();
            for (int xs = x1; xs <= 10000; xs = xs + x)
            {
                x1li.Add(xs);
            }
            for (int vs = x2; vs <= 10000; vs = vs + v)
            {
                x2li.Add(vs);
            }
            var x1nums = x1li.ToArray();
            var x2nums = x2li.ToArray();
            var x1len = x1nums.Length;
            var x2len = x2nums.Length;
            var max = Math.Min(x1len, x2len);
            for (int i = 0; i < max; i++)
            {
                if (x1nums[i] == x2nums[i])
                {
                    re = "YES";
                    break;
                }
            }
            if (x1 < x2 && v1 <= v2)
            {
                re = "NO";
            }
            return re;
        }

        static int[] rotLeft(int[] a, int d)
        {
            if (d > 0)
            {
                if (d >= a.Length)
                {
                    d = d % a.Length;
                    if (d == 0)
                    {
                        return a;
                    }
                }
                //减法获得
                else if (d > 1000 && a.Length > d)
                {
                    d = d % a.Length;
                    var b = a.ToArray<int>();
                    var c = new List<int>();
                    var e = new List<int>();
                    var g = new List<int>();
                    for (int i = 0; i < d; i++)
                    {
                        c.Add(a[i]);
                    }
                    for (int i = d; i < a.Length; i++)
                    {
                        e.Add(a[i]);
                    }
                    e.AddRange(g);
                    e.AddRange(c);
                    a = e.ToArray<int>();
                    return a;

                }
                var firtstint = 0;
                //递归调用的
                for (int i = 0; i < a.Length; i++)
                {
                    if (i == 0 && a.Length >= 1 && i != a.Length - 1)
                    {
                        firtstint = a[i];
                        a[i] = a[i + 1];
                    }
                    else if (i == a.Length - 1 && a.Length >= 1)
                    {
                        a[i] = firtstint;

                    }
                    else
                    {
                        a[i] = a[i + 1];
                    }
                }
                d = d - 1;
                return rotLeft(a, d);

            }
            else
            {
                return a;
            }
        }
        static int[] reverseArray(int[] a)
        {
            var mid = 0;
            if (a.Length == 1)
            {
                return a;
            }
            else if (a.Length == 2)
            {
                var c = a[0];
                a[0] = a[1];
                a[1] = c;
            }
            else
            {
                var iso = false;
                mid = a.Length / 2;
                if (a.Length % 2 == 0)
                {
                    mid--;
                    iso = true;
                }
                if (iso)
                {
                    var l = mid;
                    var r = mid + 1;
                    while (l >= 0 && r < a.Length)
                    {
                        var c = a[l];
                        a[l] = a[r];
                        a[r] = c;
                        l--;
                        r++;
                    }
                }
                else
                {
                    var l = mid - 1;
                    var r = mid + 1;
                    while (l >= 0 && r < a.Length)
                    {
                        var c = a[l];
                        a[l] = a[r];
                        a[r] = c;
                        l--;
                        r++;
                    }
                }
            }
            return a;
        }
        class xyp
        {
            public xyp(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int x { set; get; }
            public int y { set; get; }
        }
        static int formingMagicSquare(int[][] s)
        {
            var li = new List<int>();
            int[][,] magicSquareList = {new int[3,3]{{8,1,6},{3,5,7},{4,9,2}},
                                       new int[3,3]{{6,1,8},{7,5,3},{2,9,4}},
                                       new int[3,3]{{4,9,2},{3,5,7},{8,1,6}},
                                       new int[3,3]{{2,9,4},{7,5,3},{6,1,8}},
                                       new int[3,3]{{8,3,4},{1,5,9},{6,7,2}},
                                       new int[3,3]{{4,3,8},{9,5,1},{2,7,6}},
                                       new int[3,3]{{6,7,2},{1,5,9},{8,3,4}},
                                       new int[3,3]{{2,7,6},{9,5,1},{4,3,8}}};
            foreach(var m in magicSquareList)
            {
                var num = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < s.Length; j++)
                    {
                        var a = s[i][j];
                        var b = m[i, j];
                        num = num + Math.Abs(a - b);
                    }
                }
                li.Add(num);
            }
           //int[][] t = s;
           //var zn = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
           //var n = new List<int>();
           //var cp = new HashSet<HashSet<xyp>>();
           //var ep = new HashSet<HashSet<xyp>>();
           //var xynum = 0;
           //var yxnum = 0;
           //var xyp = new HashSet<xyp>();
           //var yxp = new HashSet<xyp>();
           //var sum15 = 0;
           //for (int i = 0; i < s.Length; i++)
           //{
           //    var xnum = 0;
           //    var ynum = 0;
           //    var xp = new HashSet<xyp>();
           //    var yp = new HashSet<xyp>();
           //    for (int j = 0; j < s.Length; j++)
           //    {
           //        t[i][j] = s[i][j];
           //        n.Add(s[i][j]);
           //        xnum = xnum + s[i][j];
           //        ynum = ynum + s[j][i];
           //        var xorypoint = new xyp(i, j);
           //        xp.Add(xorypoint);
           //        xorypoint = new xyp(j, i);
           //        yp.Add(xorypoint);
           //        if (i == j)
           //        {
           //            var pp = new xyp(i, j);
           //            xynum = xynum + s[i][j];
           //            xyp.Add(pp);
           //        }

            //    }
            //    for (int j = s.Length - 1; j >= 0; j--)
            //    {
            //        if (i == j && i != 0 && j != s.Length - 1 || Math.Abs(i - j) == s.Length - 1)
            //        {
            //            var pp = new xyp(j, i);
            //            yxnum = yxnum + s[j][i];
            //            yxp.Add(pp);
            //        }
            //    }
            //    judge(xynum, cp, ep, xyp, sum15);
            //    judge(yxnum, cp, ep, yxp, sum15);
            //    judge(xnum, cp, ep, xp, sum15);
            //    judge(ynum, cp, ep, yp, sum15);
            //}
            //if (sum15 == 8)
            //{
            //    return 0;
            //}
            //else
            //{
            //    n = n.ToList();
            //    n = n.Distinct().ToList();
            //    var noc = (from nt in n from zt in zn.ToList<int>() where !n.Contains(zt) select zt).Distinct().ToList();
            //    foreach (var j in ep)
            //    {
            //        var num = 0;
            //        foreach (var f in j)
            //        {
            //            foreach (var i in noc)
            //            {
            //                var pass = true;
            //                foreach (var c in cp)
            //                {
            //                    pass = !c.Contains(f);
            //                    if (pass)
            //                    {
            //                        break;
            //                    }
            //                }
            //                if (!pass)
            //                {
            //                    s[f.x][f.y] = i;
            //                }
            //            }
            //            num = num + s[f.x][f.y];
            //        }
            //        if (num == 15)
            //        {
            //            ep.Remove(j);
            //            cp.Add(j);
            //        }

            //    }
            //}
            return li.Min();
        }
        //static void judge(int num, HashSet<HashSet<xyp>> pp, HashSet<HashSet<xyp>> ep, HashSet<xyp> p, int sum)
        //{
        //    if (num == 15)
        //    {
        //        pp.Add(p);
        //        sum++;
        //    }
        //    else
        //    {
        //        ep.Add(p);
        //    }
        //}
    }
}
