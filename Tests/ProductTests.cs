using System;
using mvc_test.Models;
using Xunit;

namespace Tests
{
    public class ProductTests
    {
        [Fact]
        public void CanChangeProductName()
        {
            // Arrange
            var p = new Product {Name = "Old Name", Price = 1M};

            // Act
            p.Name = "New Name";

            // Assert
            Assert.Equal("New Name", p.Name);
        }

        [Fact]
        public void CanChangeProductPrice()
        {
            // Arrange
            var p = new Product { Name = "Old Name", Price = 1M };

            // Act
            p.Price = 2M;

            // Assert
            Assert.Equal(2M, p.Price);
        }

    }
}
