using System.Collections.Generic;
using mvc_test.Controllers;
using mvc_test.Models;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Tests.Helpers
{
    public class HomeControllerTests
    {
        class ModelCompleteFakeRepository: IRepository 
        {
            public IEnumerable<Product> Products { get; } = new Product[]
            {
                new Product{Name="P1", Price = 1M},
                new Product{Name="P2", Price = 2M},
                new Product{Name="P3", Price = 3M},
                new Product{Name="P4", Price = 4M}
            };

            public void AddProduct(Product p )
            { }
        }

        [Fact]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            var controller = new HomeController();
            controller.Repository = new ModelCompleteFakeRepository();

            // Act
            var model = ((ViewResult)controller.Index())?.ViewData.Model as IEnumerable<Product>;

            //Assert
            Assert.Equal(controller.Repository.Products, model, 
                Comparer.Get<Product>((p1, p2)=> p1.Name == p2.Name && p1.Price == p2.Price));
        }
    }
}