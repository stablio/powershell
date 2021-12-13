namespace PnP.PowerShell.Commands.Model.ServiceHealth
{
    /// <summary>
    /// Contains additional details on a service health issue
    /// </summary>
    public class ServiceHealthIssueDetail
    {
        /// <summary>
        /// Name of the additional details, i.e. ExternalLink
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Contents of the additional details, i.e. a hyperlink
        /// </summary>
        public string Value { get; set; }
    }
}