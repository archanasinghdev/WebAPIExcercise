using Application.DTOs;
using Application.Features.ProductFeatures.Commands;
using Application.Interfaces;
using Moq;
using Shouldly;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebAPIExcercise.User.UnitTest.Mocks;
using Xunit;

namespace WebAPIExcercise.User.UnitTest.Users.Commands
{
    public class CreateUserCommandHandlerTest
    {
        private readonly Mock<IUserRepository> _mockRepo;
        private readonly CreateUserDto _createUserDto;
        public CreateUserCommandHandlerTest()
        {
            _mockRepo = MockUserRepository.GetUserRepository();
            _createUserDto = new CreateUserDto()
            {
                Address = "Waterford",
                Email = "Ab@gmail.com",
                Age = 20,
                Name = "XT"
            };

        }


        [Fact]
        public async Task GetAllUserListTest()
        {
            var handler = new CreateUserCommandHandler(_mockRepo.Object);
            var result = await handler.Handle(new CreateUserCommand() { }, CancellationToken.None);
            var user = await _mockRepo.Object.GetAsync();
            result.ShouldBeOfType<int>();
            user.Count().ShouldBe(3);
        }
    }
}



