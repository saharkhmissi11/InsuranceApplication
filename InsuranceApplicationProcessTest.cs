using CamundaClient;
using CamundaClient.Service;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using CamundaClient.Dto;

namespace InsuranceApplicationProcess
{
    
    class CalculationProcessTest
    {

        public void TestInsuranceApplicationManuallyApproved()
        {
            // Engine client should point to a dedicated Camunda instance for test, preferrably locally available

            var camunda = new CamundaEngineClient(new System.Uri("http://localhost:8080/engine-rest/engine/default/"), null, null);

            // Deploy the models under test
             string deploymentId = camunda.RepositoryService.Deploy("testcase", new List<FileParameter> {
             FileParameter.FromManifestResource(Assembly.GetExecutingAssembly(), "InsuranceApplication.CamundaModels.InsuranceApplication.bpmn"),
             FileParameter.FromManifestResource(Assembly.GetExecutingAssembly(), "InsuranceApplication.CamundaModels.RiskAssessment.dmn")});

            
                // Start Instance
                string processInstanceId = camunda.BpmnWorkflowService.StartProcessInstance("insuranceApplication", new Dictionary<string, object>()
                {
                    {"age", 36 },
                    {"carManufacturer", "Porsche" },
                    {"carType", "911" }
                });


            }
    }
}
