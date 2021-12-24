using Application.Interfaces;
using Domain;
using Moq;
using System.Collections.Generic;

namespace WebAPIExcercise.User.UnitTest.Mocks
{
    public static class MockUserRepository
    {
        public static Mock<IUserRepository> GetUserRepository()
        {
            var users = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    Id=1,
                    Name="Ajit",
                    Email="ajit@gmail.com",
                    Age=30,
                    Address="Xyz"
                },
                new ApplicationUser
                {
                    Id=2,
                    Name="Peter",
                    Email="peter@gmail.com",
                    Age=34,
                    Address="Abc"
                }
            };

            var newuser = new ApplicationUser()
            {
                Name = "Abc",
                Email = "Abc@gmail.com",
                Age = 36,
                Address = "Xyz"
            };
            var mockRepo = new Mock<IUserRepository>();
            mockRepo.Setup(r => r.GetAsync(default)).ReturnsAsync(users);
            mockRepo.Setup(r => r.AddAsync(It.IsAny<ApplicationUser>(), default)).ReturnsAsync((3));
            users.Add(newuser);
            return mockRepo;
        }
    }
}
