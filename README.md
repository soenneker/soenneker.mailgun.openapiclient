[![](https://img.shields.io/nuget/v/soenneker.mailgun.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.mailgun.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.mailgun.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.mailgun.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.mailgun.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.mailgun.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.mailgun.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.mailgun.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Mailgun.OpenApiClient

Generated request builders and models for calling the Mailgun API from .NET.

## Installation

```bash
dotnet add package Soenneker.Mailgun.OpenApiClient
```

## Usage

Mailgun authenticates API requests with HTTP Basic authentication. Use `api` as the username and your Mailgun API key as the password:

```csharp
using System.Net.Http.Headers;
using System.Text;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Mailgun.OpenApiClient;

string credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"api:{apiKey}"));

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Basic", credentials);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new MailgunOpenApiClient(adapter);

var routes = await client.V3.Routes.GetAsync(cancellationToken: cancellationToken);
```

The generated client defaults to `https://api.mailgun.net`. Set `adapter.BaseUrl` before constructing `MailgunOpenApiClient` when you need a different Mailgun endpoint.

For service-container registration and managed client reuse, use [`Soenneker.Mailgun.OpenApiClientUtil`](https://github.com/soenneker/soenneker.mailgun.openapiclientutil).
