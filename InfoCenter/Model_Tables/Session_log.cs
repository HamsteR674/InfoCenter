namespace InfoCenter.Model_Tables
{
    public class Session_log
    { 
        public int Id { get; set; }
        public int Employees_Id { get; set; }
        public Employees Employees { get; set; }
        public string Error_list { get; set; }

    }
}
