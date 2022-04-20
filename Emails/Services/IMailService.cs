﻿using Emails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emails.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailrequest);
    }
}
