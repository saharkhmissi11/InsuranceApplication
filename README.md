# InsuranceApplication
An InsuranceApplication that uses the Camunda Tasklist and HTML forms.

## Application Description
This application, we will use HTML froms instead of Camunda forms.
We will also use Camunda Platform Run Tasklist.
### Camunda Platform Run Tasklist: 
We use Camunda TaskList when :
    - we want to start a process manually 
    - mission-critical business processes require manual work(exp: filling a form)    
## Required packages
     - CamundaClient : Camunda REST API Client for .NET platform
     - Newtonsoft.json : Serialize and deserialize any .NET object 
## Camunda Models (PS: All these models and forms must be deployed into localhost before using them)
     - InsuranceApplication.bpmn : this a BPMN model representing the process
     - RiskAssessment.dmn : this a DMN model which makes a decision and gives the nature of the risk based on the user information
     - start.html : this is an embedded task form . The user will fill a html form to enter his information.
     - decide.html : this is an embedded task form . The assigned user will use this html form to decide whether the application will be accepted or not
