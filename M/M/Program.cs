using M;

Console.WriteLine("city begins");

Random random_gen =  new Random();

Console.WriteLine("building city");

int arrlimiter = random_gen.Next(10, 80);

City_cont.building[] city = new City_cont.building[arrlimiter];


int police_station_count = random_gen.Next(0,new Methods().Intparse(city.Length));
int crime_house_count = random_gen.Next(0,new Methods().Intparse(city.Length));


for (int i = 0; i < arrlimiter; i++)
{
    int rannum = random_gen.Next(0, 3); 
    
    if (rannum == 1 && police_station_count != 0)
    {
        city[i] = new City_cont.police_station($"pol-stat-{i}");
        police_station_count--;
    }
    else if(rannum == 2 && crime_house_count != 0)
    {
        city[i] = new City_cont.crime_house($"crm-stat-{i}");
        crime_house_count--;
    }
    else
    {
        city[i] = new City_cont.building($"civ-bul-{i}");
    }
}

Console.WriteLine("--done--");

new Methods().PRINTsuminfo(city);

/*
foreach (var bld in city)
{
    Console.WriteLine(bld.get_into());
}
*/