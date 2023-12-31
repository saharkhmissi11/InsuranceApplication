# InsuranceApplication
An InsuranceApplication that uses the Camunda Tasklist and HTML forms.

## Application Description
This application, we will use HTML froms instead of Camunda forms.
We will also use Camunda Platform Run Tasklist.
### Camunda Platform Run :  
Camunda BPM Run is a distribution of Camunda BPM that provides the Camunda web applications (Cockpit, Tasklist, Admin) and the REST API.
### Camunda Platform Run Tasklist: 
We use Camunda TaskList when :
    - We want to start a process manually 
    - Mission-critical business processes require manual work(exp: filling a form)    
## Required packages
     - CamundaClient : Camunda REST API Client for .NET platform
     - Newtonsoft.json : Serialize and deserialize any .NET object 
## Camunda Models (PS: All these models and forms must be deployed into localhost before using them)
     - InsuranceApplication.bpmn : this a BPMN model representing the process
     - RiskAssessment.dmn : this a DMN model which makes a decision and gives the nature of the risk based on the user information
     - start.html : this is an embedded task form . The user will fill a html form to enter his information.
     - decide.html : this is an embedded task form . The assigned user will use this html form to decide whether the application will be accepted or not
## Workers 
It contains tasks that are performed by an external system (.NET).
For example,if the application is accepted, ReceiveAcceptanceAdapter.cs will add a varibale  (message) "Your application is accepted" that can be read in the Camunda Platform Run Cockpit.
### Camunda Platform Run Cockpit: 
Cockpit gives you a real-time view of BPMN processes and DMN decision tables as they run, so you can monitor their status and quickly identify technical incidents that slow down or stop workflows.
    
