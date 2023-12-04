Random rnd = new Random();

int myRandomNum;

int randomSum = 0;

for(int i = 0; i < 3; i++)
{
    int MyRandomNum = rnd.Next(0, 11);
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {MyRandomNum}");
}

Console.WriteLine($"random sum total: {randomSum}");


