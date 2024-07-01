namespace InfoCenter.Model_Tables
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public long division_id { get; set; }
        public bool  is_fired { get; set; }
        public string code { get; set; }
        public List<Session_log> logs { get; set; }

    }
}
