using wman.Core.TemplateEngine.Parser.SyntaxTree;

namespace wman.Core.TemplateEngine.Renderer
{
    /// <summary>
	/// Provides a base implementation of a span renderer.
	/// </summary>
	public abstract class SpanRenderer : SyntaxTreeNodeRenderer<Span>, ISpanRenderer { }
}