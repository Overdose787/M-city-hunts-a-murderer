using M;

Console.WriteLine("city begins");

Random random_gen =  new Random();

Console.WriteLine("building city");

int arrlimiter = random_gen.Next(10, 80);

City_cont.building[] city = new City_cont.building[arrlimiter];



for (int i = 0; i < arrlimiter; i++)
{
    city[i] = new City_cont.building($"civ-bul-{i}");
}

Console.WriteLine("building police stations");

int police_station_count = random_gen.Next(0,new Methods().Intparse(city.Length));

//City_cont.police_station[] police_Stations = new City_cont.police_station[police_station_count];

for (int i = 0; i < police_station_count; i++)
{
    if (random_gen.Next(0, 2) == 1)
    {
        city.Append(new City_cont.police_station($"pol-stat-{i}"));
    }
}
Console.WriteLine("building crime houses");

int crime_house_count = random_gen.Next(0,new Methods().Intparse(city.Length));

for (int i = 0; i < crime_house_count; i++)
{
    if (random_gen.Next(0, 2) == 1)
    {
        city.Append(new City_cont.crime_house($"crm-hs-{i}"));
    }
}

foreach (City_cont.building bld in city)
{
    Console.WriteLine(bld.get_into());
}
