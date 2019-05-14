namespace Xunit.Gherkin.Quick
{
    /// <summary>
    /// Annotates method for scenario step which starts with "Step".
    /// </summary>
    public sealed class StarAttribute : BaseStepDefinitionAttribute
    {
        /// <summary>
        /// Initializes a new instance of <see cref="AndAttribute"/> class.
        /// </summary>
        /// <param name="pattern">Regex pattern that must completely match 
        /// a scenario step.</param>
        public StarAttribute(string pattern)
            : base("*", pattern)
        {
           
        }
    }
}
