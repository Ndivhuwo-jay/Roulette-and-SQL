using SQLite;

namespace WeKeepOnTrying.Data
{
    public class BetsTable
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public double betamaount { get; set; }
        public int numberofbets { get; set; }
        public string player { get; set; }
        public string bettype { get; set; }
        public string OddsColor { get; set; }
    }
}
