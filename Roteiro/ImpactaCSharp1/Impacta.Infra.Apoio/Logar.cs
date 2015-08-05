using System;
using System.Net;
using System.Net.Mail;

namespace Impacta.Apoio
{
    public static class Logar
    {
        public static void PorEmail(Exception ex)
        {
            var mensagem = new MailMessage();
            mensagem.From = new MailAddress("avelino.vitor@gmail.com");
            mensagem.To.Add(new MailAddress("vitoravelino@ig.com.br"));
            mensagem.Subject = ex.Message.Replace(Environment.NewLine, ". ");
            mensagem.Body = ex.StackTrace;
            mensagem.IsBodyHtml = true;

            var smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("avelino.vitor@gmail.com", "senha", "");

            try
            {
                smtp.Send(mensagem);
            }
            catch
            {
                // Logar em txt?
            }
        }
    }
}