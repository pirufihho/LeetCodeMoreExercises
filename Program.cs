﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

// Creating a linkedlist
// Using LinkedList class
LinkedList<String> my_list = new LinkedList<String>();

// Adding elements in the LinkedList
// Using AddLast() method
my_list.AddLast("Zoya");
my_list.AddLast("Shilpa");
my_list.AddLast("Rohit");
my_list.AddLast("Rohan");
my_list.AddLast("Juhi");
my_list.AddLast("Zoya");

//my_list.Remove(my_list.First);
//my_list.Remove("Rohit");
//my_list.RemoveFirst();

if (my_list.Contains("Shilpa") == true)
{
    Console.WriteLine("Element Found...!!");
}

Console.WriteLine("Best students of XYZ university:");

// Accessing the elements of
// LinkedList Using foreach loop
foreach (string str in my_list)
{
    Console.WriteLine(str);
}


int[] nums = { 1,2,3,4,5,6 };
int target = 9;

TwoSum(nums, target);

string s = "MCMXCIV";
RomanToInt(s);

int[] nums2 = { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 };
LongestConsecutive(nums2);

long num = 4;
SumOfThree(num);

int[] nums3 = { 1, 2, 3, 4 };
ProductExceptSelf(nums3);
ProductExceptSelf2(nums3);

string s2 = "(){}}{";
IsValid(s2);

int[] nums4 = { 1, 1, 2 };
RemoveDuplicates(nums4);

string s3 = "a";
LengthOfLastWord(s3);

int[] digits = { 9,9};
PlusOne(digits);
PlusOne2(digits);

string a = "1111", b = "1111";
AddBinary(a, b);

int x = 1000;
//MySqrt(x);
MySqrt2(x);

int[] _nums1 = { 0 };
int[] _nums2 = { 1 };
int m = 0;
int n = 1;
Merge(_nums1,m,_nums2,n);

int n2 = 5;
CountBits(n2);

int n3 = 3;
Fib(n3);

string[] strs = { "abab","aba","" };
LongestCommonPrefix(strs);

string s4 = "0P";
IsPalindrome(s4);

int n5 = 2;
IsHappy(n5);

int numRows = 1;
Generate(numRows);

int[] nums5 = { 2, 2, 1 };
SingleNumber(nums5);

int rowIndex = 3;
GetRow(rowIndex);

int[] nums6 = { 1 };
MajorityElement(nums6);

uint n4 = 43261596;
reverseBits(n4);

uint n6 = Convert.ToUInt32("11111111111111111111111111111101", 2);
HammingWeight(n6);

int[] nums7 = { 1, 2, 3, 1 };
ContainsDuplicate(nums7);

int[] nums8 = { 1, 0, 1, 1 };
int k = 1;
ContainsNearbyDuplicate(nums8, k);

int[] nums9 = { };
SummaryRanges(nums9);

int n7 = 134217727;
IsPowerOfTwo(n7);

int num8 = 38;
AddDigits(num8);

int[] nums10 = { 1 };
MissingNumber(nums10);

int[] nums11 = { 0, 1, 0, 3, 12};
MoveZeroes(nums11);

string s1 = "ab", t = "ab";
IsIsomorphic(s1,t);

string ransomNote = "bg", magazine = "efjbdfbdgfjhhaiigfhbaejahgfbbgbjagbddfgdiaigdadhcfcj";
CanConstruct(ransomNote, magazine);

string pattern = "aba", s10 = "cat cat cat dog";
wordPattern(pattern,s10);

int n11 = 129140162;
IsPowerOfThree(n11);

int n12 = 16;
IsPowerOfFour(n12);

char[] s12 = { 'h', 'e', 'l', 'l', 'o' };
ReverseString(s12);

string s13 = "aA";
ReverseVowels(s13);

int[] nums12 = { 1, 2, 2, 1 }, nums13 = { 2, 2 };
Intersection(nums12,nums13);


int[] nums14 = { 4, 9, 5 }, nums15 = { 9, 4, 9, 8, 4 };
Intersect(nums14,nums15);

int num15 = 1;
IsPerfectSquare(num15);

string s5 = "leetcode";
FirstUniqChar(s5);

string s6 = "ae", t6 = "aea";
FindTheDifference(s6, t6);

string s7 = "leeeeetcode", t7 = "leeeeetcode";
IsSubsequence(s7, t7);

int n13 = 3;
FizzBuzz(n13);

int[] nums16 = { 3, 2, 1 };
ThirdMax(nums16);

string num1 = "0", num2 = "0";
AddStrings(num1, num2);

string s18 = "                ";
CountSegments(s18);

int n18 = 2;
ArrangeCoins(n18);

int[] nums17 = { 2,2 };
FindDisappearedNumbers(nums17);

string s19 = "abab";
RepeatedSubstringPattern(s19);

int x1 = 3, y1 = 1;
HammingDistance(x1, y1);

int num22 = 5;
FindComplement(num22);

int[] nums23 = { 1, 1, 0, 1, 1, 1 };
FindMaxConsecutiveOnes(nums23);

int[] timeSeries = { 1, 4 };
int duration = 2;
FindPoisonedDuration(timeSeries, duration);

int FindPoisonedDuration(int[] timeSeries, int duration)
{
    int poisonedSecs = 0;
    int lastIndex = timeSeries.Last() * duration;

    for (int i = 0; i < timeSeries.Length; i++)
    {
        if(i == 0)
        {
            poisonedSecs += 2;
        }
        else
        {
            if (timeSeries[i] - timeSeries[i - 1] == 1)
            {
                poisonedSecs += 1;
            }
            else
            {
                poisonedSecs += 2;
            }
        }
        
    }


    return poisonedSecs;
}

int FindMaxConsecutiveOnes(int[] nums)
{
    int maxOnes = 0;
    int result = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 1)
        {
            maxOnes++;

            if(maxOnes >= result)
            {
                result = maxOnes;
            }
        }
        else
        {
            maxOnes = 0;
        }
    }

    return result;
}

int FindComplement(int num)
{
    string binary = Convert.ToString(num, 2);

    string result = "";

    for (int i = 0; i < binary.Length; i++)
    {
        if(binary[i] == '0')
        {
            result = result + '1';
        }
        else
        {
            result = result + '0';
        }
    }
    int res = Convert.ToInt32(result, 2);


    return res;
}

int HammingDistance(int x, int y)
{
    string binaryX = ToBinary(x);
    string binaryY = ToBinary(y);

    int hamming = 0;

    for (int i = 0; i < binaryX.Length; i++)
    {
        if (binaryX[i] != binaryY[i])
        {
            hamming++;
        }
    }

    return hamming;
}

static string ToBinary(int x)
{
    char[] buff = new char[32];

    for (int i = 31; i >= 0; i--)
    {
        int mask = 1 << i;
        buff[31 - i] = (x & mask) != 0 ? '1' : '0';
    }

    return new string(buff);
}

bool RepeatedSubstringPattern(string s)
{
    int len = s.Length;

    for (int i = 1; i <= len/2; i++)
    {
        if(len % i == 0)
        {
            int num_repeats = len / i;
            string subsTring = s.Substring(0, i);
            StringBuilder sb = new StringBuilder(); 
            for (int j = 0; j < num_repeats; j++)
            {
                sb.Append(subsTring);
            }
            if(sb.ToString().Equals(s)) return true;
        }
    }   
    return false;
}

IList<int> FindDisappearedNumbers(int[] nums)
{
    List<int> result = new List<int>();
    List<int> ordered = new List<int>();
    ordered = nums.OrderBy(x => x).ToList();

    Dictionary<int, int> map = new Dictionary<int, int>();

    for (int i = 1; i < ordered.Count; i++)
    {
        if(ordered[i]-ordered[i-1] == 1 || ordered[i] - ordered[i - 1] == 0)
        {

        }
        else
        {
            map.Add(ordered[i-1],ordered[i]);
        }

    }

    foreach (var item in map)
    {
        int startIndex = item.Key;
        int finishIndex = item.Value;

        for (int i = startIndex+1; i < finishIndex; i++)
        {
            result.Add(i);
        }
    }
    if(map.Count == 0)
    {
        if (ordered.FirstOrDefault() == 2 && ordered.LastOrDefault() == 2) { 
            result.Add(1);
        }
        else
        {
            result.Add(ordered.LastOrDefault() + 1);
        }
        
    }

    return result;
}

int ArrangeCoins(int n)
{
    int coins = n;

    if(n == 1)
    {
        return 1;
    }

    if (n == 2)
    {
        return 1;
    }

    for (int i = 1; i < n; i++)
    {
        coins = coins - i;

        if(coins == 0)
        {
            return i;
        }
        if(coins < 0)
        {
            return i - 1;
        }
    }

    return 0;
}

int CountSegments(string s)
{
    if(s == "")
    {
        return 0;
    }

    var splited = s.Split(" ");
    List<string> result = new List<string>();

    for (int i = 0; i < splited.Length; i++)
    {
        if(splited[i] != "")
        {
            result.Add(splited[i]);
        }
    }

    return result.Count();
}

string AddStrings(string num1, string num2)
{

    string result = "";

    if (num1.Length > num2.Length)
    {
        int missing0 = num1.Length - num2.Length;

        for (int i = 0; i < missing0; i++)
        {
            num2 = num2.Insert(0,"0");
        }
    }
    else
    {
        int missing0 = num2.Length - num1.Length;

        for (int i = 0; i < missing0; i++)
        {
            num1 = num1.Insert(0,"0");
        }
    }
    bool addOne = false;

    for (int i = num1.Length-1; i >= 0; i--)
    { 
        double n1 = char.GetNumericValue(num1[i]);
        double n2 = char.GetNumericValue(num2[i]);

        double sum = (addOne) ? n1 + n2 + 1 : n1 + n2;
        if (sum > 9)
        {
            addOne = true;
            sum = sum - 10;
        }
        else
        {
            addOne = false;
        }

        result = result.Insert(0, Convert.ToString(sum));
    }

    if (addOne)
    {
        result = result.Insert(0, "1");
    }

    return result;
}

int ThirdMax(int[] nums)
{
    List<int> result = nums.ToList().Distinct().ToList();
    result.Sort();

    for (int i = result.Count-1; i >= 0; i--)
    {
        if(i == result.Count -3)
        {
            return result[i];
        }
    }

    return result.LastOrDefault();
}

IList<string> FizzBuzz(int n)
{
    List<string> list = new List<string>();

    for (int i = 1; i <= n; i++)
    {
        bool divisibleBy3 = (i % 3 == 0);
        bool divisibleBy5 = (i % 5 == 0);

        if (divisibleBy3 && divisibleBy5)
        {
            list.Add("FizzBuzz");
        }
        else if (divisibleBy3)
        {
            list.Add("Fizz");
        }
        else if (divisibleBy5)
        {
            list.Add("Buzz");
        }
        else
        {
            list.Add(Convert.ToString(i));
        }
    }

    return list;
}

    bool IsSubsequence(string s, string t)
{
    Dictionary<int, char> result = new Dictionary<int, char>(); 

    var lastIndex = 0;
    
    for (var i = 0; i < s.Length; i++)
    {
        for (int j = 0; j < t.Length; j++)
        {
            if(s[i] == t[j])
            {
                if (!result.ContainsKey(j))
                {
                    if (j >= lastIndex)
                    {
                        lastIndex = j;
                        result.Add(j, t[j]);
                    }
                }
            }
        }
    }

    if(result.Count == s.Length)
    {
        return true;
    }

    return false;
}

char FindTheDifference(string s, string t)
{
    var orderS = s.OrderBy(s => s).ToList();
    var ordetT = t.OrderBy(t => t).ToList();

    for (int i = 0; i < orderS.Count(); i++)
    {
        if(orderS[i] != ordetT[i])
        {
            return ordetT[i];
        }
    }

    return ordetT.LastOrDefault();
}

int FirstUniqChar(string s)
{
    Dictionary<int, char> result = new Dictionary<int, char>();
    List<char> listChar = s.ToList();

    for (int i = 0; i < s.Length; i++)
    {
        result.Add(i,s[i]);
    }

    List<char> listOneOcur = new List<char>();

    var grouPed = result.GroupBy(x => x.Value);

    foreach (var grou in grouPed)
    {
        if(grou.Count() == 1)
        {
            return grou.FirstOrDefault().Key;
        }
    }

    return -1;
}

bool IsPerfectSquare(int num)
{
    if (num == 1) { return true; }

    for (int i = 0; i < num; i++)
    {
        if (i * i == num) { return true; }

        if (i * i > num) { return false; }
    }

    return false;
}

int[] Intersect(int[] nums1, int[] nums2)
{
    //find longest array
    int[] longestArray = nums1.Length > nums2.Length ? nums1 : nums2;
    int[] shortestArray = nums1.Length < nums2.Length ? nums1 : nums2;

    Dictionary<int,int> interSection = new Dictionary<int,int>();
    int index = 0;

    for (int i = 0; i < shortestArray.Length; i++)
    {
        for (int j = 0; j < longestArray.Length; j++)
        {
            if (shortestArray[i] == longestArray[j])
            {
                
                //if (interSection.GetValueOrDefault(shortestArray[i]) != shortestArray[i])
                //{
                    interSection.Add(index++, shortestArray[i]);
                //}
                
            }
        }
    }

    List<int> result = new List<int>();

    foreach (var value in interSection)
    {
        result.Add(value.Key);
    }

    return result.ToArray();
}

int[] Intersection(int[] nums1, int[] nums2)
{
    //find longest array
    int[] longestArray = nums1.Length > nums2.Length ? nums1 : nums2;
    int[] shortestArray = nums1.Length < nums2.Length ? nums1 : nums2;

    List<int> interSection = new List<int>();

    for (int i = 0; i < shortestArray.Length; i++)
    {
        for (int j = 0; j < longestArray.Length; j++)
        {
            if(shortestArray[i] == longestArray[j])
            {
                interSection.Add(shortestArray[i]);
            }
        }
    }

    return interSection.Distinct().ToArray();
}

string ReverseVowels(string s)
{
    Stack<char> vowels = new Stack<char>();
    for (int i = 0; i < s.Length; i++)
    {
        if(s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u'
            || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
        {
            vowels.Push(s[i]);
        }
    }

    List<char> reversed = s.ToCharArray().ToList();

    for (int i = 0; i < reversed.Count; i++)
    {
        if (reversed[i] == 'a' || reversed[i] == 'e' || reversed[i] == 'i' || reversed[i] == 'o' || reversed[i] == 'u'
            || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
        {
            reversed[i] = vowels.Pop();
        }
    }


    return new string(reversed.ToArray());
}

void ReverseString(char[] s)
{
    Array.Reverse(s);

}

bool IsPowerOfFour(int n)
{
    double powerOfFour = 0;
    for (int i = 0; i < n; i++)
    {
        powerOfFour = Math.Pow(4, i);
        if (powerOfFour == n) { return true; }

        if (powerOfFour > n) { return false; }
    }

    return false;

}

bool IsPowerOfThree(int n)
{
    double powerOfThree = 0;
    for (int i = 0; i < n; i++)
    {
        powerOfThree = Math.Pow(3,i);
        if(powerOfThree == n) { return true; }

        if(powerOfThree > n) { return false; }
    }

    return false;
}

bool wordPattern(string pattern, string s)
{
    string[] splitWords = s.Split(' ');
    Dictionary<string,int> ocurrences = new Dictionary<string,int>();
    ocurrences.Add(splitWords[0],1);

    for (int i = 1; i < splitWords.Length; i++)
    {
        if (ocurrences.ContainsKey(splitWords[i]))
        {
            var val = ocurrences[splitWords[i]];
            ocurrences[splitWords[i]] = val+1;
        }
        else
        {
            ocurrences.Add(splitWords[i],1);
        }
    }

    var getGroupedChars = pattern.GroupBy(x => x);
    int countGroup = 0;

    foreach (var item in getGroupedChars)
    {
        countGroup++;
    }

    if(countGroup == ocurrences.Count())
    {
        return true;
    }
    return false;
}


bool CanConstruct(string ransomNote, string magazine)
{
    Dictionary<char, int> ransomChars = new Dictionary<char, int>();
    Dictionary<char, int> magazineChars = new Dictionary<char, int>();

    for (int i = 0; i < ransomNote.Length; i++)
    {
        if (ransomChars.ContainsKey(ransomNote[i]))
        {
            ransomChars[ransomNote[i]] = ransomChars.GetValueOrDefault(ransomNote[i]) + 1;
        }
        else
        {
            ransomChars.Add(ransomNote[i], 1);
        }

    }

    for (int i = 0; i < magazine.Length; i++)
    {
        if (magazineChars.ContainsKey(magazine[i]))
        {
            magazineChars[magazine[i]] = magazineChars.GetValueOrDefault(magazine[i]) + 1;
        }
        else
        {
            magazineChars.Add(magazine[i], 1);
        }
    }

    for (int i = 0; i < ransomNote.Length; i++)
    {
        var valueRansom = ransomChars.GetValueOrDefault(ransomNote[i]);
        var valueMagazine = magazineChars.GetValueOrDefault(ransomNote[i]);

        if (valueRansom > valueMagazine)
        {
            return false;
        }
    }

    return true;
}

//not working
bool IsIsomorphic(string s, string t)
{
    Dictionary<char, int> sChars = new Dictionary<char, int>();
    Dictionary<char, int> tChars = new Dictionary<char, int>();

    for (int i = 0; i < s.Length; i++)
    {
        if (sChars.ContainsKey(s[i]))
        {
            sChars[s[i]] = sChars.GetValueOrDefault(s[i]) +1;
        }
        else
        {
            sChars.Add(s[i], 1);
        }

    }

    for (int i = 0; i < t.Length; i++)
    {
        if (tChars.ContainsKey(t[i]))
        {
            tChars[t[i]] = tChars.GetValueOrDefault(t[i]) + 1;
        }
        else
        {
            tChars.Add(t[i], 1);
        }
    }

    for (int i = 0; i < sChars.Count; i++)
    {
        var elementS = sChars.ElementAt(i);
        var elementT = tChars.ElementAt(i);

        if(elementS.Value != elementT.Value)
        {
            return false;
        }
    }

    return true;
}

void MoveZeroes(int[] nums)
{

    //count the zeroes
    int numZeroes = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == 0)
        {
            numZeroes++;
        }
    }

    // Make all the non-zero elements retain their original order.
    List<int> newArray = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] != 0)
        {
            newArray.Add(nums[i]);      
        }
    }

    //move all the zeroes to the end
    while (numZeroes!=0)
    {
        numZeroes--;
        newArray.Add(0);
    }

    //combine the result
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = newArray[i];
    }
}

int MissingNumber(int[] nums)
{
    Array.Sort(nums);
    int missingNumber = 0;
    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (nums[i + 1] - nums[i] == 1)
        {

        }
        else
        {
            missingNumber = i + 1;
        }
    }

    if (missingNumber == 0)
    {
        missingNumber = nums.Last() + 1;
    }

    if(nums.Length == 1)
    {
        if(nums.Last() == 0)
        {
            missingNumber = 1;
        }
        if(nums.Last() == 1)
        {
            missingNumber = 0;
        }
    }

    if (nums.First() != 0)
    {
        missingNumber = 0;
    }


    return missingNumber;
}

int AddDigits(int num)
{
    string numS = Convert.ToString(num);

    while (numS.Length != 1)
    {
        var Num = 0;
        for (int i = 0; i < numS.Length; i++)
        {
            Num += int.Parse(numS[i].ToString());
        }
        numS = Convert.ToString(Num);
    }

    return 0;
}

bool IsPowerOfTwo(int n)
{
    if (n == 0)
    {
        return false;
    }
    long i = 1;
    while (i <= n)
    {
        if (i == n) return true;
        i = i * 2;
    }
    return false;
}

IList<string> SummaryRanges(int[] nums)
{
    IList<string> result = new List<string>();
    //number - range
    Dictionary<int, int> counts = new Dictionary<int, int>();

    if(nums.Length == 0)
    {
        return result;
    }

    int range = 0;
    counts.Add(nums[0], range);
    for (int i = 1; i < nums.Length; i++)
    {
        if(nums[i] - nums[i-1] == 1)
        {
            counts.Add( nums[i],range);
        }
        else
        {
            range++;
            counts.Add(nums[i],range);
        }
    }

    var grouped = counts.GroupBy(x => x.Value);

    for (int i = 0; i < grouped.ToList().Count; i++)
    {
        var test = grouped.ElementAt(i);
        string rangeString = "";

        if (test.First().Key != test.Last().Key)
        {
            rangeString =  test.First().Key.ToString() + "->" + test.Last().Key.ToString();
        }
        else
        {
            rangeString = test.First().Key.ToString();
        }
         
        result.Add(rangeString);
    }

    return result;
}

bool ContainsNearbyDuplicate(int[] nums, int k)
{
    Dictionary<int, int> result = new Dictionary<int, int>();
    Dictionary<int, int> duplicated = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (result.ContainsValue(nums[i])){
            duplicated.Add(i, nums[i]); 
        }
        else
        {
            result.Add(i,nums[i]);
        }

    }

    foreach (var item in duplicated)
    {
        var valueI = item.Key;
        var indexI = item.Value;

        var findValJ = result.Values.Where(x => x == indexI).First();
        var indexJ = result.Where(x => x.Value == findValJ).First().Key;

        if(Math.Abs(indexJ- valueI) <= k) { return true; }
    }

    return false;
}

bool ContainsDuplicate(int[] nums)
{
    Array.Sort(nums);
    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (nums[i] == nums[i + 1])
        {
            return true;
        }
    }

    return false;
}

int HammingWeight(uint n)
{
    string binary = Convert.ToString(n, 2).PadLeft(32, '0');
    int result = 0;
    for (int i = 0; i < binary.Length; i++)
    {
        if (binary[i] == '1')
        {
            result++;
        }
    }

    return result;
}

uint reverseBits(uint n)
{
    string binary = Convert.ToString(n, 2).PadLeft(32, '0');
    var reverse = binary.Reverse();
    string reverseString = "";

    foreach (var item in reverse)
    {
        reverseString += item;
    }

    uint output = Convert.ToUInt32(reverseString, 2);

    return output;
}

int MajorityElement(int[] nums)
{
    int majorityN = nums.Length / 2;
    Dictionary<int, int> ocurrences = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (ocurrences.ContainsKey(nums[i]))
        {
            ocurrences[nums[i]]++;
            if(ocurrences[nums[i]] > majorityN)
            {
                return nums[i];
            }
        }
        else
        {
            ocurrences.Add(nums[i], 1);
        }
    }
    return nums[0];
}

int SingleNumber(int[] nums)
{
    Dictionary<int, int> numCoincidences = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (numCoincidences.ContainsKey(nums[i]) == false)
        {
            numCoincidences.Add(nums[i], 1);
        }
        else
        {
            numCoincidences[nums[i]] = numCoincidences.GetValueOrDefault(nums[i]) + 1;
        }
    }

    return numCoincidences.OrderBy(x => x.Value).First().Key;
}

IList<int> GetRow(int rowIndex)
{
    //fill array with 1
    List<int>[] results = new List<int>[rowIndex+1];

    for (int i = 0; i < rowIndex+1; i++)
    {
        results[i] = new List<int>();

        for (int j = 0; j <= i; j++)
        {
            results[i].Add(1);
        }
    }

    int finalindex = 1;

    //set values at position needed
    for (int i = 2; i < results.Length; i++)
    {
        finalindex++;
        for (int fills = 1; fills < finalindex; fills++)
        {

            results[i][fills] = results[i - 1][fills - 1] + results[i - 1][fills];
        }

    }


    return results[rowIndex];
}

    IList<IList<int>> Generate(int numRows)
{
    //fill array with 1
    List<int>[] results = new List<int>[numRows];

    for (int i = 0; i < numRows; i++)
    {
        results[i] = new List<int>();

        for (int j = 0; j <= i; j++)
        {
            results[i].Add(1);
        }
    }

    int finalindex = 1;

    //set values at position needed
    for (int i = 2; i < results.Length; i++)
    {
        finalindex++;
        for (int fills = 1; fills < finalindex; fills++)
        {

            results[i][fills] = results[i - 1][fills-1] + results[i - 1][fills];
        }
        
    }


    return results;
}

bool IsHappy(int n)
{
    int sum = 0;
    int iterations = 0;
    while (sum != 1)
    {
        iterations++;
        if(iterations == 100)
        {
            return false;
        }
        //conver n to array of digits
        int[] outarry = Array.ConvertAll(n.ToString().ToArray(), x => (int)x - 48);

        for (int i = 0; i < outarry.Length; i++)
        {
            sum = sum + (int)Math.Pow(outarry[i], 2);
        }

        if (sum == 1)
        {
            return true;
        }

        if(sum != 0)
        {
            n = sum;
            sum=0;
        }
    }

    return false;
}

bool IsPalindrome(string s) {

    //remove white spaces
    var convertString = new string(s.ToCharArray()
        .Where(c => !Char.IsWhiteSpace(c))
        .ToArray());
    //remove special characters
    convertString = new String(convertString.Where(Char.IsLetterOrDigit).ToArray());
    //convert to lower case
    convertString = convertString.ToLower();

    //compare string == to string reverse
    char[] array = convertString.ToCharArray();
    Array.Reverse(array);
    string reverse = new String(array);

    if (convertString.Equals(reverse))
    {
        return true;
    }

    return false;
}

string LongestCommonPrefix(string[] strs)
{
    string result = "";
    Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length));

    Dictionary<int, string> dic = new Dictionary<int, string>();  

    for (int i = 0; i < strs.Length-1; i++)
    {
        if(strs[i].Length == 0)
        {
            return "";
        }
        string compare = "";

        for (int j = 0; j < strs[i].Length; j++)
        {

            if(strs[i][j] == strs[i + 1][j])
            {
                
                compare = compare + strs[i][j].ToString();
            }
            else
            {
                //compare first values 
                if(strs[i][0] != strs[i + 1][0])
                {
                    dic.Add(i, compare);
                }
                break;
            }
            if (dic.ContainsKey(i))
            {
                dic[i] = compare;
            }
            else
            {
                dic.Add(i, compare);
            }
            

        }
        
    }

    if(strs.Length == 1)
    {
        return strs[0];
    }

    if(dic.Count == 0)
    {
        return "";
    }

    return dic.Values.Min();
}

static int Fib(int n)
{
    Dictionary<int, int> fibonaccis = new Dictionary<int, int>();
    fibonaccis.Add(0, 0);
    fibonaccis.Add(1, 1);

    for (int i = 0; i <= n-2; i++)
    {
        var fibo = fibonaccis.GetValueOrDefault(i) + fibonaccis.GetValueOrDefault(i+1);
        fibonaccis.Add(i+2, fibo);

    }

    return fibonaccis.GetValueOrDefault(n);
}

static int[] CountBits(int n)
{
    int[] result = new int[n+1];

    for (int i = 0; i <= n; i++)
    {
        string s = Convert.ToString(i, 2); //Convert to binary in a string

        int[] bits = s.PadLeft(8, '0') // Add 0's from left
                     .Select(c => int.Parse(c.ToString())) // convert each char to int
                     .ToArray(); // Convert IEnumerable from select to Array

        result[i] = bits.Where(x => x == 1).Count();
    }

    return result;
}

//se usan 3 pointers uno de index, otro m y otro n
static void Merge(int[] nums1, int m, int[] nums2, int n) {

    //???para que no se salga de bounds
    m--; n--;

    int index = nums1.Length - 1;
    while (index >= 0)
    {
        //si no hay mas numeros de m, usa el valor de n
        if(m < 0)
        {
            nums1[index] = nums2[n--];
        }
        //si no hay mas numeros de n, usa el valor de m
        else if (n < 0)
        {
            nums1[index] = nums1[m--];
        }
        else
        {
            //si el numero en la posicion m del array 1 es 
            //mayor al numero en la posicion n del array 2
            //lo setea al array en la posicion index
            if(nums1[m] > nums2[n])
            {
                nums1[index] = nums1[m--];  
            }
            //si el numero en la posicion n del array 2 es 
            //mayor al numero en la posicion m del array 1
            //lo setea al array en la posicion index
            else
            {
                nums1[index] = nums2[n--];
            }
        }

        index--;
    }
}

//funciona pero da timeout
int MySqrt(int x)
{
        for (int i = 0; i <= x; i++)
        {
            var pow = i * i;

            if (pow == x)
            {
                return i;
            }
            if (pow > x)
            {
                return i - 1;
            }
        }

    return 0;
}

int MySqrt2(int x)
{
    long start = 0;
    long end = x;

    while (start+1 < end)
    {
        long mid = start + (end - start)/2;
        if(mid*mid == x)
        {
            return (int)mid;
        }
        else if(mid*mid < x)
        {
            start = mid;
        }
        else
        {
            end = mid;
        }
    }

    if(end*end == x)
    {
        return (int)end;
    }
    return (int)start;
}

string AddBinary(string a, string b)
{
    int aLength = a.Length;
    int bLength = b.Length;

    string result = "";
    bool carry = false;

    
    if (aLength > bLength)
    {
        for (int i = 0; i < aLength - bLength; i++)
        {
            b = b.Insert(0, "0");
        }
    }
    if(bLength > aLength)
    {
        for (int i = 0; i < bLength - aLength; i++)
        {
            a = a.Insert(0, "0");
        }
    }

    for (int i = a.Length-1; i >=0; i--)
    {
        var valueA = a[i];
        var valueB = b[i];

        //"11110"

        if (valueA =='1' && valueB == '1')
        {
            if (carry)
            {
                result = result.Insert(0, "1");
            }
            else
            {
                result = result.Insert(0, "0");
            }
            
            carry = true;
        }
        else if(valueA =='0' && valueB == '0')
        {
            if (carry)
            {
                result = result.Insert(0, "1");
            }
            else
            {
                result=result.Insert(0, "0");
            }
            carry = false;
        }
        else
        {
            if (carry)
            {
                result = result.Insert(0, "0");
                carry=true;
            }
            else
            {
                result= result.Insert(0, "1");
                carry=false;
            }
        }
    }
    if (carry)
    {
        result = result.Insert(0, "1");
    }

    return result;
}

//funciona pero el length es demasiado grande, tiene q soportar numeros de 100 digitos
int[] PlusOne(int[] digits) 
{
    string digitsConverted="";

    for (int i=0; i<digits.Length; i++)
    {
        digitsConverted = digitsConverted + digits[i].ToString();
    }

    long sum = Convert.ToInt64(digitsConverted) + 1;
    var intList = sum.ToString().Select(digit => int.Parse(digit.ToString())).ToArray();

    return intList;
}

int[] PlusOne2(int[] digits)
{
    for (int i = digits.Length - 1; i >= 0; i--)
    {
        if(digits[i] < 9)
        {
            digits[i]++;
            return digits;
        }
        digits[i] = 0;
    }

    int[] result = new int[digits.Length+1];
    result[0] = 1;

    return result;
}

int LengthOfLastWord(string s)
{
   string removeSpacesEnd= s.TrimEnd();
    int length = 0;

    for (int i = removeSpacesEnd.Length-1; i >= 0; i--)
    {
        if(removeSpacesEnd[i] != ' ')
        {
            length++;
        }
        else
        {
            break;
        }
    }

    return length;
}

//mi solucion anda bien, pero rompe la pija con lo del array
int RemoveDuplicates(int[] nums)
{
    int removedItems = 0;

    for (int i = 0; i < nums.Length-1; i++)
    {
        if (nums[i] == nums[i + 1])
        {
            nums = nums.Where((source, index) => index != i).ToArray();
            nums = nums.Concat(new int[] {0}).ToArray();
            removedItems++;
        }
    }

    return nums.Length - removedItems;
}

//valid parenthesis
bool IsValid(string s)
{
    Stack stack = new Stack();

    foreach (char c in s)
    {

        if (c == '(')
        {
            stack.Push(c);

        }
        else if (c == '[')
        {
            stack.Push(c);

        }
        else if (c == '{')
        {
            stack.Push(c);

        }

        if (stack.Count == 0)
        {
            return false;
        }

        else if (c == ')')
        {

            if (stack.Peek().ToString() == "(")
            {
                stack.Pop();

            }
            else
                return false;

        }
        else if (c == '}')
        {

            if (stack.Peek().ToString() == "{")
            {
                stack.Pop();
            }
            else
                return false;

        }
        else if (c == ']')
        {


            if (stack.Peek().ToString() == "[")
            {
                stack.Pop();

            }
            else
                return false;

        }

    }
    if (stack.Count != 0)
    {
        return false;
    }

    return true;
}

//para mi esta bien, pero da un timeout
int[] ProductExceptSelf(int[] nums)
{
    List<int> result = new List<int>();
    List<int> numsToList = nums.ToList();

    for (int i = 0; i < numsToList.Count; i++)
    {
        numsToList.RemoveAt(i);
        var product = numsToList.Aggregate(1, (var, next) => var * next, prod => prod);

        result.Add(product);
        numsToList = nums.ToList();
    }

    return result.ToArray();    
}

//otra solucion recorriendo der izq y izq der
int[] ProductExceptSelf2(int[] nums)
{ //1,2,3,4
    int N = nums.Length;
    int[] leftProducts = new int[N];
    int[] rightProducts = new int[N];

    int[] output_array = new int[N];

    //inicializa los valores, el primer valor es 1 porq no hay nada antes
    leftProducts[0] = 1;
    rightProducts[N-1] = 1;

    for (int i = 1; i < N; i++)
    {
        leftProducts[i] = nums[i-1] * leftProducts[i-1];
    }

    for (int i = N-2; i >= 0; i--)
    {
        rightProducts[i] = nums[i + 1] * rightProducts[i + 1];
    }

    for (int i = 0; i < N; i++)
    {
        output_array[i] = leftProducts[i] * rightProducts[i];
    }

    return output_array;
}

long[] SumOfThree(long num)
{
    long[] output = { };


    var findN = num / 3;

    var toList = output.ToList();
    toList.Add(findN - 1);
    toList.Add(findN);
    toList.Add(findN + 1);

    toList.Sort();

    if(toList[0] + toList[1] + toList[2] != num)
    {
        long[] empty = { };
        return empty;
    }

    return toList.ToArray();
}

int LongestConsecutive(int[] nums)
{
    //sort array
    Array.Sort(nums);

    int sumOutput = 0;
    int maxValue = 0;

    for (int i = 0; i < nums.Length -1; i++)
    {
        //IF NUMBERS ARE CONSECUTIVE OR EQUALS
        if(nums[i] - nums[i+1] == -1 || nums[i]==nums[i+1])
        {
            //IF NUMBERS ARE NOT EQUAL
            if(nums[i]!=nums[i+1])
            {
                //COUNT AND ADD TO MAXVALUE
                sumOutput = sumOutput+1;

                if (sumOutput > maxValue)
                {
                    maxValue = sumOutput;
                }
            }
        }
        else
        {
            sumOutput = 0;
        }
    }

    if(nums.Length == 0)
    {
        return 0;
    }
    if(nums.Length == 1)
    {
        return 1;
    }

    return maxValue;
}

int RomanToInt(string s)
{
    IDictionary<char, int> roman = new Dictionary<char, int>();
    roman.Add('I', 1);
    roman.Add('V', 5);
    roman.Add('X', 10);
    roman.Add('L', 50);
    roman.Add('C', 100);
    roman.Add('D', 500);
    roman.Add('M', 1000);

    int result = roman[s[s.Length - 1]];
    for (int i = s.Length-2; i >= 0; i--)
    {
        if(roman[s[i]] < roman[s[i + 1]])
        {
            result-=roman[s[i]];
        }
        else
        {
            result+=roman[s[i]];
        }

    }
    return result;
}

int[] TwoSum(int[] nums, int target)
{
    int[] result = new int[2];

    for (int index = 0; index < nums.Length; index++)
    {
        for (int i = index; i < nums.Length-1; i++)
        {
            var numA = nums[index];
            var numB = nums[i+1]; 

            if(numA+numB == target)
            {
                result[0] = index;
                result[1] = i+1;
            }
        }
    }


    return result;
}
