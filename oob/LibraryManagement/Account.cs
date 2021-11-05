namespace LibraryManagement
{
    public class Account
    {
        public string Id;
        public string Password;

        public bool ResetPassword()
        {
            Password = "abc@1234";
            return true;
        }
    }
}