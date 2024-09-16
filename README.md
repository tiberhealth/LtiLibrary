# LTI Library - Tiber Health Innovations Port / Fork
This is a port of the LTI Library to DotNet 8.0 and the removal of the DotNet Standard dependancies due to security issues and Vulnerabilities. 

This is a fork from [LTILibrary/LTILibrary](https://github.com/LtiLibrary/LtiLibrary)

# LTI Library
There are two .NET 8.0 projects in this solution to support IMS LTI Tool Providers and Tool Consumers. The Visual Studio solution and project files are compatible with Visual Studio 2019.

These libraries are also developed and test on an ARM processor to be used with Mac, Linux and Windows platforms.

## LtiLibrary.NetCore
This is the only library you need if you are going to roll your own support for web pages or native apps.

This library includes the classes, properties, and methods to support LTI 1.1.1 launch, outcomes, content items and tool consumer profiles for both Tool Consumers and Tool Providers.

## Ltibrary.AspNetCore
This library depends on LtiLibrary.NetCore and adds useful extensions and helper methods for ASP.NET Core 2.0+ applications such as an OutcomesApiController which implements the LTI Outcomes API as a Controller.

## Test Projects
There are also two xUnit test projects: one for each project above. These can be helpful examples for how to use the libraries.
