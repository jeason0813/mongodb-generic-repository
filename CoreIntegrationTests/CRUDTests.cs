﻿using CoreIntegrationTests.Infrastructure;
using System;

namespace CoreIntegrationTests
{
    public class CoreTestDocument : TestDoc
    {
    }

    public class CRUDTests : MongoDbDocumentTestBase<CoreTestDocument>
    {
        public CRUDTests(MongoDbTestFixture<CoreTestDocument, Guid> fixture) : base(fixture)
        {

        }

        public override string GetClassName()
        {
            return "CRUDTests";
        }
    }
}
