namespace CanvasApi.Client.Test.EnrollmentTerms
{
    public class TestEnrollmentTerms: TestSetup
    {
        [Test]
        public async Task TestEnrollmentTermsFull()
        {
            // Test Values
            var termName = $"Test Term {Guid.NewGuid()}";
            var startAt = DateTime.Now.Date.AddDays(-10);
            var endAt = startAt.AddDays(90);
            var sisTermId = Guid.NewGuid().ToString();
            var accountId = 1;

            var enrollmentTerm = await this.TestCreateEnrollmentTerm(
                termName,
                startAt,
                endAt,
                sisTermId,
                accountId
                );

            await this.TestRetrieveEnrollmentTerm(accountId, enrollmentTerm);
            await this.TestDeleteEnrollment(accountId, enrollmentTerm.Id);
        }

        [Test]
        public async Task TestEnrollmentTermsList()
        {
            await this.TestListEnrollmentTerm(1, null); 
        }


        /// <summary>
        /// Test the creation of the enrollment term
        /// </summary>
        /// <param name="termName"></param>
        /// <param name="startAt"></param>
        /// <param name="endAt"></param>
        /// <param name="sisTermId"></param>
        /// <param name="accountId"></param>
        /// <returns></returns>
        private async Task<IEnrollmentTerm> TestCreateEnrollmentTerm(
            string termName,
            DateTime startAt,
            DateTime endAt,
            string sisTermId,
            long accountId
            )
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            ClassicAssert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            ClassicAssert.IsNotNull(api);

            var enrollmentTerm = await api.EnrollmentTerms.Create(accountId, request =>
            {
                request.Name = termName;
                request.StartAt = startAt;
                request.EndAt = endAt;
                request.SisTermId = sisTermId;
            });

            ClassicAssert.IsNotNull(enrollmentTerm);
            ClassicAssert.AreEqual(termName, enrollmentTerm.Name);
            ClassicAssert.AreEqual(startAt.Date, enrollmentTerm.StartAt?.Date);

            return enrollmentTerm;
        }

        /// <summary>
        /// Compares two terms records
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        private void CompareTerms(IEnrollmentTerm expected, IEnrollmentTerm actual)
        {
            ClassicAssert.IsNotNull(expected);
            ClassicAssert.IsNotNull(actual);

            ClassicAssert.AreEqual(expected.Name, actual.Name);
            ClassicAssert.AreEqual(expected.StartAt, actual.StartAt);
            ClassicAssert.AreEqual(expected.EndAt, actual.EndAt);
            ClassicAssert.AreEqual(expected.SisImportId, actual.SisImportId);
            ClassicAssert.AreEqual(expected.SisTermId, actual.SisTermId);

        }

        /// <summary>
        /// Test the ability to retreive an enrollment term record
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="enrollmentTerm"></param>
        /// <returns></returns>
        private async Task<IEnrollmentTerm> TestRetrieveEnrollmentTerm(long accountId, IEnrollmentTerm enrollmentTerm)
        {
            var api = this.ServiceCollection.BuildServiceProvider().GetRequiredService<ICanvasApiClient>();
            ClassicAssert.IsNotNull(api);

            var term = await api.EnrollmentTerms.Retrieve(accountId, enrollmentTerm.Id);
            this.CompareTerms(enrollmentTerm, term);

            return term;
        }

        /// <summary>
        /// Test getting the enrollment list
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="enrollmentTerm"></param>
        /// <returns></returns>
        private async Task TestListEnrollmentTerm(long accountId, IEnrollmentTerm enrollmentTerm = null)
        {
            var api = this.ServiceCollection.BuildServiceProvider().GetRequiredService<ICanvasApiClient>();
            ClassicAssert.IsNotNull(api);

            var enrollmentTerms = await api.EnrollmentTerms.List(accountId);

            ClassicAssert.IsNotNull(enrollmentTerms);
            ClassicAssert.IsNotEmpty(enrollmentTerms);

            var enrollmentTermsCount = enrollmentTerms.Count(); 
            ClassicAssert.Greater(enrollmentTermsCount, 0);

            if (enrollmentTerm != null)
            {
                var term = enrollmentTerms.SingleOrDefault(item => item.Name == enrollmentTerm.Name);
                this.CompareTerms(enrollmentTerm, term);
            }
        }


        /// <summary>
        /// Test the deleting of an Enrollment Term
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="termId"></param>
        /// <returns></returns>
        private async Task TestDeleteEnrollment(long accountId, long termId)
        {
            var services = this.ServiceCollection.BuildServiceProvider();
            ClassicAssert.IsNotNull(services);

            var api = services.GetRequiredService<ICanvasApiClient>();
            ClassicAssert.IsNotNull(api);

            var deleteResponse = await api.EnrollmentTerms.Delete(accountId, termId);

            ClassicAssert.IsNotNull(deleteResponse);
        }
    }
}
