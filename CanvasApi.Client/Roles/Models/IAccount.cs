using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models
{
    public interface IAccount
    {
        [Multipart("id")] long? Id { get; }
        [Multipart("name")] string Name { get; }
        [Multipart("parent_account_id")] long? ParentAccountId { get; }
        [Multipart("root_account_id")] long? RootAccountId { get; }
        [Multipart("sis_account_id")] string SisAccountId { get; }
    }
}