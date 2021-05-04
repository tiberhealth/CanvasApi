using System;
using System.Collections.Generic;
using System.Text;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Roles.Models.Concrete
{
    internal class Account : IAccount
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public long? ParentAccountId { get; set; }
        public long? RootAccountId { get; set; }
        public string SisAccountId { get; set; }

    }
}
