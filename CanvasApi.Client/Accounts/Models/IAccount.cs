namespace CanvasApi.Client.Accounts.Models;

public interface IAccount
{
    long Id { get; }
    string Name { get; }
    string Uuid { get; }
    long? ParentAccountId { get; }
    int? DefaultStorageQuotaMb { get; }
    int? DefaultUserStorageQuoateMb { get; }
    int? DefaultGroupStorageQuoteMb { get; }
    string DefaultTimeZone { get; }
    string SisAccountId { get; }
    string IntegrationId { get; }
    long? SisImportId { get; }
    string LtiGuid { get; }
    string WorkflowState { get; }
}
