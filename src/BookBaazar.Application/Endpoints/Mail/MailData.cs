using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBaazar.Application.Endpoints.Mail;

public class MailData
{
    public string EmailToId { get; set; }
    public string EmailToName { get; set; }
    public string EmailSubject { get; set; }
    public string EmailBody { get; set; }
}