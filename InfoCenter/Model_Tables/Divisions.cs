namespace InfoCenter.Model_Tables
{
    public class Divisions
    {
        public long Id { get; set; }
        public string Name { get; set; }  

        public int? Parent_div_code { get; set; }
        public Divisions Parent { get; set; }
        public List<Divisions> Children { get; set; }

        public int chief_id { get; set; }
        public Employees chef { get; set; }

         public List<Divisions> Resours_centre_code { get; set; }

        public List<Employees> Employees { get; set; }

        

    }
}
