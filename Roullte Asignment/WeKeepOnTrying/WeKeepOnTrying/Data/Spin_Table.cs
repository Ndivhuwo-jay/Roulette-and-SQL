using SQLite;

namespace WeKeepOnTrying.Data
{
    public class Spin_Table
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string? Color { get; set; }
        public int Value { get; set; }
        public string? NumberType { get; set; }
        public bool EvenOrOdd { get; set; }

    }
}
