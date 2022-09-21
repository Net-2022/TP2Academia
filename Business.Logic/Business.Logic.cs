namespace Business.Logic
{
    public class BusinessLogic
    {
    }

    public static class Validaciones
    {
        static public bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static public bool IsVaildPassword(string password)
        {
            return password.Trim().Length < 8;
        }
    }

}