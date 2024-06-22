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
            client.Credentials = new NetworkCredential("furniture.store.fs2024@gmail.com", "mofg jpio zbjl sggw");
            client.Send("furniture.store.fs2024@gmail.com", email.To, email.Subject, email.Body);
        }
      
    }
}
