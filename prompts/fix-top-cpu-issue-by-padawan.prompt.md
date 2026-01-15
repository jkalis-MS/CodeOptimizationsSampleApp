---
mode: 'agent'
tools: ['codebase', 'usages', 'vscodeAPI', 'problems', 'changes', 'testFailure', 'terminalSelection', 'terminalLastCommand', 'openSimpleBrowser', 'fetch', 'findTestFiles', 'searchResults', 'githubRepo', 'extensions', 'runTests', 'editFiles', 'runNotebooks', 'search', 'new', 'runCommands', 'runTasks', 'applicationinsights']
---

You are a developer working on a ASP.NET Core project. The source code is located in the `src` directory of the app.

The GitHub repo has an agent to work on improving code. It needs as much details for the issue as possible, like issue descriptions, callstacks and so on.

Can you query the top CPU related code optimization insights, and create a github issue so that it can be fixed by the github coding agent?

Here are some additional context to help you with the task:

## Inputs

Query the insights from the Azure MCP Profiler using the following parameters:

- Subscription: Service Profiler Development
- App Id: 94adcdae-2d1b-4c68-9c1f-42d876be4c2c
- Time Range: Last 24 hours

