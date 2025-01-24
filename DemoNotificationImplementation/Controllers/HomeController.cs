using DemoNotificationImplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace DemoNotificationImplementation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Find your Account SID and Auth Token at twilio.com/console
            // and set the environment variables. See http://twil.io/secure
            //string accountSid = "ACf329e0320b8d9745d5767024026e8306";
           // string authToken = "424edb20db576b144d740b64da8b9b51";
            string accountSid = WebConfigurationManager.AppSettings["accountSID"];
            string authToken = WebConfigurationManager.AppSettings["authTokenKey"];
            SMSMessage sMSMessage = new SMSMessage();
            var random = new Random();
            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: sMSMessage.Message + random.Next(5,1000000),
                from: new Twilio.Types.PhoneNumber(sMSMessage.From),
                to: new Twilio.Types.PhoneNumber(sMSMessage.To)
            );

            Console.WriteLine(message.Sid);

            return View();
        }
       
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}