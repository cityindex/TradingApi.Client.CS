﻿using NUnit.Framework;
using Rhino.Mocks;
using TradingApi.Client.Framework.Services;

namespace TradingApi.Client.Framework.Tests.Services.Tests
{
    [TestFixture]
    public class AccountInfoServiceFactoryTests
    {
        private IApiConnection _mockApiConnection;

        [SetUp]
        public void Setup()
        {
            _mockApiConnection = MockRepository.GenerateMock<IApiConnection>();
        }
        
        [Test]
        public void AccountServiceFactoryCreatesMarketInfoServiceWithAValidApiConnection()
        {
            var service = new AccountInfoServiceFactory().Create(_mockApiConnection);
            Assert.IsInstanceOfType(typeof(AccountInfoService), service);
        }
    }
}
