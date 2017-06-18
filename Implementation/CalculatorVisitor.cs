using CalculatorApp.Grammar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;

namespace CalculatorApp.Implementation
{
    class CalculatorVisitor : CalculatorBaseVisitor<int>
    {
        public override int VisitInt(CalculatorParser.IntContext context)
        {
                return int.Parse(context.INT().GetText());         
        }

        public override int VisitFloat([NotNull] CalculatorParser.FloatContext context)
        {
            string number = context.FLOAT().GetText();
            double result;
            Double.TryParse(number, out result);
            return (int)Math.Round(result, MidpointRounding.ToEven);

        }

        public override int VisitAddSub(CalculatorParser.AddSubContext context)
        {
            int left = Visit(context.expr(0));
            int right = Visit(context.expr(1));
            if (context.op.Type == CalculatorParser.ADD)
            {
                return left + right;
            }
            else
            {
                return left - right;
            }
        }

        public override int VisitMulDiv(CalculatorParser.MulDivContext context)
        {
            int left = Visit(context.expr(0));
            int right = Visit(context.expr(1));
            if (context.op.Type == CalculatorParser.MUL)
            {
                return left * right;
            }
            else
            {
                return left / right;
            }
        }

        public override int VisitParens(CalculatorParser.ParensContext context)
        {
            return Visit(context.expr());
        }

        public override int VisitUnaryMinus([NotNull] CalculatorParser.UnaryMinusContext context)
        {
            return 0 - Visit(context.expr());
        }

        public override int VisitGauss([NotNull] CalculatorParser.GaussContext context)
        {
            int a = Visit(context.expr(0));
            int b = Visit(context.expr(1));
            int c = Visit(context.expr(2));
            int x = Visit(context.expr(3));
            return x;
        }
    }
}
