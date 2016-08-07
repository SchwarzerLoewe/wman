using System.IO;
using wman.Core.TemplateEngine.Parser.SyntaxTree;

namespace wman.Core.TemplateEngine.Renderer
{
    /// <summary>
	/// Renders text to the output writer.
	/// </summary>
	public class TextSpanRenderer : SpanRenderer
	{
		/// <inheritdoc />
		public override void Render(Span target, RenderContext context, TextWriter writer)
		{
			if (target.Collapsed)
			{
				// Span is collapsed, so do not render.
				return;
			}

			string content = target == null || target.Content == null ? string.Empty : target.Content;

			Write(context, writer, new SafeString(content));
		}
	}
}