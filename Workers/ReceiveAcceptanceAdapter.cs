using CamundaClient.Dto;
using CamundaClient.Worker;
using System;
using System.Collections.Generic;


namespace InsuranceApplication.Worker
{
    [ExternalTaskTopic("receiveAcceptance")]
    [ExternalTaskVariableRequirements("name", "message","carType", "carManufacturer", "email")]
    class ReceiveAcceptanceAdapter : IExternalTaskAdapter
    {

        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            // just create an id for demo purposes here
            resultVariables.Add("message", "your application is accepted");
        }

    }
}
