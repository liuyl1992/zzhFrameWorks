﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ZZH.MailKit.Service
{
    /// <summary>
    /// This service can be used simply sending emails.
    /// </summary>
    public interface IEmailSender
    {
        /// <summary>
        /// Sends an email.
        /// </summary>
        Task SendAsync(string to,string cc, string subject, string body, bool isBodyHtml = true, string bcc = "");

        /// <summary>
        /// Sends an email.
        /// </summary>
        void Send(string to,string cc, string subject, string body, bool isBodyHtml = true, string bcc = "");

        /// <summary>
        /// Sends an email.
        /// </summary>
        Task SendAsync(string from, string to,string cc, string subject, string body, bool isBodyHtml = true, string bcc = "");

        /// <summary>
        /// Sends an email.
        /// </summary>
        void Send(string from, string to,string cc, string subject, string body, bool isBodyHtml = true, string bcc = "");

        /// <summary>
        /// Sends an email.
        /// </summary>
        /// <param name="mail">Mail to be sent</param>
        /// <param name="normalize">
        /// Should normalize email?
        /// If true, it sets sender address/name if it's not set before and makes mail encoding UTF-8. 
        /// </param>
        void Send(MailMessage mail, bool normalize = true);

        /// <summary>
        /// Sends an email.
        /// </summary>
        /// <param name="mail">Mail to be sent</param>
        /// <param name="normalize">
        /// Should normalize email?
        /// If true, it sets sender address/name if it's not set before and makes mail encoding UTF-8. 
        /// </param>
        Task SendAsync(MailMessage mail, bool normalize = true);
    }
}
