﻿namespace ServiceStack.Request.Correlation.Tests
{
    using System.Collections.Generic;
    using FluentAssertions;
    using Xunit;

    public class CollectionExtensionsTests
    {
        [Fact]
        public void InsertAsFirst_HandlesNullList()
        {
            List<string> list = null;

            list.InsertAsFirst("hi");

            // No assertion, no error thrown
        }

        [Fact]
        public void InsertAsFirst_AddsAtPosition0_EmptyList()
        {
            var list = new List<string>();

            const string toAdd = "hi";
            list.InsertAsFirst(toAdd);

            list[0].Should().Be(toAdd);
        }

        [Fact]
        public void InsertAsFirst_AddsAtPosition0_PopulatedList()
        {
            var list = new List<string> { "One", "Two", "Three" };

            const string toAdd = "hi";
            list.InsertAsFirst(toAdd);

            list[0].Should().Be(toAdd);
        }

        [Fact]
        public void InsertAsFirst_AddToPopulatedList()
        {
            var list = new List<string> { "One", "Two", "Three" };

            list.InsertAsFirst("hi");

            list.Count.Should().Be(4);
        }
    }
}
