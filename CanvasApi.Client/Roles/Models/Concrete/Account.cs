using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models.Concrete
{
    internal class Account : IAccount
    {
        [Multipart("id")] public long? Id { get; set; }
        [Multipart("name")] public string Name { get; set; }
        [Multipart("parent_account_id")] public long? ParentAccountId { get; set; }
        [Multipart("idroot_account_id")] public long? RootAccountId { get; set; }
        [Multipart("sis_account_id")] public string SisAccountId { get; set; }

    }
}
