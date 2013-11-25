# Setting Up the Development Environment

This project uses **node** and **yeoman** to set up the development environment
to install, perform the following steps

## Install Node
Visit the [Node Website](http://nodejs.org/) and install node for your platform

## Install yeoman
In the command line, run the following command:

    node install -g yo

This will install yeoman globally.

## Install Grunt Node Package Dependencies for Project
The file **package.json** defines the necessary node packages needed for grunt tasks to run,
to install that in the command line navigate to the root folder for this project and run the command:

    node install

A node_modules folder will be created containing all the node package packages.  This is not to be checked in
to source control as it can be installed locally through the command.

## Install the Necessary Web Dependencies
Yeoman comes with **bower** a cli utility to manage web dependencies such as javascript and css libraries.
To install, run the command:

    bower install

This will create a bower_components folder in the web path with the necessary required packages. 
Again, do not check this into source control


## Running the Server and Developing

To get started with development run the following command

    grunt server

This will start the web-server and bring up the website in your default browser.  This will also watch
for changes in .javascript, .html, and .css files and reload the site with the changes, making rapid updates simple

##More information

For more info see the following links

* [Yeoman](http://yeoman.io)
* [Grunt](http://gruntjs.com/)
* [Bower](http://bower.io/)
* [Angular](http://angularjs.org/)
