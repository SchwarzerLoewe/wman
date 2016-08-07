using System.IO;
using wman.Core.TemplateEngine.Parser.SyntaxTree;

namespace wman.Core.TemplateEngine.Renderer
{
    /// <summary>
	/// Provides rendering of expressions.
	/// </summary>
	public class ExpressionSpanRenderer : SpanRenderer
	{
		/// <inheritdoc />
		public override void Render(Span target, RenderContext context, TextWriter writer)
		{
			object value = context.ResolveValue(target);

			Write(context, writer, value);
		}
	}
}