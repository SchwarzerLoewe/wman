using System.IO;
using wman.Core.TemplateEngine.Parser.SyntaxTree;

namespace wman.Core.TemplateEngine.Renderer
{
    /// <summary>
	/// Defines the required contract for implementing a syntax tree renderer.
	/// </summary>
	public interface ISyntaxTreeNodeRenderer<in T> where T : SyntaxTreeNode
	{
		/// <summary>
		/// Renders the specified syntax tree node.
		/// </summary>
		/// <param name="target">The target node.</param>
		/// <param name="context">The context.</param>
		/// <param name="writer">The writer.</param>
		void Render(T target, RenderContext context, TextWriter writer);
	}
}