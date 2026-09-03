using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;

namespace SkillVault.Tests.Integration;

public class UsersControllerTest : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public UsersControllerTest(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task Get_Hello_Returns_Ok_With_Hello_Text()
    {
        // arange
        var client = _factory.CreateClient();

        // act
        var response = await client.GetAsync("/hello");
        var body = await response.Content.ReadAsStringAsync();

        // assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        Assert.Equal("Hello", body);
    }
}


