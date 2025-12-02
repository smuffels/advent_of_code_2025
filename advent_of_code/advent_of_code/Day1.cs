// See https://aka.ms/new-console-template for more information

//start position dial is 50
// how many times 0?
//0 to 99
//left minus right plus

int result = 50;
int zeroCount = 0;

string[] input = File.ReadAllLines("/Users/celinebrun/projects/advent_of_code_2025/advent_of_code/advent_of_code/input.txt");

for (int i = 0; i < input.Length; i++)
{
    int number = Int32.Parse(input[i].Remove(0, 1))%100;
    
    if (input[i].Contains("L"))
    {
        result = result - number;
    }

    if (input[i].Contains("R"))
    {
        result = result + number;
    }

    if (result == 0 | result == 100 | result == -100)
    {
        zeroCount++;
    }

    if (result > 99)
    {
        result = result - 100;
    }

    if (result < 0)
    {
        result = result + 100;
    }

}
Console.WriteLine($"number of zeroes: {zeroCount}");

