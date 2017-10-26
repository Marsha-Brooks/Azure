Azure Discussion Questions Chapter 1

1. What are the differences between Iaas, Paas, and Saas? 
IaaS:  Infastructure as a Service
Virtual Machines deployed on the cloud that are still the responsibility of the user to load the OS, software, updates ect and to secure.  Use of on-premise SQL Server.
PaaS:  Platform as a Service
Virtual machines and SQL database services deployed on the cloud.  Cloud admin takes over all maintenance tasks and services.  
SaaS:  Software as a Service
All services and layers deployed to the cloud. Under cloud admin services and provision. Highest grade of service.

2. What is the Azure Service Management (ASM) deployment model? What is the Resource Manager deployment model? 
The ASM model, also known as version 1 and Classic mode, started out as a web interface and a backend API for the PaaS services Azure opened with at launch.
Features
1.	ASM deployments are based on an XML schema.
2.	ASM operations are based at the cloud service level.
3.	Cloud services are the logical containers for IaaS VMs and PaaS services.
4.	ASM is managed through the CLI, old and new portals (features) and PowerShell.
The ARM manages 
The ARM model consists of a new web interface and API for resource management in Azure which came out of preview in 2016 and introduced several new features.
Features
1.	ARM deployments are based on a JSON schema.
2.	Templates, which can be imported and exported, define deployments.
3.	RBAC support.
4.	Resources can be tagged for logical access and grouping.
5.	Resource groups are the logical containers for all resources.
6.	ARM is managed through PowerShell (PS), the CLI and new portal only.


3. What is the difference between a control plane and a data plane?
Control plane packets are destined to or locally originated by the router itself. This is really what separates the concept of the control and data plane. ... As for the data plane, sometimes called the Forwarding Plane, this is basically anything that goes *through* the router, and not *to* the router.

 4. What is Role-Based Access Control?
Role-based access control (RBAC) is a method of regulating access to computer or network resources based on the roles of individual users within an enterprise. In this context, access is the ability of an individual user to perform a specific task, such as view, create, or modify a file.
 5. Why would you want to create a custom role for role-based access control? 
You would want to create role-based access control because you want to control who has the rights to modify attributes of your system.  Who can create, modify or view a file.
Azure Service Dashboard is a online platform where Azure Cloud Services users / subscribers can view and monitor status of current services provisioned.  Microsoft Azure Services Dashboard primarily allows Azure subscribers to view the health and operational status of each overall Azure service separately.
6. Consider the Azure portal. What is the dashboard? What is the hub? What is a blade? 
Azure Service Dashboard is a online platform where Azure Cloud Services users / subscribers can view and monitor status of current services provisioned.  Microsoft Azure Services Dashboard primarily allows Azure subscribers to view the health and operational status of each overall Azure service separately.
Azure IoT Hub is a fully managed service that enables reliable and secure bidirectional communications between millions of IoT devices and a solution back end. Azure IoT Hub: Provides multiple device-to-cloud and cloud-to-device communication options.
Consistent management pages (or blades) that let you manage Azure's wide variety of services through a consistent way of exposing settings, actions, billing information, health monitoring and usage data, and much more.
7. Access the conceptual Azure documentation on Github. Search the documentation and answer this question: What happens when I reach the spending limit?
When you reach the spending limit of the free account? When the spending limit is reached, or the free 30 days trial expires, access to the portal is still available but no services will be available under the subscription.  The credit card that is on the file is not automatically charged at that time until further arrangements for services are made.
 8. Access the Azure samples on Github. Search for an example that will allow you to download an Azure invoice. Copy the source code to your discussion. (This is Program.cs.) 
https://github.com/Azure-Samples/billing-dotnet-core-invoice-download/blob/master/Program.cs
 

9. Access the Azure Resource Manager samples on Github. Search for a quickstart template that will allow you to set up a free SQL Database for a web application. This template has four files. One file is a markdown file. What is the type of the other three files?
The other three files are JSON files
