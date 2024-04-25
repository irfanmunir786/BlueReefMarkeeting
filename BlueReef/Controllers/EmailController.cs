using BlueReef.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BlueReef.Controllers
{
    //public class EmailController : Controller
    //{
    //    private readonly Database _context;

    //    public EmailController(Database context)
    //    {
    //        _context = context;
    //    }



    //    public IActionResult Index()
    //    {
    //        return View();
    //    }

    //    private void SendMail(string mailbody)
    //    {
    //        try
    //        {
    //            SmtpClient smtpClient = new SmtpClient();
    //            NetworkCredential networkCredential = new NetworkCredential("hr.triesolutions@gmail.com", "sardar3250241");
    //            smtpClient.Host = "smtp.gmail.com";
    //            smtpClient.UseDefaultCredentials = false;
    //            smtpClient.Credentials = networkCredential;
    //            smtpClient.Port = 587;
    //            smtpClient.EnableSsl = true;
    //            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

    //            MailMessage Mail = new MailMessage();
    //            Mail.From = new MailAddress("hr.triesolutions@gmail.com");
    //            Mail.To.Add("munirirfan0@gmail.com");
    //            //Mail.CC.Add("");
    //            //Mail.CC.Add("");
    //            //Mail.IsBodyHtml = true;
    //            Mail.Subject = "NEW EMAIL";
    //            Mail.Body = mailbody;


    //            smtpClient.Send(Mail);
    //            ViewBag.Message = "Email Send";
    //            ModelState.Clear();

    //        }
    //        catch (Exception ex)
    //        {
    //            ViewBag.Message = ex.Message.ToString();
    //        }
    //    }


    //    [HttpGet]
    //    public IActionResult AddContactUsData(Database)
    //    {
            
    //        return View();
    //    }
    //    [HttpPost]
    //    public IActionResult AddContactUsData(SendEmail sendEmail)
    //    {
            
    //        string body = sendEmail.Name + "\n" + sendEmail.Subject + "\n" + sendEmail.Email + "\n" + sendEmail.MobilePhone + "\n" + sendEmail.Message;
    //        SendMail(body);
    //        _context.sendEmails.Add(sendEmail);
    //        _context.SaveChanges();
    //        //return Ok();
    //        return Json(new { success = true });


    //    }
    //}
}
