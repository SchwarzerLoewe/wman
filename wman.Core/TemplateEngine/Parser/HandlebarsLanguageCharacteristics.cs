using System.Collections.Generic;
using wman.Core.TemplateEngine.Text;
using wman.Core.TemplateEngine.Tokenizer;

namespace wman.Core.TemplateEngine.Parser
{
    /// <summary>
	/// Represents characteristics for the Handlebars language.
	/// </summary>
	public class HandlebarsLanguageCharacteristics : LanguageCharacteristics<HandlebarsTokenizer, HandlebarsSymbol, HandlebarsSymbolType>
	{
		public static readonly HandlebarsLanguageCharacteristics Instance = new HandlebarsLanguageCharacteristics();

		/// <inheritdoc />
		protected override HandlebarsSymbol CreateSymbol(SourceLocation location, string content, HandlebarsSymbolType type, IEnumerable<Error> errors)
		{
			return new HandlebarsSymbol(location, content, type, errors);
		}

		/// <inheritdoc />
		public override HandlebarsTokenizer CreateTokenizer(ITextDocument source)
		{
			return new HandlebarsTokenizer(source);
		}
	}
}