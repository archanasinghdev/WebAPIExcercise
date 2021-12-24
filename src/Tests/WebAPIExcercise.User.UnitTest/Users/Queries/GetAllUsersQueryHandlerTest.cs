using Application.DTOs;
using Application.Features.ProductFeatures.Queries;
using Application.Interfaces;
using Moq;
using Shouldly;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebAPIExcercise.User.UnitTest.Mocks;
using Xunit;


namespace WebAPIExcercise.User.UnitTest.Users.Queries
{
    public class GetAllUsersQueryHandlerTest
    {
        // private readonly IMapper _mapper;
        private readonly Mock<IUserRepository> _mockRepo;
        public GetAllUsersQueryHandlerTest()
        {
            _mockRepo = MockUserRepository.GetUserRepository();
        }


        [Fact]
        public async Task GetAllUserListTest()
        {
            var handler = new GetAllUsersQueryHandler(_mockRepo.Object);
            var result = await handler.Handle(new GetAllUsersQuery(), CancellationToken.None);
            result.ShouldBeOfType<List<UserDto>>();
            result.ToList().Count.ShouldBe(3);
        }
    }
}
