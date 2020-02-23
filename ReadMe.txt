Introduction to the Question Answer API

The QAAPI is written in asp.net core with c# and it has SqlLite database
with name Answers.DB where all the answers are saved.

The Api Uses Entity Framework core to save the data to backend DB.

PreRequisites:
Following are the nuget prerequisites for running the application on your system.

 The Project has Dependency on 

1. Microsoft.EntityFrameworkCore.SqlLite

2. Microsoft.EntityFrameworkCore.Tools

3. Microsoft.EntityFrameworkCore.Design

The last entry above is what adds data to the DB using EF Migrations


All of the nuget packages can be installed using the command
Install-Package   "NameOfPackage" e.g Install-Package Microsoft.EntityFrameworkCore.Tools
'


Testing the Jenkins Pipeline