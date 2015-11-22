# TalkToMeAPI Azure API App
Text-to-speech Azure API App

This is a simple proof-of-concept of a Azure API App to be used in a Azure Logic App.

[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)

The API App hosts both the API and the simple HTML page (MVC controller and View) that uses [mespeak.js](http://www.masswerk.at/mespeak) javascript client library to do the actual text-to-speach. I have only tried the mespeak library but i'm sure there are several others out there.

- WebAPI
- SignalR Hub
- Client UI (HTML/MVC)
- mespeak.js
- SignalR client

### How to use
- Deploy Azure API App

- Create and deploy a Logic App where TalkToMe is used as an 'action'
![image](https://cloud.githubusercontent.com/assets/1846780/11325058/07c80bfe-9144-11e5-8cbf-362b550b36a5.png)
  
- Connect one or more browsers to the API by browsing the API root URL
![image](https://cloud.githubusercontent.com/assets/1846780/11325090/0b3af8ae-9145-11e5-90b6-41bee2edac9c.png)
![image](https://cloud.githubusercontent.com/assets/1846780/11325079/939c1bb6-9144-11e5-8c1c-d80669ff5165.png)

- Run the Logic App

![image](https://cloud.githubusercontent.com/assets/1846780/11325065/480cb1ce-9144-11e5-8bda-1fc04134ce3a.png)


