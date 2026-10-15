namespace M;

public class City_cont
{
    public class building
    {
        private string _adress;

        public string publciadress
        {
            get { return _adress; }
        }

        public string affiliation = "civilian";
        
        //array of residents/workers

        public string get_into()
        {
            return $"addr - {this.publciadress} \n affiliation - {this.affiliation}";
        }

        public string get_aff()
        {
            return this.affiliation;
        }
        
        public building(string adress)
        {
            _adress = adress;
        }
    }

    public class police_station : building
    {
        public police_station(string addr) : base(addr)
        {
            base.affiliation = "police";
        }
        //method to add workers who are police
    }

    public class crime_house : building
    {
        public crime_house(string addr) : base(addr)
        {
            base.affiliation = "crime";
        }
        //method to add thugs
    }
}