# MediatrPerformanceTest
Repo containing some performance testings against the Mediatr library.

Benchmark code is located under the Benchmarker folder, while the WebApi is located under the WebApi folder. 

Each folder contains a powershell scripts that will run each solution from the command line. If you want to run the benchmark please launch WebApi before you start the Benchmark. 

I ran both solutions using version 2.2.300 of DotNet Core. The global.json files controls the DotNet version used. If you don't have that installed or want to test with a later version, feel free remove it or change to whatever version you have installed on your local machine. 
