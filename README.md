# MathDo

This Nuget package has a classe that help you in some math operations. This package is compatible with .NET Stantard 2.0.

### Get Started
___

I recommend you install this package with:

**Package Manager**
```
Install-Package MathDo -Version 1.0.0
``` 
OR

**.NET CLI**
```
dotnet add package MathDo --version 1.0.0
``` 


### Operations

For use the operation only add the namespate `MathDo` in section `using` of the your code and enjoy!

In this first version the package has only an operation.

- `MathDoCalc.Truncate(double value, int decimalPlace)`: return a double value with the number decimal place truncated. 
  
Example:

**Output will be:** 142.67

```
using System;
using MathDo;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var valueTruncated = MathDoCalc.Truncate(142.675345, 2);
            Console.WriteLine(valueTruncated);
            Console.ReadKey();
        }
    }
}
```
### Contributing
In lieu of a formal styleguide, take care to maintain the existing coding style. Add unit tests for any new or changed functionality.