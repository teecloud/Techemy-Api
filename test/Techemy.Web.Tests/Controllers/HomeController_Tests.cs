using System.Threading.Tasks;
using Techemy.Models.TokenAuth;
using Techemy.Web.Controllers;
using Shouldly;
using Xunit;

namespace Techemy.Web.Tests.Controllers
{
    public class HomeController_Tests: TechemyWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}