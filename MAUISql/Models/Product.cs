using SQLite;

namespace MAUISql.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string barcode { get; set; }

        public Product Clone() => MemberwiseClone() as Product;

        public (bool IsValid, string? ErrorMessage) Validate()
        {
            if(string.IsNullOrWhiteSpace(Name))
            {
                return (false, $"{nameof(Name)} is required.");
            }
            else
            {
                return (true, null);

            }
            return (true, null);
        }
    }
}
