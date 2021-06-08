# .NET Framework Console Application With TopShelf and Fluent Scheduler Example

This example demonstrates as way of turning a .NET Framework Console Applicatoin in to a microservice (A service that can be configured via services.msc Console Snap In)

The key elements to this example are:

- The TopShelf NuGet Package
- The FluentScheduler NuGet Package
- Adding some keys to the App.config
- Creating a ServiceConfig POCO class
- Creating a Job class that inherits from FluentScheduler.IJob actually executes the code needed by the service
- Creating a Job Registry class that inherets from FluentScheduler.JobRegistry to schedule when the job will be deployed
- Creating a Service class to initiate the Registry
- Update the Program.cs class to read the configuration and execute the Service registration code

Microservices created in .NET Framework are very powerful and configurable. Some things that are especially useful in combining with Microservices like these are HTTP Client library to download
files from a particular location, on a regular basis.

Entity framework can be used in these microservices as well to become powerful ETL processes and in some cases will perform better than SSIS packages. Nearly anything that can be done in an SSIS package
can be done in .NET Framework code.