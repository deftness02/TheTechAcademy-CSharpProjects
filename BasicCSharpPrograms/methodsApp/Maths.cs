namespace methodsApp;

public class Maths
{
    public int GetRandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
    
    public decimal GetRandomNumber(decimal min, decimal max)
    {
        Random random = new Random();
        return random.Next((int)min, (int)max);
    }
    
    public string GetRandomNumber(string min, string max)
    {
        Random random = new Random();
        return random.Next(Convert.ToInt32(min), Convert.ToInt32(max)).ToString();
    }
}