namespace M;

public class humans_cont
{
    public class human
    {
        private string name;
        public string affiliation;
        private int age_group; //0 - minor , 1 - adult
        public bool alive = true;
        
        
        public int get_aggrp() {return age_group;}
        
        public string get_info()
        {
            return $"name - {name} \n aff - {affiliation} \n age group - {age_group}";
        }

        public human(string name ,int aggrp , string aff = "none" )
        {
            this.name = name;
            age_group = aggrp;
            affiliation = aff;
        }
    }

    public class murderer : human
    {
        public bool catched = false;
        
        
        public murderer() : base("Hans Beckert" , 1 , "murderer")
        {
        }
    }
}