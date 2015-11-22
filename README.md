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
  
- Connect one or more browsers to the API by browsing the API root URL
- Run the Logic App

