# CalculatorApp
Simple Calculator 

To Run
1. Enter the expression on the console and hit enter
2. Ctrl + Z
3. Output is displayed.


References
https://github.com/tunnelvisionlabs/antlr4cs
https://github.com/shmatov/antlr4-calculator
https://github.com/antlr/grammars-v4


To extend calculator functionilty 
1. Update the grammar file -  \CalculatorApp\CalculatorApp\Grammar\Calculator.g4
2. Build solution to generate classes for the updated grammar
3. Override the Visitor Methods in CalculatorApp\CalculatorApp\Implementation\CalculatorVisitor.cs
