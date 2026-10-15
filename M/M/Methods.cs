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

    public void PRINTsuminfo(City_cont.building[] tosum)
    {
        int sumciv, sumcr, sumpl = 0;
        sumcr = 0;
        sumciv = 0;

        foreach (var bld in tosum)
        {
            switch (bld.get_aff()[1])
            {
                case 'i':
                    sumciv++;
                    break;
                case 'o':
                    sumpl++;
                    break;
                case 'r':
                    sumcr++;
                    break;
            }
        }
        Console.WriteLine($"--- | civilian - {sumciv} | police - {sumpl} | crime - {sumcr} | ---");
    }
}