public class ProductIssueModel
{
    public Guid ProductRowGuid { get; set; }
    public string IssueNumber { get; set; }
    public string ProductName { get; set; }
    public string ProductNumber { get; set; }
    public Guid StoreId { get; set; }
    public string ToolStatus { get; set; }
    public Guid IssuedToUserId { get; set; }
    public Guid? ProjectId { get; set; }
    public DateTime ExpectedReturnDate { get; set; }
    public string Priority { get; set; }
    public string Notes { get; set; }
    public string ConditionOnIssue { get; set; }
    public DateTime? LastMaintenanceDate { get; set; }
    public string ConditionNotes { get; set; }
    // Add other necessary properties
}