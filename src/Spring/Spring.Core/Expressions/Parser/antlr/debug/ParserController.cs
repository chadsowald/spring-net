namespace Spring.Expressions.Parser.antlr.debug
{
	using System;
	
	public interface ParserController : ParserListener
		{
			ParserEventSupport ParserEventSupport
			{
				set;
			}

			void  checkBreak();
		}
}