﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using CanvasApi.Client._Base;
using CanvasApi.Client.Acconts.Enums;
using CanvasApi.Client.Acconts.Models;

namespace CanvasApi.Client.Acconts
{
    internal class AccountsClient: ApiClientBase, IAccountsApi
    {        
        internal AccountsClient(CanvasApiClient parent): base(parent) { }

        public void CreateSubAccount(long accountId)
        {
            throw new NotImplementedException();
        }

        public void DeleteSubAccount(long accountId, long subAccountId)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserFromRootAccount(long accounId, long userId)
        {
            throw new NotImplementedException();
        }

        public void GetAccount(long accountId)
        {
            throw new NotImplementedException();
        }

        public void GetHelpLinks(long accountId)
        {
            throw new NotImplementedException();
        }

        public void GetPermission(long accountId, params string[] permissions)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Account>> GetSubAccounts(long accountId, bool recursive = false)
        {
            var url = $"/api/v1/accounts/{accountId}/sub_accounts?recursive={recursive.ToString()}";
            var results = await this.ApiClient.PagableApiOperation<Account>(Client.Enums.ApiVerb.Get, url);

            return results;
        }

        public Task<IEnumerable<Account>> GetSubAccounts(Account parentAccount, bool recursive = false) =>
            parentAccount != null ? this.GetSubAccounts(parentAccount.Id, recursive) : throw new ArgumentNullException(nameof(parentAccount));

        public void GetTermsOfService(long accountId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Account>> List(params Accountinclude[] include)
        {
            var url = "/api/v1/accounts";
            if ((include?.Length ?? 0) > 0) url += $"?include[]={string.Join(',', include)}";

            var results = await this.ApiClient.PagableApiOperation<Account>(Client.Enums.ApiVerb.Get, url);

            return results;
        }
            

        public void ListActiveCourses(long accountId)
        {
            throw new NotImplementedException();
        }

        public void ListCourseAdminAccounts()
        {
            throw new NotImplementedException();
        }

        public void UpdateAccount(long accountId)
        {
            throw new NotImplementedException();
        }
    }
}