grammar Calculator;
 
@parser::members
{
    protected const int EOF = Eof;
}
 
@lexer::members
{
    protected const int EOF = Eof;
    protected const int HIDDEN = Hidden;
}
 
/*
 * Parser Rules
 */
 
prog: expr+ ;
 
expr : expr op=('*'|'/') expr   # MulDiv
     | expr op=('+'|'-') expr   # AddSub
     | INT                  # int
	 | FLOAT                # float
     | '(' expr ')'         # parens
	 | '-' expr        # UnaryMinus
	 | GAUSS '(' expr ',' expr ',' expr ',' expr ')' #Gauss
     ;
 
/*
 * Lexer Rules
 */
INT : [0-9]+;
FLOAT		:	[0-9]+ ('.') [0-9]*
			|	('.') [0-9]+
				;
MUL : '*';
DIV : '/';
ADD : '+';
SUB : '-';
GAUSS		:	[Gg][Aa][Uu][Ss][Ss]				;
WS
    :   (' ' | '\r' | '\n') -> channel(HIDDEN)
    ;