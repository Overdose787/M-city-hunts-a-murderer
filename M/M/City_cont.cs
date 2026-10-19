namespace M;

public class City_cont
{
    public class building
    {
        private string _adress;
        private int _maxarr;

        public string publciadress
        {
            get { return _adress; }
        }

        public string affiliation = "civilian";
        
        humans_cont.human[] array =  new humans_cont.human[10];

        public string get_into(int flag = 0)
        {
            switch (flag)
            {
                case 0:
                    return $"addr - {this.publciadress} \n affiliation - {this.affiliation}";
                case 1:
                    return $"{array.Length}";
            }
            return "";
        }

        public string get_aff()
        {
            return this.affiliation;
        }
        
        public building(string adress)
        {
            _adress = adress;
        }

        public void addtoarr(humans_cont.human item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    array[i] = item;
                    break;
                }
            }
        }

        public void list_residents()
        {
            foreach (var VARIABLE in this.array)
            {
                Console.WriteLine(VARIABLE.get_info());
            }
        }
    }

    public class police_station : building
    {
        public police_station(string addr) : base(addr)
        {
            base.affiliation = "police";
        }
    }

    public class crime_house : building
    {
        public crime_house(string addr) : base(addr)
        {
            base.affiliation = "crime";
        }
    }
}