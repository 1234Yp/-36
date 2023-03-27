//Задача 36: 
//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

Random rnd = new Random();
int[] nums = new int[4]; ;
int summ = 0;

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = rnd.Next(-100, 100);
    Console.Write(nums[i] + " ");
    if ((i + 1) % 2 != 0) summ = summ + nums[i];
}

Console.WriteLine($"-> {summ}");
