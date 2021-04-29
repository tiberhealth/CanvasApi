using CanvasApi.Client.Admins.Enums;
using CanvasApi.Client.Users.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanvasApi.Client.Test.AdminTests
{
    public class TestAdmins : TestSetup
    {
        [Test]
        public Task TestAdminsFull()
        {
            var id = 8;
            var user = GetTestUser(id);
            //var workflowState = AdminListWorkflowState.Active;
            throw new NotImplementedException();
        }

        public Task<IUser> GetTestUser(long id)
        {
            throw new NotImplementedException();
            //TODO: Complete once Users becomes usable
        }
    }
}
