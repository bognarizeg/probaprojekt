using System;
using Xunit;
using l2l.Data.Model;
using l2l.Data.Repository;

namespace l2l.Data.Tests
{
/// <summary>
/// CRUD and list tests
/// </summary>    
    public class CourseRepositoryTests
    {
        [Fact]
        public void CourseRepositoryTests_AddedCoursesShouldBeAppearInRepository()
        {
            // Arrange

            //SUT: System Under Test
            var sut = new CourseRepository();
            var course = new Course { Id = 1, Name="Test Course" };

            // Act
            sut.Add(course);
            var result = sut.GetById(course.Id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(course, result);
        }
    }
}