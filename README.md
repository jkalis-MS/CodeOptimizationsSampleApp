This repo has a specific code to generate Application Insights Code Optimizations recommendations for testing and demo purposes.

More resources:
- Code Optimizations in Azure portal https://aka.ms/CodeOptimizations
- Code Optimizations Documentation https://aka.ms/CodeOptimizations/Docs
- Latest updates and upcoming features https://aka.ms/CodeOptimizations/LatestUpdates

For any questions or comments, please reach out to CodeOptimizations@Microsoft.com

# How to publish this app and set-up Application Insights Code Optimizations
The steps are simple, first publish this app into Azure App Service, second enable Application Insights, third enable Application Insights Profiler.

## 1. Publishing the app
Feel free to use the IDE of your choice. Below is a detailed description for Visual Studio.

1.1. Clone this repo in VS  
1.2. Open the project  
1.3. Right-click the app "**Store**" in solutio explorer and select "**Publish...**"  
1.4. In the Publish dialog choose **Azure**, then Azure **App Service (Windows)**  
1.5. Choose a subscription of your choice, then either select an existing App Service or create new  
1.6. Once ready, press **Finish** to create publish profile 
1.7. Close the dialog and press **Publish**

Once published and the app is started a browser window opens with the home page "Hello World!" and version of the app.


