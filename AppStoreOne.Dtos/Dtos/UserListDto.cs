namespace AppStoreOne.Dtos.Dtos
{
    public class UserListDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int AuthType { get; set; }
    }
}
