// See https://aka.ms/new-console-template for more information
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
