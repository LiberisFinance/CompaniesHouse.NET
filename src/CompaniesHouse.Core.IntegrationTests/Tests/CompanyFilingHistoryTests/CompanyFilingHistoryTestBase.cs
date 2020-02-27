﻿using System;
using System.Threading.Tasks;
using CompaniesHouse.Core.Response.CompanyFiling;
using NUnit.Framework;

namespace CompaniesHouse.Core.IntegrationTests.Tests.CompanyFilingHistoryTests
{
    public abstract class CompanyFilingHistoryTestBase
    {
        protected CompaniesHouseClient _client;

        [SetUp]
        public async Task Setup()
        {
            GivenACompaniesHouseClient();
            await When()
                .ConfigureAwait(false);
        }

        protected abstract Task When();

        private void GivenACompaniesHouseClient()
        {
            var settings = new CompaniesHouseSettings(Keys.ApiKey);
            _client = new CompaniesHouseClient(settings);
        }
    }
}
