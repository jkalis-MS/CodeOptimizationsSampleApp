This repo has a specific code to generate Application Insights Code Optimizations recommendations for testing and demo purposes.

More resources:
- Code Optimizations in Azure portal https://aka.ms/CodeOptimizations
- Code Optimizations Documentation https://aka.ms/CodeOptimizations/Docs
- Latest updates and upcoming features https://aka.ms/CodeOptimizations/LatestUpdates

For any questions or comments, please reach out to CodeOptimizations@Microsoft.com

# How to publish this app and set-up Application Insights Code Optimizations
The steps are simple, **first** publish this app into Azure App Service, **second** enable Application Insights and Application Insights Profiler, **third** generate incoming requests for your application

## 1. Publishing the app
Feel free to use the IDE of your choice. Below is a detailed description for Visual Studio.

1.1. Clone this repo in VS  
1.2. Open the project  
1.3. Right-click the app "**Store**" in solution explorer and select "**Publish...**"  
1.4. In the Publish dialog choose **Azure**, then Azure **App Service (Windows)**  
1.5. Choose a subscription, then either select an existing App Service or create new - _make sure to note the name of the App Service_ (e.g. "my_Shop_Demo_App")  
1.6. Once ready, press **Finish** to create publish profile  
1.7. Close the dialog and press **Publish**  
![](images/1.7.%20Publish.png)  
1.8. Once published and the app is started, a browser window will open with "Hello World!" and version of the app.  

## 2. Enabling Application Insights

2.1. Open Azure portal and open the App Service resource you have just published your app to in step 1.5.  
2.2. In the **Overview** page in the **Properties** section, find Application Insights and click **Enable Application  Insights** link  
2.3. Click **Turn on Application Insights** button  
2.4. Here you can either create new Application Insights resource or choose an existing one (yes, multiple apps can send data to one Application Insights resource)  
2.5. Click **Apply**  
2.6. Once ready, doublecheck that in the **.NET Core** tab the Profiler is **On**  
![](images/2.6.%20Profiler%20ON.png)  

2.7. In the App Service **Configuration** page, set **Always on** to **On**  

  
> [!IMPORTANT]  
> ### Enable Managed Identity
> Application Insights is by-default in "local authentication" mode. Which means that any application (if it knows the connection string with a unique instrumentation key) can send data to your Application Insights. A more secure way is using Microsoft Entra authentication.
> More details in the [documentation](https://learn.microsoft.com/en-us/azure/azure-monitor/profiler/profiler#enable-microsoft-entra-authentication-for-profile-ingestion).

_**The steps to enable system manged identity are as follows:**_

2.7. In your App Service, on the **Identity** page validate that **Status** for Sytem assigned identity is **On**  
2.8. On the same page click **Azure role assignments** and add a new role assignment **Monitoring Metrics Publisher**  
![](images/2.8.%20Managed%20identity.png)  

2.9. Once created, go back to your App Service and click on **Enviroment variables**. Add a new string **APPLICATIONINSIGHTS_AUTHENTICATION_STRING** with value Authorization=AAD. Click **Apply** and **Apply** again  
3.0. Open your **Application Insights** resource and then open the **Properties** page, find setting **LOCAL AUTHENTICATION** and Disable it. _IMPORTANT if other applications are sending data to this Application insights, please make sure that the managed identity is enabled for all such apps (steps 2.7. to 2.9.)_   


## 3. Add load to your application
The simplest way to generate incoming requests to your application is to create an Availability test *part of Application insights).  

3.1. In your Application Insights resource, open **Availability** page  
3.2. Click **Add standard test**, give it a name  
3.3. In the URL paste the homepage of your newely published app (from step 1.8, if you closed the window you can find the URL in the App Service Overview page)  
3.4. Open the **Perfomance** page and observe the incoming traffic
3.5. To speed up the Profile trace collection, you can increase the Profiler sampling to **Max** ( Profiler -> Triggers -> Sampling) 
3.6. Observe the Profiler page, once traces are visible, within an hour you sould see Code Optimizations  

![](images/3.4.%20Code%20Optimizations.png)  

For advanced Profiler troubleshooting you can use the Diagnostics Services status page https://<your_web_app_name>.scm.azurewebsites.net/diagnosticservices

