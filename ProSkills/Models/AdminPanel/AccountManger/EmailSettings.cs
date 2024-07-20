using System.Net;

namespace ProSkills.Models.AdminPanel.AccountManger

{
    public static class EmailSettings
    {

        public static async Task SendEmailAsync(Email email)
        {
            using (var client = new SmtpClient("smtp.gmail.com", 587))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("aecuniversity44@gmail.com", "gpnn zbjn ceyu rklh");
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("aecuniversity44@gmail.com"),
                    Subject = email.Subject,
                    Body = email.Body,
                    IsBodyHtml = true
                };
                mailMessage.To.Add(email.To);

                await client.SendMailAsync(mailMessage);
            }
        }



    }
}
