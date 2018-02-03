using System;

namespace Trial
{
    class Program
    {
        static string[] Twins(string[] a, string[] b)
        {
            int indexLenth = 0;
            if (a.Length > b.Length)
            {
                indexLenth = a.Length;
            }
            else
            {
                indexLenth = b.Length;
            }
            string[] result = new string[indexLenth];
            for (int counter = 0; counter < indexLenth; counter++)
            {
                result[counter] = "NO";
            }
            for (int countArrayA = 0; countArrayA < a.Length; countArrayA++)
            {
                if (countArrayA+1 <= b.Length)
                {
                    var tempA = a[countArrayA].ToCharArray();
                    var tempB = b[countArrayA].ToCharArray();
                    var areEqual = true;
                    for (int counterstra = 0; counterstra < tempA.Length; counterstra++)
                    {
                        if (counterstra < tempB.Length && tempA[counterstra] != tempB[counterstra])
                        {
                            areEqual = false;
                            for (int counterForCaracter = counterstra; counterForCaracter < b[countArrayA].Length; counterForCaracter += 2)
                            {
                                if (tempA[counterstra] == tempB[counterForCaracter])
                                {
                                    Swap(tempB, counterstra, counterForCaracter);
                                    areEqual = true;
                                    break;
                                }
                            }
                        }
                        else if (tempA[counterstra] != tempB[counterstra])
                        {
                            areEqual = false;
                        }
                    }
                    if (areEqual)
                    {
                        result[countArrayA] = "YES";
                    }
                }
            }
            return result;

        }
        static void Swap(char[] a, int baseIndex, int newIndex)
        {
            var temp = a[baseIndex];
            a[baseIndex] = a[newIndex];
            a[newIndex] = temp;
        }
        static void Main(String[] args)
        {
            string[] res;

            int _a_size = 0;
            _a_size = Convert.ToInt32(Console.ReadLine());
            string[] _a = new string[_a_size];
            string _a_item;
            for (int _a_i = 0; _a_i < _a_size; _a_i++)
            {
                _a_item = Console.ReadLine();
                _a[_a_i] = _a_item;
            }


            int _b_size = 0;
            _b_size = Convert.ToInt32(Console.ReadLine());
            string[] _b = new string[_b_size];
            string _b_item;
            for (int _b_i = 0; _b_i < _b_size; _b_i++)
            {
                _b_item = Console.ReadLine();
                _b[_b_i] = _b_item;
            }

            res = Twins(_a, _b);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
        }
    }
}