using wman.Core.TemplateEngine.Parser.SyntaxTree;

namespace wman.Core.TemplateEngine.Renderer
{
    /// <summary>
	/// Defines the required contract for implementing a span renderer.
	/// </summary>
	public interface ISpanRenderer : ISyntaxTreeNodeRenderer<Span>
	{
	}
}