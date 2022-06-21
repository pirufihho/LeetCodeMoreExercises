// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

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
