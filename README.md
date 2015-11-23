# TalkToMeAPI - Text-to-speech Azure API App

This is a simple and hopefully fun proof-of-concept of a custom Azure API App to be used in a Azure Logic App.

[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)

There are two main parts. First the API that hosts a SignalR hub and the second one is the UI that connects one (or more) browser as the API App "Loudspeaker". An Azure API App is just like any 'normal' Web App so it can host both parts and no other deployment is needed.

- **WebAPI**
  - SignalR Hub
- **Client UI**
  - [mespeak.js](http://www.masswerk.at/mespeak)
  - SignalR client

My first sample scenario used to try the API App was a Logic App getting weather data from api.openweathermap.com that TalkToMe API will read out. Note that by design the API will return 202/Accepted even if no browser (ie. SignalR client) is connected and no queuing or simmilar is performed.

## How to use
1. Deploy Azure API App
2. Create and deploy a Logic App where TalkToMe is used as an 'action'
![image](https://cloud.githubusercontent.com/assets/1846780/11325058/07c80bfe-9144-11e5-8cbf-362b550b36a5.png)
  
3. Connect one or more browsers to the API by browsing the root URL of the deployed API. If you are unsure of the URL you can find the link in the 'essentials' section of the API App in the portal. 
![image](https://cloud.githubusercontent.com/assets/1846780/11325090/0b3af8ae-9145-11e5-90b6-41bee2edac9c.png)
![image](https://cloud.githubusercontent.com/assets/1846780/11325079/939c1bb6-9144-11e5-8c1c-d80669ff5165.png)

4. Run the Logic App

When the logic app runs and the TalkToMe action fires the portal should show something like
![image](https://cloud.githubusercontent.com/assets/1846780/11345289/38cb43e2-9216-11e5-8e35-3f3078ef5cc1.png)

And you should hear the artificial voice in your speaker:
![image](https://cloud.githubusercontent.com/assets/1846780/11325065/480cb1ce-9144-11e5-8bda-1fc04134ce3a.png)


##Test API using HTTP
If you just want to try the API App, outside of an Logic App, you can use a simple REST call.

| REST param  | Value |
| ------------- | ------------- |
| URL     | http://{your-apiapp-url}/api/TalkToMe |
| Method  | HTTP POST  |
| Content-Type  | application/json  |
| Body     | { "TextToRead" : "Nice weather today" } |
