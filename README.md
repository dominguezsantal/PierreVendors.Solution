# _Pierre's Store Vendor Application_

#### By _**Alex G.Dominguez **_

## Description
 MVC application to help track the vendors that purchase baked goods from Pierre and the orders belonging to those vendors.

## Technologies Used

* NuGet Package Manager
* .Net 5
* C#
* Razor

## Setup/Installation Requirements

* Download option
  * Download files from GitHub repository by click Code and Download Zip
  * Extract files into a single directory 
  * Run GitBASH in directory
  * Enter "Template" in the directory
  * Type "dotnet run" in GitBash to run the program
  
  * Testing
  Navigate to StoreVendors.Tests by running cd StoreVendors.Tests.
Run dotnet restore to retrieve and install the packages we listed in StoreVendors.csproj.
Run dotnet test.



* Cloning
  * Clone github repo: https://github.com/dominguezsantal/PierresVendors.Solution.git
* Navigate the directory: (cd top name directory)
* Open in Vs code: code .
* Navigate to the ProjectName.Tests within the terminal: cd StoreVendors.Tests
* Run: dotnet restore
* The line above will create your obj directories.


## Test Diagram 
## Tests:
Test Number | Failed/Passed | Details | 
--- | --- | --- |
1 | Failed on purpose | good fail on line 20 (OrderTests.cs) now passing|
2 | Passed | Test 1 passed|
3 | Failed | naming issue fixed in both Model Test dependencies|
4 | Passed | Test 3 passed|
5 | Failed | Good fail on AreEqual parameter updatedBillionaire instead of updatedNew|
6 | Passed | Test 5 passed|
7 | Failed |instantiateID test good fail|
8 | Passed|Test 7 is passing now|
9| Failed |good fail test of returning vendors correct newOrder ID |
10| Fialed/Passed | good fail of test #10. On purpose, misspelled result.Now passed|
11| Failed |test #11 good fail. Add return vendors by ID method. On purpose, changing parameter |
12|Failed/Passed| test #12 good fail. newList puposefully changed to newOctollionaire|13| Passed| Test 12 passed|
14|Fail| Test #14 good fail: changed one of the are equal method parameters
15| Passed| Test 14 passed|


@dominguezsantal
|

  

## Known Bugs
_?_


### Other Links
[Github Alex Domin](https://github.com/dominguezsantal)


### License

Copyright (c) 2021 **_{Alex Dominguez}_**
Licensed under [MIT]