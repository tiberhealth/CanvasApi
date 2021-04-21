using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace CanvasApi.Client.Test
{
    public abstract class RolesvilleUniversityTest
    {
        protected ServiceCollection ServiceCollection { get; private set; }

        [SetUp]
        public void Setup()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings-test.json", true)
                .AddEnvironmentVariables()
                .Build();

            var canvasDomain = config["CanvasHost"];
            var apiKey = config["TestCanvasApiToken"];

            this.ServiceCollection = new ServiceCollection();

            this.ServiceCollection.AddHttpClient<ICanvasApiClient, CanvasApiClient>(client =>
                client.ConfigureCanvasApi(canvasDomain, apiKey)
            );
        }
    }
}
