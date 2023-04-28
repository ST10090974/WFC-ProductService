namespace ProductService.Models
{
    public class Supplier
    {
        public string SupID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Supplier() { }
        public Supplier(string supID, string name, string phone)
        {
            SupID = supID;
            Name = name;
            Phone = phone;


        }

        //public Supplier(string? supID, string? name, string? phone, string? username, string? password) : this(supID, name, phone)
        //{
        //    Username = username;
        //    Password = password;
        //}
    }
}
