using System.Collections.Generic;

namespace wman.Core.TemplateEngine.Operators
{
    /// <summary>
	/// Defines the required contract for implementing an operator provider.
	/// </summary>
	public interface IOperatorProvider
	{
		/// <summary>
		/// Gets the available operators.
		/// </summary>
		/// <returns>The set of operators.</returns>
		IEnumerable<IOperator> GetOperators();
	}
}