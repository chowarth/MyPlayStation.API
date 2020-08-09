# MyPlayStation.API

A lightweight .NET wrapper for the [MyPlayStation](https://my.playstation.com/) API using [Refit](https://github.com/reactiveui/refit).

# Getting started

As this library makes use of Refit it's a good idea to be familiar with how Refit works, you can find documentation in the repo link above.

## Creating a REST service using Refit

The first thing you need to do is to create the Refit REST service for the desired API interface. All API interfaces live under the the `MyPlayStation.API.Interfaces` namespace, and each endpoint has matching "request" and "response" types e.g. `GetAuthTokenRequest` and `GetAuthTokenResponse`.

```csharp
RefitSettings refitSettings = new RefitSettings()
{
    AuthorizationHeaderValueGetter = /* Method that returns auth token, how this works I leave up to you! */
};

IAuthenticationApi authApi = RestService.For<IAuthenticationApi>( EndpointUrls.Auth, refitSettings );
```

Note `AuthorizationHeaderValueGetter`, you MUST provide a callback method for Refit to use when an `Authorization` header is required for a request - this is every request except `AuthenticateWithNpssoAsync`. The callback should be of type `Func<Task<string>>` and it should return a valid auth token.

## Registering a REST service with a dependency container

It's very common practise these days to be using an IoC container for dependency injection, if you wish to use one it must allow you to register an instance of an object with the container. For example, if you were using using [DryIoc](https://github.com/dadhi/DryIoc), you can do:

```csharp
container.RegisterInstance( RestService.For<IAuthenticationApi>( EndpointUrls.Auth, refitSettings ) );
```

## Authentication

As the project is only intended to be a lightweight wrapper for the [MyPlayStation](https://my.playstation.com/) API it does not provide you with a method for getting an `Npsso` cookie that is required to obtain a valid OAuth token. This is something that was decided to left completely up to the consumer! psst ... that's you!

How you obtain an `Npsso` cookie is up to you, but one way of doing it would be to follow the documentation that the [psn-php](https://tusticles.com/psn-php/first_login.html) library recommends for its users. Once you have an `Npsso` you can then use that to authenticate properly:

```csharp
GetAuthTokenResponse response = await authApi.AuthenticateWithNpssoAsync( $"npsso={npsso}", new GetAuthTokenRequest()
{
    ClientId = ClientConstants.Id,
    ClientSecret = ClientConstants.Secret,
    Scope = ClientConstants.Scope,
    GrantType = GrantType.SSOCookie
} );

var token = response.Token;
var refreshToken = response.RefreshToken;

// Securely store any tokens for future use
```

The `token` recieved from `AuthenticateWithNpssoAsync` should be the value that is returned for the `RefitSettings.AuthorizationHeaderValueGetter` method or function. The `refreshToken` should be used to obtain a new auth token as required e.g. when the auth token is close to becoming expired.
