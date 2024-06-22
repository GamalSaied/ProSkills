using System.Net;

namespace ProSkills.Models.AdminPanel.AccountManger

{
    public static class EmailSettings
    {
        public static void Sendemail(Email email)
        {
            var client = new SmtpClient("smtp.gmail.com", 587);
            //it means that email will be encrypted
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("aecuniversity44@gmail.com", "mwyu xhfs zdmk osch");
            client.Send("aecuniversity44@gmail.com", email.To, email.Subject, email.Body);
        }
      
    }
}
