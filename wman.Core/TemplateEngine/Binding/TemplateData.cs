using wman.Core.TemplateEngine.Binding.Metadata;

namespace wman.Core.TemplateEngine.Binding
{
	/// <summary>
	/// Represents template data.
	/// </summary>
	public class TemplateData
	{
		/// <summary>
		/// Gets or sets the model metadata.
		/// </summary>
		public ModelMetadata ModelMetadata { get; set; }

		/// <summary>
		/// Gets or sets the model.
		/// </summary>
		public object Model { get; set; }
	}
}