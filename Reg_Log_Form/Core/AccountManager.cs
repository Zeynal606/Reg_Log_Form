using System;
using System.Net;
using System.Net.Mail;

namespace Reg_Log_Form.Core
{
    public static class AccountManager
    {
        private static readonly string _host;
        private static readonly int _port;
        private static readonly string _email;
        private static readonly string _password;
        private static readonly SmtpClient _sender;
        private static readonly string _mailSubject;

        static AccountManager()
        {
            _host = "smtp.gmail.com";
            _port = 587;
            _email = "mv0.2020.123@gmail.com";
            _password = "zeynal123";
            _mailSubject = "Account Confirmation - MVOapp";
;            _sender = new SmtpClient(_host, _port)
            {
                Credentials = new NetworkCredential(_email, _password),
                EnableSsl = true
            };
        }
        public static event Action DisplayConfirmationWindow;
        public static string ConfirmationCode { get; private set; }
        public static void SendMail(string reciepentEmail)
        {
            _sender.Send(_email, reciepentEmail, _mailSubject, GetConfirmationMessage());
            DisplayConfirmationWindow();
        }
        private static string GetConfirmationMessage()
        {
            return $"Hello! We have sent a confirmation Code! Please, confirm your email by enterimg this code - {GetConfirmationCode()}";
        }
        private static string GetConfirmationCode()
        {
            string code = new Random().Next(1000, 9999).ToString();
            ConfirmationCode = code;
            return code;
        }

    }
}
