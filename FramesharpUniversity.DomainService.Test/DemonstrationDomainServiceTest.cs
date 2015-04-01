﻿using System;
using Framesharp.DomainService;
using Framesharp.Data.Transaction;
using Framesharp.Test;
using FramesharpUniversity.Configuration;
using FramesharpUniversity.Domain;
using FramesharpUniversity.DomainService.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FramesharpUniversity.DomainService.Test
{
    [TestClass]
    public class DemonstrationDomainServiceTest : TestClassBase
    {
        private readonly IDemonstrationDomainService _demonstrationDomainService;

        public DemonstrationDomainServiceTest() : base(new RootApplicationSettings())
        {
            _demonstrationDomainService = DomainServiceFactory.Get<IDemonstrationDomainService>(OperationCallContext);
        }

        /// <summary>
        /// Creates a new Demonstration record
        /// </summary>
        [TestMethod]
        [TransactionScope(DefaultRollback = false)]
        public void CreateDemonstrationTest()
        {
            Demonstration demonstration = new Demonstration()
            {
                SomeDescription = string.Format("Test description {0}", DateTime.Now.Ticks),
                SomeNumber = (int)DateTime.Now.Ticks / 2,
                SomeFlag = true,
            };

            _demonstrationDomainService.CreateDemonstration(
                demonstration.SomeDescription, 
                demonstration.SomeNumber, 
                demonstration.SomeFlag);
        }

        /// <summary>
        /// Gets a demonstration by database identification number
        /// </summary>
        /// <returns>An instance of <see cref="Domain.Demonstration"/></returns>
        [TestMethod]
        public void GetDemonstrationTest()
        {
            Demonstration demonstration = EquivalencePartition.GetRandom<Demonstration>();

            if (demonstration == null) Assert.Inconclusive("Demonstration table is empty");

            _demonstrationDomainService.GetDemonstration(demonstration.DemonstrationId);
        }
    }
}
