using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Traversal.Models;

namespace Traversal.Areas.Admin.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress(mailRequest.Name,mailRequest.SenderMail);
            mimeMessage.From.Add(mailboxAddress);
            mailboxAddress mailboxAddressTo = new MailboxAddress("User)
            return View();
        }
    }
}
