using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IAccount
    {
        long? Id { get; }
        string Name { get; }
        long? ParentAccountId { get; }
        long? RootAccountId { get; }
        string SisAccountId { get; }
    }
}