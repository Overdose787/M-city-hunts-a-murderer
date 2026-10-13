namespace M;

public class Methods
{
    public int Intparse(double len)
    {
        if (len > 20)
        {
            double temp = len * 0.05;
            return (int)temp;
        }
        return 5;
    }
}