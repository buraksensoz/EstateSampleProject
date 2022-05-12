namespace AppStoreOne.Entities.Concrete
{
    public class User : ITable
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int AuthType { get; set; }

    }
}
