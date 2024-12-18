using Microsoft.EntityFrameworkCore;

using Moq;

using Realme.Mvc.Models;
using Realme.Mvc.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realme.XUnit
{
    public class EmployeeRepositoryTests
    {
        private readonly Mock<AppDbContext> _mockContext;
        private readonly EmployeeRepository _repository;

        public EmployeeRepositoryTests()
        {
            _mockContext = new Mock<AppDbContext>();
            _repository = new EmployeeRepository(_mockContext.Object);
        }

        // Test methods go here...
        [Fact]
        public async Task GetByIdAsync_ReturnsEmployee_WhenEmployeeExists()
        {
            // Arrange
            var employee = new Employee { Id = 1, Name = "John Doe" };
            var mockSet = new Mock<DbSet<Employee>>();
            mockSet.Setup(m => m.FindAsync(1)).ReturnsAsync(employee);

            _mockContext.Setup(m => m.Employees).Returns(mockSet.Object);

            // Act
            var result = await _repository.GetByIdAsync(1);

            // Assert
            Assert.Equal(employee, result);
        }

        [Fact]
        public async Task GetAllAsync_ReturnsAllEmployees()
        {
            // Arrange
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John Doe" },
                new Employee { Id = 2, Name = "Jane Doe" }
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Employee>>();
            mockSet.As<IQueryable<Employee>>().Setup(m => m.Provider).Returns(employees.Provider);
            //mockSet.As<IQueryable<Employee>>().Setup(m => m.Provider).Returns(new TestAsyncQueryProvider<Employee>(employees.Provider));
            mockSet.As<IQueryable<Employee>>().Setup(m => m.Expression).Returns(employees.Expression);
            mockSet.As<IQueryable<Employee>>().Setup(m => m.ElementType).Returns(employees.ElementType);
            mockSet.As<IQueryable<Employee>>().Setup(m => m.GetEnumerator()).Returns(employees.GetEnumerator());

            _mockContext.Setup(m => m.Employees).Returns(mockSet.Object);

            // Act
            var result = await _repository.GetAllAsync();

            // Assert
            Assert.Equal(2, result.Count());
        }
        [Fact]
        public async Task AddAsync_AddsEmployee()
        {
            // Arrange
            var employee = new Employee { Id = 1, Name = "John Doe" };
            var mockSet = new Mock<DbSet<Employee>>();
            _mockContext.Setup(m => m.Employees).Returns(mockSet.Object);

            // Act
            await _repository.AddAsync(employee);

            // Assert
            mockSet.Verify(m => m.AddAsync(employee, default), Times.Once);
            _mockContext.Verify(m => m.SaveChangesAsync(default), Times.Once);
        }
        [Fact]
        public async Task UpdateAsync_UpdatesEmployee()
        {
            // Arrange
            var employee = new Employee { Id = 1, Name = "John Doe" };
            var mockSet = new Mock<DbSet<Employee>>();
            _mockContext.Setup(m => m.Employees).Returns(mockSet.Object);

            // Act
            await _repository.UpdateAsync(employee);

            // Assert
            mockSet.Verify(m => m.Update(employee), Times.Once);
            _mockContext.Verify(m => m.SaveChangesAsync(default), Times.Once);
        }
        [Fact]
        public async Task DeleteAsync_DeletesEmployee()
        {
            // Arrange
            var employee = new Employee { Id = 1, Name = "John Doe" };
            var mockSet = new Mock<DbSet<Employee>>();
            mockSet.Setup(m => m.FindAsync(1)).ReturnsAsync(employee);
            _mockContext.Setup(m => m.Employees).Returns(mockSet.Object);

            // Act
            await _repository.DeleteAsync(1);

            // Assert
            mockSet.Verify(m => m.Remove(employee), Times.Once);
            _mockContext.Verify(m => m.SaveChangesAsync(default), Times.Once);
        }




    }

}
