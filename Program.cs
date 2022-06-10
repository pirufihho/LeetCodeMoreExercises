// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] nums = { 1,2,3,4,5,6 };
int target = 9;

TwoSum(nums, target);

string s = "MCMXCIV";
RomanToInt(s);

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
