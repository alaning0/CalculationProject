Calculation Project 
----

This project is a demonstration of how code can be reused. 

This is demonstrated in CalculationProjectTake1-4 

| Project | Description | 
| --- | --- |
| CalculationProjectTake1 | There is no attempt to reuse code. Calculation code is written directly into the main method, which receives input from the application arguments, and outputs to standard out |
| CalculationProjectTake2 | Calculation code is written in its own method as part of the same class |
| CalculationProjectTake3 | Calculation code is written in its own class as part of the same namespace (visual studio project) |
| CalculationProjectTake4 | Calculation code is written in its own project as part of the same visual studio solution. <br> The Calculation code in its own project is called from the main project through a project reference |

The ultimate goal here however is to use Assembly loading techniques to run existing compiled code, as demonstrated in the projects 
 - AssemblyHost0
 - AssemblyHost00

In both AssemblyHost projects, a target assembly (.dll file) is located, a Type is retrieved (class), an instance of the type is then created, and then a method inside of the type is retrieved an invoked. The only difference between AssemblyHost0 and AssemblyHost00 is 

| Project | Description | 
| --- | --- |
| AssemblyHost0 | The CalculationProjectTake4Calculator.dll assembly is located and the Calculate method is eventually called |
| AssemblyHost00 | The CalculationProjectTake4.dll assembly is located and the Main method is eventually called |