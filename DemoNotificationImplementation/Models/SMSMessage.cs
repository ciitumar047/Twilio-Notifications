using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoNotificationImplementation.Models
{
    public class SMSMessage
    {
      // public string To = "+966503222375";// Abdullah First Phone Number 
       public string To = "+966505503336"; // Abdullah Phone Number 
       //public string To = "+923137956444"; // Umar Phone Number 
      // public string To = "+966546271018"; // Umar Phone Number 
       public string From = "+17707622263"; // Twilio Number you dont need to changes this
       public string Message = "Hi Abdullah, Your Configuration Code is: ";    
    }
    
}