using wman.Core.TemplateEngine.Renderer;

namespace wman.Core.TemplateEngine
{
    /// <summary>
    /// Represents a compiled Handlebars partial template.
    /// </summary>
    /// <param name="context">The parent render context.</param>
    /// <returns>The template result.</returns>
    public delegate string HandlebarPartialTemplate(RenderContext context);
}