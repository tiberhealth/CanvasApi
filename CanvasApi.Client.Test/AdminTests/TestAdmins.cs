namespace CanvasApi.Client.Test.AdminTests
{
    public class TestAdmins : TestSetup
    {
        [Test]
        public async Task TestAdminsFull()
        {
            var accountId = 1;
            var userId = 8;
            var adminListOriginal = await this.TestListAdmin(accountId);

            var admin = await this.TestPromoteAdmin(accountId, userId, adminListOriginal);

            var adminListNew = await this.TestListAdmin(accountId);

            await this.TestDemoteAdmin(accountId, userId, adminListNew);
        }

        public async Task<IEnumerable<IAdmin>> TestListAdmin(long accountId)
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            ClassicAssert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            ClassicAssert.IsNotNull(api);

            var adminList = await api.Admin.List(accountId, request =>
            {
            });

            ClassicAssert.IsNotNull(adminList);

            return adminList;
        }

        public async Task<IAdmin> TestPromoteAdmin(long accountId, int userId, IEnumerable<IAdmin> adminList)
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            ClassicAssert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            ClassicAssert.IsNotNull(api);

            var admin = await api.Admin.Promote(accountId, request =>
            {
                request.UserId = userId;
            });

            var newAdminList = await api.Admin.List(accountId, request =>
            {
            });


            ClassicAssert.IsNotNull(admin);

            ClassicAssert.AreEqual("Admin Test", admin.User.Name);

            ClassicAssert.Greater(newAdminList.Count(), adminList.Count());


            return admin;
        }

        public async Task<IAdmin> TestDemoteAdmin(long accountId, int userId, IEnumerable<IAdmin> adminList)
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            ClassicAssert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            ClassicAssert.IsNotNull(api);

            var admin = await api.Admin.Demote(accountId, userId);

            var newAdminList = await api.Admin.List(accountId, request =>
            {
            });


            ClassicAssert.IsNotNull(admin);
            ClassicAssert.Less(newAdminList.Count(), adminList.Count());


            return admin;
        }
    }
}
