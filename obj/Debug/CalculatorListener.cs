//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Dennis Mathew\documents\visual studio 2015\Projects\CalculatorApp\CalculatorApp\Grammar\Calculator.g4 by ANTLR 4.6.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace CalculatorApp.Grammar {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="CalculatorParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.1")]
[System.CLSCompliant(false)]
public interface ICalculatorListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParens([NotNull] CalculatorParser.ParensContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parens</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParens([NotNull] CalculatorParser.ParensContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMulDiv([NotNull] CalculatorParser.MulDivContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>MulDiv</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMulDiv([NotNull] CalculatorParser.MulDivContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddSub([NotNull] CalculatorParser.AddSubContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>AddSub</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddSub([NotNull] CalculatorParser.AddSubContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>UnaryMinus</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUnaryMinus([NotNull] CalculatorParser.UnaryMinusContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>UnaryMinus</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUnaryMinus([NotNull] CalculatorParser.UnaryMinusContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFloat([NotNull] CalculatorParser.FloatContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>float</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFloat([NotNull] CalculatorParser.FloatContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>Gauss</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterGauss([NotNull] CalculatorParser.GaussContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>Gauss</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitGauss([NotNull] CalculatorParser.GaussContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInt([NotNull] CalculatorParser.IntContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>int</c>
	/// labeled alternative in <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInt([NotNull] CalculatorParser.IntContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] CalculatorParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] CalculatorParser.ProgContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] CalculatorParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="CalculatorParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] CalculatorParser.ExprContext context);
}
} // namespace CalculatorApp.Grammar