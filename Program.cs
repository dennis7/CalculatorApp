using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using CalculatorApp.Grammar;
using CalculatorApp.Implementation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader inputStream = new StreamReader(Console.OpenStandardInput());
                AntlrInputStream input = new AntlrInputStream(inputStream.ReadToEnd());
                CalculatorLexer lexer = new CalculatorLexer(input);
                CommonTokenStream tokens = new CommonTokenStream(lexer);
                CalculatorParser parser = new CalculatorParser(tokens);
                IParseTree tree = parser.prog();
                Console.WriteLine(tree.ToStringTree(parser));
                CalculatorVisitor visitor = new CalculatorVisitor();
                Console.WriteLine(visitor.Visit(tree));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
