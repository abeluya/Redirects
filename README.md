# Redirects
The redirect tester tool is an app developed to test the redirects and its response codes. The main idea of the application is to make easier to check a list of redirects by automating most of the process.

# How it Works
This software takes a list of redirects from the clipboard and then compare origin URLs against destiny URLs.

#Additional notes
* This application runs with Selenium Web driver, so it is necessary to have the Chrome driver installed in the same path of the app.
* It is highly recommended to create a back up of your "hosts" file before start using the application. 
* Also, please add a line break at the end of the "hosts" file. There is a unknown issue when editing this file so adding the line break will prevent the file gets corrupted. In case you need it, this is the path of the "hosts" file: C:\Windows\System32\Drivers\etc