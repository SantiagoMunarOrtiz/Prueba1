namespace YourNamespace
{
    public class TestService : ITest
    {
        public void ProcessUser(User user)
        {
            // Implementación del método
            Console.WriteLine($"User ID: {user.Id}");
            Console.WriteLine($"User Name: {user.UserName}");
            Console.WriteLine($"Password: {user.Password}");
            Console.WriteLine($"Request Date: {user.RequestDate}");
        }
    }
}
