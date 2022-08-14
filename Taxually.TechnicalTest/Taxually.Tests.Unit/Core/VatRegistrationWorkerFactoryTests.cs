﻿namespace Taxually.Tests.Unit.Core
{
    public class VatRegistrationWorkerFactoryTests
    {
        [TestCase("GB")]
        [TestCase("FR")]
        [TestCase("DE")]
        public void GetVatRegistrationWorker_ShouldReturnProperInstance(string country)
        {
            // ...
        }

        [Test]
        public void GetVatRegistrationWorker_WhenCountryDoesNotExist_ShouldThrowException()
        {
            // ...
        }
    }
}
