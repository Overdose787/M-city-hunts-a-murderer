using M;

Console.WriteLine("city begins");

int mcounter = 0;

Random random_gen =  new Random();

Console.WriteLine("building city");

int arrlimiter = random_gen.Next(10, 40);

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

Console.WriteLine("bluiding people");

for (int i = 0; i < city.Length; i++)
{
    if (city[i].affiliation[1] == 'i')
    {
        for (int j = 0; j < int.Parse(city[i].get_into(1)); j++)
        {
            int agegrp = random_gen.Next(0, 2);
            city[i].addtoarr(new humans_cont.human($"human{i + j + 1}" ,agegrp ));
            if (agegrp == 0)
            {
                mcounter++;
            }
            
        }
    }
    else if(city[i].affiliation[1] == 'o')
    {
        for (int j = 0; j < int.Parse(city[i].get_into(1)); j++)
        {
            city[i].addtoarr(new humans_cont.human($"human{i + j + 1}" , 1 , "police"));
        }
    }
    else
    {
        for (int j = 0; j < int.Parse(city[i].get_into(1)); j++)
        {
            city[i].addtoarr(new humans_cont.human($"human{i + j + 1}" , 1 , "crime"));
        }
    }
}
humans_cont.murderer mr = new humans_cont.murderer();

Console.WriteLine("---done---");

bool crime_engaged = false;
double fear_factor = 0.0;
int crimerage = 0;
Thread.Sleep(5000);

while (mcounter != 0) //main even loop
{
    if (mr.catched == true)
    {
        break;
    }
    Console.Clear();
    
    Console.WriteLine("murderer is look for prey");

    
    City_cont.building[] arrofsettrp = new City_cont.building[(int)(fear_factor + 0.5)];
    if (fear_factor >= 0.5)
    {
        Console.WriteLine("police making a move");
        for (int i = 0; i < fear_factor + 0.5; i++)
        {
            int ch = random_gen.Next(0, city.Length);
            city[ch].set_trap('p');
            if (city[ch].affiliation[1] == 'r')
            {
                if (!crime_engaged)
                {
                    Console.WriteLine("Crime has been engaged");
                    crime_engaged = true;
                }
                crimerage++;
            }
            arrofsettrp[i] = city[ch];
        }
    }

    for (int i = 0; i < crimerage; i++)
    {
        if (crime_engaged)
        {
            int ch = random_gen.Next(0, city.Length);
            city[ch].set_trap('c');
            arrofsettrp[i] = city[ch];
        }
    }
    
    int choice = random_gen.Next(0, city.Length);
    
    if (city[choice].affiliation[1] == 'i')
    {
        foreach (var VARIABLE in city[choice].array) 
        {
            if (VARIABLE.get_aggrp() == 0 && VARIABLE.alive != false)
            {
                Console.WriteLine($"murderer strikes at -|- {city[choice].get_into()} \n at {VARIABLE.get_info()}");
                VARIABLE.alive = false;
                fear_factor += 0.5;
                break;
            }
        }
    }
}



/*
foreach (var bld in city)
{
    Console.WriteLine(bld.get_into());

    if (int.Parse(bld.get_into(1)) == 0)
    {
        continue;
    } 
    bld.list_residents();
}
*/