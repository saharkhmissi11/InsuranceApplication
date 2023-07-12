using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using CamundaClient.Dto;
using CamundaClient.Worker;

namespace InsuranceApplicationCamundaTasklist.Worker
{
    [ExternalTaskTopic("sendEmail")]
    [ExternalTaskVariableRequirements("name", "carType", "carManufacturer", "email", "approved", "policyId")]
    class SendEmailAdapter : IExternalTaskAdapter
    {

        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            string email = (string)externalTask.Variables["email"].Value;

            MailMessage mail = new MailMessage("demo@camunda.com", email);
            SmtpClient client = new SmtpClient();

            //...
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "mail.camunda.com";
            client.Credentials = new NetworkCredential("demo@mx.camunda.com", "28484234386345");
            
                mail.Subject = "Your insurance application was rejected";
                mail.Body = "We are sorry, but we rejected your application. Have a good day!";
            

            client.Send(mail);
        }

    }
}
