This repo has a specific code to generate Application Insights Code Optimizations recommendations for testing and demo purposes.

More resources:
- Code Optimizations in Azure portal https://aka.ms/CodeOptimizations
- Code Optimizations Documentation https://aka.ms/CodeOptimizations/Docs
- Latest updates and upcoming features https://aka.ms/CodeOptimizations/LatestUpdates

For any questions or comments, please reach out to CodeOptimizations@Microsoft.com

# How to publish this app and set-up Application Insights Code Optimizations
The steps are simple, first publish this app into Azure App Service, second enable Application Insights and Application Insights Profiler, third create some load to your application

## 1. Publishing the app
Feel free to use the IDE of your choice. Below is a detailed description for Visual Studio.

1.1. Clone this repo in VS  
1.2. Open the project  
1.3. Right-click the app "**Store**" in solutio explorer and select "**Publish...**"  
1.4. In the Publish dialog choose **Azure**, then Azure **App Service (Windows)**  
1.5. Choose a subscription of your choice, then either select an existing App Service or create new - _make sure to note the name of the App Service_ (e.g. "my_Shop_Demo_App")
1.6. Once ready, press **Finish** to create publish profile 
1.7. Close the dialog and press **Publish**

Once published and the app is started a browser window opens with the home page "Hello World!" and version of the app.

## 2. Enabling Application Insights

2.1. Open Azure portal and open the App Service resource you have just published your app to in step 1.5.  
2.2. In the **Overview** page in the **Properties** section, find Application Insights and click **Enable Application  Insights** link  
2.3. Click **Turn on Application Insights** button  
2.4. Here you can either create new Application Insights resource or choose an existing one (yes, multiple apps can send data to one Application Insights)  
2.5. Click **Apply**  
2.6. Once ready, doublecheck that in the **.NET Core** tab the Profiler is **On**  





