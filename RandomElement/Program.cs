string[] snacks = { "pizza", "chicken", "pasta", "burger", "meat" };

Random rnd = new Random();
int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we eat {snacks[randomIndex]}.");