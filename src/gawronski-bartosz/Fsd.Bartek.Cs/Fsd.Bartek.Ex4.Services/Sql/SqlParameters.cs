namespace Fsd.Bartek.Ex4.Services.Sql
{
    public class SqlParameters
    {
        public string Id { get; set; }

        public object Value { get; set; }

        public SqlParameters(string id, object value)
        {
            Id = id;
            Value = value;
        }
    }
}