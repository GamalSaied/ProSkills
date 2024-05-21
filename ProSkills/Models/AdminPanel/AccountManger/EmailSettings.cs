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
            client.Credentials = new NetworkCredential("gsaied12@gmail.com", "gemy56789");
            client.Send("gsaied12@gmail.com", email.To, email.subject, email.body);
        }
    }
}
