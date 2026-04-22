using Soenneker.Tests.HostedUnit;

namespace Soenneker.Mailgun.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class MailgunOpenApiClientTests : HostedUnitTest
{
    public MailgunOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
