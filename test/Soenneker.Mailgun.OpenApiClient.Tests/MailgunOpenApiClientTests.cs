using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Mailgun.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class MailgunOpenApiClientTests : FixturedUnitTest
{
    public MailgunOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
