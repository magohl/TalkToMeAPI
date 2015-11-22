# TalkToMeAPI - Text-to-speech Azure API App

This is a simple proof-of-concept of a Azure API App to be used in a Azure Logic App.

[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)

There are two main parts. First the API that hosts a SignalR hub. Second part is the UI that connects a browser as the API App "Loudspeaker".

As an Azure API App is just a 'normal' Web App it can host both parts and no separate installation is needed. The UI part consists of a simple HTML page (MVC controller/View) that uses [mespeak.js](http://www.masswerk.at/mespeak) text-to-speach javascript client library. I have only tried mespeak.js but i'm sure there are several others out there which would work just as good.

- *WebAPI*
  - SignalR Hub
- *Client UI*
  - mespeak.js
  - SignalR client

My sample scenario was a Logic App getting weather data from api.openweathermap.com and have the TalkToMe API read it out.

## How to use
1. Deploy Azure API App
2. Create and deploy a Logic App where TalkToMe is used as an 'action'
![image](https://cloud.githubusercontent.com/assets/1846780/11325058/07c80bfe-9144-11e5-8cbf-362b550b36a5.png)
  
3. Connect one or more browsers to the API by browsing the API root URL
![image](https://cloud.githubusercontent.com/assets/1846780/11325090/0b3af8ae-9145-11e5-90b6-41bee2edac9c.png)
![image](https://cloud.githubusercontent.com/assets/1846780/11325079/939c1bb6-9144-11e5-8c1c-d80669ff5165.png)

4. Run the Logic App
![image](https://cloud.githubusercontent.com/assets/1846780/11325065/480cb1ce-9144-11e5-8bda-1fc04134ce3a.png)


##Test using REST

| URL     | http://{your-apiapp-url}/api/TalkToMe |
| Method  | HTTP POST  |
| Content-Type  | application/json  |
| Body     | { "TextToRead" : "Nice weather today" } |
