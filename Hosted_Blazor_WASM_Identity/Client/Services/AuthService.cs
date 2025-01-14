﻿using Blazored.LocalStorage;
using Hosted_Blazor_WASM_Identity.Client.Helpers;
using Hosted_Blazor_WASM_Identity.Shared.Models;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Hosted_Blazor_WASM_Identity.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }

        public async Task<RegisterResult> Register(RegisterModel registerModel)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/accounts", registerModel);
            RegisterResult result = await response.Content.ReadFromJsonAsync<RegisterResult>();
            return result;
        }

        public async Task<LoginResult> Login(LoginModel loginModel)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/login", loginModel);
            LoginResult result = await response.Content.ReadFromJsonAsync<LoginResult>();

            if (result.Successful)
            {
                await _localStorage.SetItemAsync("authToken", result.Token);
                ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(result.Token);
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", result.Token);
                return result;
            }
            return result;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
    }
}
