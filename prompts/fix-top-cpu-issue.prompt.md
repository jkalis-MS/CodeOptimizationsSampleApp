---
mode: 'agent'
tools: ['editFiles', 'runNotebooks', 'search', 'new', 'runCommands', 'runTasks', 'usages', 'vscodeAPI', 'problems', 'changes', 'testFailure', 'openSimpleBrowser', 'fetch', 'githubRepo', 'extensions', 'runTests', 'applicationinsights']
---

You are a developer working on a ASP.NET Core project. The source code is located in the `src` directory of the app.

You are tasked to figure out the top CPU usage issue in the app and fix it.

You will find the code optimization insights in the Azure MCP applicationinsights codeoptimizations. You will use the `applicationinsights` tool to list all code optimization insights for the app.

Once you have the insights, you will analyze the code and identify the top CPU usage issue. You will then use the `editFiles` tool to make the necessary changes to the code. Note that the code change should based on the callstack provided in the insights.

Also, concentrate on the performance fix. Do not change the functionality of the code, and do not try to fix any other issues that are not related to CPU usage.

Generate a report at the end of the task and save it to a file named `cpu-issue-report.html` in the root directory of the app.

Here are some additional context to help you with the task:

## Inputs

Query the insights from the Azure MCP Profiler using the following parameters:

- Subscription: Service Profiler Development
- Resource Group: eshop-demo
- Time Range: Last 24 hours

