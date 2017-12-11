Azure Discussion Questions
MSSA, Cohort 03
December 11, 2017
1	Chapter 2
1.	So what is an App Service plan?
A plan that gives you the flexibility to allocate specific apps to a given set of 
Resources and further optimize your Azure resource utilization.
2.	What is a Web App?
A Web App is a web application that is hosted in an App Service.
3.	Name 3 Options for creating Web Apps.
Azure Marketplace, Visual Studio Code, and Visual Studio
4.	What is an App Service?
The host for a web app, mobile app, Logix App, API App or Function App.
5.	What languages are supported by a web app?
C#, C++, Python, Ruby, and PowerShell
6.	What does the setting icon do?
This opens a new blade called Settings. This displays by default when you first open the Web App blade, and is the same blade you see when you click All Settings.
7.	What it the purpose of swap?
This option swaps the versions deployed to two different deployment slots. For example, if you have a production slot and a staging slot, you can publish your web app to staging and test it. When you’re satisfied with it, you can promote it to production by using the Swap option. When you’re sure everything is working okay, you can remove the staging version.
8.	What is Reset Publish Profile?
This resets the publishing credentials and invalidates the old credentials. These credentials are used for FTP and Git access.
9.	What are the Application Settings?
These are values that apply to your web app
10.	What is the Scale out (App Service Plan)?
This is where you can set up auto scaling for your App Service plan and all of its app services. For example, you can ask it to increase the number of VMs if your CPU percentage reaches 90 percent and stays there for X number of minutes. We’ll take a closer look at this in the “Scaling Web Apps” section later in this chapter.  
11.	What do the PHP, Java and Python versions allow you to do?
this allows you to set the version to be run for the App Service. PHP 5.4, 5.5, 5.6, and 7.0 are supported. Java 7 and 8 are supported. For Python, versions 2.7 and 3.4 are supported.  

2	Chapter 3
Course: ISTA-422
Lesson Plan: 03Q

Name: Tyler Reed
Date: 04 December 2017
1.	What is Azure Virtual Machines and the terminology used in the chapter to reference?
Azure Virtual Machines is one of the central features of Azure’s IaaS capabilities, together with Azure Virtual Networks. Azure Virtual Machines supports the deployment of Windows or Linux virtual machines (VMs) in a Microsoft Azure datacenter. You have total control over the configuration of the VM. You are responsible for all server software installation, configuration, and maintenance and for operating system patches. 
 The terminology used to describe the Azure Virtual Machines feature and a virtual machine instance can be a little confusing. Therefore, throughout this chapter, Azure Virtual Machines will refer to the feature, while virtual machine or VM will refer to an instance of an actual compute node.
2.	How do you stop an Azure VM, and give an example?
To stop a VM but keep it provisioned, you would need to use the Stop-AzureRmVM PowerShell cmdlet such as in the following example: 
Stop-AzureRmVM -Name "AzEssentialDev3" -ResourceGroup "AzureEssentials" -StayProvisioned 
For classic VMs, a similar cmdlet, Stop-AzureVM, would be used. When using the Azure CLI, there are two commands used to control the stopped state of a VM: azure vm stop and azure vm deallocate
3.	What are three main resource providers used when working with Azure Virtual Machines, Storage and Compute?
 The Network resource provider (Microsoft.Network) handles all aspects of network connectivity such as IP addresses, load balancers, NICs, and so on. •\
The Storage resource provider (Microsoft.Storage) handles the storage of the disks for a VM (in the context of Azure Virtual Machines). 
 The Compute resource provider (Microsoft.Compute) handles details related to the VM itself, such as naming, operating system details, and configuration (size, number of disks, and so on).
4.	Where are durable disks stored and what are the benefits?
All durable disks (the OS disk and data disks) are backed by page blobs in Azure Storage. Therefore, the disks inherit the benefits of blob storage: high availability, durability, and geo-redundancy options. Blob storage provides a mechanism by which data can be stored safely for use by the VM. The disks can be mounted as drives on the VM. The Azure platform will hold an infinite lease on the page blob to prevent accidental deletion of the page blob containing the VHD, the related container, or the storage account.
5.	What is required when creating a VM in Azure using the Resource Manager model?
It is required that the VM be placed within an Azure Virtual Network (VNET). You will decide to use an existing VNET (or create a new one), the subnet to use, the IP address, if there is a load balancer or not, the number of NICs, and how network security is handled.
6.	What is a NIC and what does it do for Azure?
A network interface card (NIC) provides network access to resources in an Azure virtual network. A NIC is a standalone resource, but it must be associated with a VM to provide network access (a NIC by itself is of little value). The maximum number of NICs attached to a VM is dependent on the size of the selected VM.

7.	Why should you deploy at least two instances of the VM? What is provided?
When you deploy each VM you must create a storage account (or use an existing one), a virtual network, public IP addresses, an availability set, and a NIC for each VM. When you use an ARM template you limit the human error and fluidity of the process.
8.	How many ways can you connect to your VM, and what are they?
Remote Desktop or SSH. Remote Desktop is standard and SSH is for Linux devices.
9.	Whose responsibility is it to manage the VM?
The user, but it depends on the level of support or the plan you request.
10.	What is important when determining the scale-out approach to VMs, and what model is this referred to?
The important thing to determine with the scale-out approach to VMs is that there are two different models that are scaled-out differently, the Resource Manager Model and the Classic Model.  With the Resource Manager Model, the Azure Virtual Machine Scale Sets or VMSS are used to scale-out.
3	Chapter 4
Azure Chapter 4 Discussion Questions Chetana Adhikari
1.	What is Azure Blob Service?
The Azure Blob service gives you the ability to store files and access them from anywhere in the world by using URLs, the REST interface, or one of the Azure SDK storage client libraries. Storage client libraries are available for multiple languages, including .NET, Node.js, Java, PHP, Ruby, and Python
2.	What do you have to do to create Azure Blob Service?
You have to create a storage account. Once you have a storage account, you can create containers, which are similar to folders, and then put blobs in the containers.
3.	What are some common scenarios where file share can be used?
Many on-premises applications use file shares; this makes it easier to migrate those applications that share data to Azure. If you mount the file share to the same drive letter that the on-premises application uses, the part of your application that accesses the file share should work without any changes.  
 Configuration files can be stored on a file share and accessed by multiple VMs.
  Diagnostic logs, metrics, crash dumps, etc. can be saved to a file share to be processed and analyzed later. 
Tools and utilities used by multiple developers in a group can be stored on a file share to ensure that everyone uses the same version and that they are available to everyone in the group.
4.	What is Locally Redundant Storage?
Locally Redundant Storage (LRS) Azure Storage provides high availability by ensuring that three copies of all data are made synchronously before a write is deemed successful. These copies are stored in a single facility in a single region. The replicas reside in separate fault domains and upgrade domains. This means the data is available even if a storage node holding your data fails or is taken offline to be updated.

5.	Describe Azure Key Vault.
Azure Key Vault Azure Key Vault helps safeguard cryptographic keys and secrets used by Azure applications and services. You could store your storage account keys in an Azure Key Vault. What does this do for you? While you can’t control access to the data objects directly using Active Directory, you can control access to an Azure Key Vault using Active Directory. This means you can put your storage account keys in Azure Key Vault and then grant access to them for a specific user, group, or application.
6.	What is Azure Disc Encryption?
Azure Disk Encryption is integrated with Azure Key Vault to allow you to control and manage the disk encryption keys
7.	What is Client Size Encryption?
The data is encrypted by the application and sent across the wire to be stored in the storage account. When retrieved, the data is decrypted by the application. Because the data is stored encrypted, this is encryption at rest.
8.	What are some of the things you can do with AzCopy?
 Upload blobs from the local folder on a machine to Azure Blob storage.  •
 Upload files from the local folder on a machine to Azure File storage. • 
Copy blobs from one container to another in the same storage account.  •
 Copy blobs from one storage account to another, either in the same region or in a different region. • 
Copy files from one file share to another in the same storage account. •
 Copy files from one storage account to another, either in the same region or in a different region. • 
Copy blobs from one storage account to an Azure File share in the same storage account or in a different storage account.  • 
Copy files from an Azure File share to a blob container in the same storage account or in a different storage account.  • 
Export a table to an output file in JSON or CSV format. You can export this to blob storage. • 
Import the previously exported table data from a JSON file into a new table. (Note: It won’t import from a CSV file.)
9.	Name three options in the settings blade?
Access Keys This shows you your storage account name and the two access keys. From the Access Keys blade, you can copy any of the values to the Windows clipboard. You can also regenerate the storage account access keys here.  • 
Configuration This allows you to change the replication. Yours is LRS if that’s what you selected when creating the storage account. You can change it here to GRS or RA-GRS. • 
Custom Domain This is where you can configure a custom domain for your storage account. For example, rather than calling it robinscompany.blob.core.windows.net, you can assign a domain to it and refer to it as storage.robinscompany.com.  •
10.	How much did you learn from reading this chapter?
The context was intriguing and informative. Great information and insight on Azure storage and configuratioin.
4	Chapter 5
Azure /Chapter 5 Discussion Questions
1.  What is a VNET and what is it used for in Azure?
Virtual networks (VNets) are used in Azure to provide private connectivity for Azure Virtual Machines (Azure VMs) and some Azure services. VMs and services that are part of the same virtual network can access one another.
2. The fully managed service in Azure that is used for cross-premises connectivity, is called what?
Virtual Network Gateway
3. List three things you need to know when setting up a virtual network.
   	  address space, subnets, and DNS servers that you want to use
4.  What is the primary purpose of establishing a subnet?
break up your network into more manageable sections
5.  When in the deployment process of multiple Virtual Machines(VMs) are the VMs assigned thier IP address?
As they boot up
6. Why should you set the location of the Resource Group?
-	It’s best to specify the same Azure region that will be used for the resources when they are created.
7. What are the four rules to editing a template to redeploy?
-	If you remove a resource from the template that is not in the resource group, that resource will be unchanged. It won’t be removed simply because it’s gone from the template. (If you want to remove a resource, you have to specifically remove it using the Azure portal, PowerShell, the Azure CLI, etc.) 
-	If you add a resource to the template that is not in the resource group, it will create that resource for you when you redeploy the template. 
-	Resources that are unchanged but are still in the template will be ignored. 
-	Resources that are changed and still in the template will be updated. For example, if we change the address prefixes of our virtual network and redeploy the template, it will change them in the deployed VNet. 

8. Why should you not request a complete deployment using PowerShell?
-	You may accidentally remove a section of your template with no way to recover it.

9. Why did Microsoft create NSGs?
-	Microsoft created NSGs to provide a flexible method for defining the access rules allowing traffic into and out of a VM in a VNet—or even an entire subnet in the VNet.

10. What is a VPN according to the book?
-	A VPN Gateway is an Azure managed service that is deployed into a VNet and provides the endpoint for VPN connectivity for point-to-site VPNs, site-to-site VPNs, and ExpressRoute. This gateway is the connection point into Azure from either the on-premises network (site-to-site) or the client machine (point-to-site).

5	Chapter 6
MSSA Cohort 3
Course: ISTA-422
Chapter: 06
Name: Jason Bergener
Date: December 5, 2017
1.	What is the target of Azure SQL Databases.
Targeted at online transaction processing (OLTP; that is, data entry and retrieval transactions) workloads.
2.	By default, how many logical SQL Database servers can you have per Azure subscription?
By default, you can have up to six logical SQL Database servers per Azure subscription.
3.	Why does the connection string set the TrustServerCertificate property to False and the Encryptproperty to True?
 This is to provide additional protection while accessing SQL Database over the Internet. Doing so helps thwart potential man-in the-middle attacks. SQL Database will force the connection to be encrypted regardless of the setting.
4.	What are transient errors?
Transient errors are errors that are intermittent and likely will be resolved if the command is retried. These errors are more common with SQL Database than with databases accessed via a local area network (LAN). This is due to the inherently unreliable network that is the Internet and the fact that as a managed service, SQL Database might periodically undergo maintenance activities that could cause connections to drop temporarily
5.	What three things contribute to the total cost for running a SQL Server deployment on Azure VirtualMachines?
VM Considerations, Storage Considerations, and Disk Considerations.
6.	Why do you need to be concerned about high availability and disaster recovery for SQL Server in AzureVirtual Machines?
Azure provides high-availability features for the VMs, but not necessarily for SQL Server running on the VM. It is possible for the VM to be online but the SQL Server instance to be offline, unhealthy, or both. Additionally, it is possible for the VM to unavailable due to hardware failure or software upgrades. Therefore, a practiced HADR strategy should be considered. 
7.	What are six SQL Server features that are not currently supported in SQL Database (according to thebook)?
Windows authentication. 
 FILESTREAM data.  
 Database mirroring. 
 Extended stored procedures.
  SQL Server Agent/Jobs. 
SQL Server Reporting Services (SSRS) and SQL Server Integration Services (SSIS) are not supported. Alternatively, run a SQL Server on-premises or in an Azure VM and connect to a SQL database.
  T-SQL features
 	USE statement is not supported. To change databases, a new connection must be established.
Common language runtime (CLR). • Cross-database queries using three or four part names.


8.	Name four factors to consider when choosing between SQL Database and SQL Server in Azure VirtualMachines.
database size, existing application versus new application, level of administrative control (including hardware infrastructure), business continuity strategy, and hybrid scenarios,
9.	Who did Microsoft collaborate with to bring their ClearDb database as a service for MySQL to theAzure platform?
SuccessBricks

10.	What two options exist in Azure if you dont need a relational database management system (RDBMS)baseddata storage solution such as SQL Database or SQL Server in Azure Virtual Machines?

1. Run MySQL as a service via Microsoft’s partnership with SuccessBrick’s ClearDb offering
2. Use a NoSQL service such as DocumentDB or Azure Table storage. 
