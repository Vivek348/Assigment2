using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine("");
            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");
            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 3,3 };
            int target = 6;
            TwoSum(ar4, target);
            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
                Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
            {
                Console.WriteLine("{0} is a happy number", n8);
            }
            else
            {
                Console.WriteLine("{0} is not a happy number", n8);
            }
            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
            {
                Console.WriteLine("Profit is {0}", profit);
            }
            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine("");
        }
        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                //For filtering out the negative values of the given input and even length of the array.
                if (nums.Length%2==0 && n>0&&nums.Length/2==n)
                {
                    var result = new int[nums.Length];
                    int j = 0;
                    int k = n;
                    for (int i = 0; i < n; i++)
                    {
                        //rearraging the array by Shuffling in 2n elements
                        result[j++] = nums[i];
                        result[j++] = nums[k++];
                    }
                    Array.ForEach(result, Console.Write);//Printing the output.
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a Valid input of 2n elements and n>0");
            }
        }
        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                int j = 0;
                int n = ar2.Length;
                for (int i = 0; i < n; i++)
                {
                    if(ar2[i]!=0)
                    {
                        //Arraging the non zero elements to starting of the array without changing the placement.
                        ar2[j++] = ar2[i];
                    }
                }
                for (int k = j; k < n; k++)
                {
                    //After the non zero elements adding zero upto length of the array.
                    ar2[k] = 0;
                }
                Array.ForEach(ar2, Console.Write);
            }
            catch (Exception)
            { 
                throw;
            }
        }
        private static void CoolPairs(int[] nums)
        {
            try
            {
                //This is the normal coding with complexity O(n*n)
                //int count = 0;
                //for(int i=0;i<nums.Length;i++)
                //{
                //    for (int j=i+1;j<nums.Length;j++)
                //    {
                //        if(nums[i]==nums[j])
                //        {
                //            count++;
                //        }
                //    }
                //}

                //By using the dictionary we can reduce the complexity to O(n)
                Dictionary<int, int> dict = new Dictionary<int, int>();
                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (dict.ContainsKey(nums[i]))//Checking if the element present in the dictionary
                    {
                        count += dict[nums[i]];
                        dict[nums[i]]++;
                    }
                    else
                    {
                        dict.Add(nums[i], 1);//Adding into the dictionary
                    }
                }
                Console.WriteLine(count);//Printing the result.
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void TwoSum(int[] nums, int target)
        {
            try
            {
                Dictionary<int, int> Dict = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    //subtracting the each elements to the target and checking if the remaining value existing the the given input.
                    int d = target - nums[i];
                    if (Dict.ContainsKey(d))
                        Console.WriteLine(Dict[d]+" "+i);
                    else if (!Dict.ContainsKey(nums[i]))
                        Dict.Add(nums[i], i);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void RestoreString(string s5, int[] indices)
        {
            try
            {
                //For filtering out the negative values of the given input and checking if the length of the array and given max of indices value is equal or not
                bool containsNegative = indices.Any(i => i < 0);
                if (!containsNegative &&s5.Length-1==indices.ToList().Max())
                {
                    var result = new char[s5.Length];
                    for (int i = 0; i < s5.Length; i++)
                    {
                        //According to the indices we will re-arrage the given input.
                        result[indices[i]] = s5[i];
                    }
                    Console.WriteLine(new string(result));//Printing the result
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a Correct indices ranging from 0 to length of the array");
            }
        }
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                //Both given inputs should be of same length.
                if (s1.Length != s2.Length)
                {
                    return false;
                }
                var dic1 = new Dictionary<char, char>();
                var dic2 = new Dictionary<char, char>();
                for (int i = 0; i < s1.Length; i++)
                {
                    if (!dic1.ContainsKey(s1[i]))
                    {
                        dic1.Add(s1[i], s2[i]);
                        if (dic2.ContainsKey(s2[i]))
                        {
                            return false;
                        }
                        dic2.Add(s2[i], s1[i]);
                    }
                    else if(dic1[s1[i]] != s2[i])
                    {
                         return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void HighFive(int[,] items)
        {
            try
            {
                if (items.GetLength(0) > 100)
                {
                    throw new Exception();
                }
                //Checking that the items should more than one and less than 1000
                if (items.Length<=1000 &&items.Length>=1)
                {
                    Dictionary<int, List<int>> some = new Dictionary<int, List<int>>();
                    for (int i = 0; i < items.GetLength(0); i++)
                    {
                        if (some.ContainsKey(items[i, 0]))
                        {
                            List<int> lListNew = some[items[i, 0]];
                            if (items[i, 1] > 100 || items[i, 1] < 0)
                            {
                                throw new Exception();
                            }
                            else
                            {
                                lListNew.Add(items[i, 1]);
                                some[items[i, 0]] = lListNew;
                            }
                        }
                        else
                        {
                            List<int> val = new List<int>();
                            if (items[i, 1] > 100 || items[i, 1] < 0)
                            {
                                throw new Exception();
                            }
                            else
                            {
                                val.Add(items[i, 1]);
                                some.Add(items[i, 0], val);
                            }
                        }
                    }
                    if (some.Count > 1000 || some.Count == 1)
                    {
                        throw new Exception();
                    }
                    foreach (KeyValuePair<int, List<int>> entry in some)
                    {
                        if (entry.Value.Count < 5)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            var a = entry.Value;
                            //Sorting the dictionary
                            a.Sort();
                            //Reversing the dictionary
                            a.Reverse();
                            var b = a.GetRange(0, 5);
                            //Printing out the student ID and their respective average.
                            Console.WriteLine((entry.Key, b.Sum() / 5));
                        }
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private static bool HappyNumber(int n)
        {
            try
            {
                /*Creating a hashset to store the values of all the unique elements to 
                 understand if a value repeats again and put it in infinite loop*/
                if (n == 1)
                {
                    return true;
                }
                if (n < 1 || n > Math.Pow(2, 31))
                {
                    return false;
                }
                HashSet<int> hset = new HashSet<int>() { n };
                while (n != 1)
                {
                    int sum = 0;
                    while (n > 0)
                    // Getting the divident and adding it to sum and also dividing the value by 10 
                    {
                        int d = n % 10;
                        sum += d * d;
                        n /= 10;
                    }
                    if (!hset.Add(sum))
                    {
                        return false;
                    }
                    n = sum;//updating the sum
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static int Stocks(int[] prices)
        {
            try
            {
                //Checking if the prices is null or empty input then return zero.
                if (prices == null || prices.Length == 0)
                {
                    return 0;
                }
                int min = prices[0];
                int maxProfit = 0;
                for (int i = 1; i < prices.Length; i++)
                {
                    maxProfit = Math.Max(maxProfit, prices[i] - min);//Checking for the profit
                    min = Math.Min(min, prices[i]);
                }
                return maxProfit;//returning the max profit.
            }
            catch (Exception)
            {
                throw;
            }
        }
        private static void Stairs(int n10)
        {
            try
            {
                //Filtering out the negative values
                if (n10 > 0)
                {
                    if (n10 == 1 || n10 == 0)
                    {
                        Console.WriteLine(1);//if stairs one or zero print 1
                    }
                    int[] steps = new int[n10 + 1];
                    steps[0] = 1;
                    steps[1] = 1;
                    int result = 0;
                    for (int i = 2; i <= n10; i++)
                    {
                        //Storing in the array for future use like dynammic programming bottom up tabulation method.
                        result = steps[i - 1] + steps[i - 2];
                        steps[i] = result;
                    }
                    Console.WriteLine(result);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter the valid stairs");
            }
        }
    }
}