﻿using Blazor.Infra.CrossCutting.SharedUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.UI.Client.Services.Contracts
{
    public interface IAuthorizeApi
    {
        Task Login(LoginParametersViewModel loginParameters);
        Task Register(RegisterParametersViewModel registerParameters);
        Task Logout();
        Task<UserInfoViewModel> GetUserInfo();
    }
}
