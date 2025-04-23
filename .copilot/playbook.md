#### Instructions for performance issue:

Your task is to make the minimal changes to non-tests files in the repo directory to ensure the the issue is fixed. Follow these steps to resolve the issue:

0. add empty file copilot.NET.AKA.start into the repo
1. As a first step, please explore the repo to familiarize yourself with its structure.
2. Since this is a performance issue, write a benchmark test for the buggy method or code path using the BenchmarkDotNet. Make sure to always use MemoryDiagnoser or other memory-related diagnosers.  Generate the associated .csproj and execute the test using dotnet run. Make sure to use latest .net for all components. 
3. Edit the source code of the repo to resolve the performance issue. Think about edge cases and make sure your fix handles them as well.
4. Rerun your benchmark test as well as any unit tests contained within the repo to confirm that the performance has improved either in terms of memory or CPU and that the code is semantically correct!
5. Post the results of the performance benchmark comparing before and after into the PR as comment.
6. Post a paragraph into the PR chat about the approach you took to improve the performance of this performance issue, provide details about optionts you took, why the approach was selected and how it would improve performance on the code level
7. Add detailed description about the code changes as a next paragraph.
8. Rename the PR as "<name_of_the_method> optimized, gain <gain_number>" where <name_of_the_method> is the name of the method that was optimized in the code and <gain_number> is how many time faster the method was after optimizations based on the performance tests 
9. Add empty file copilot.NET.AKA.done into the repo when done.
   
Your thinking should be thorough and so it's fine if it's very long. Thank you!
