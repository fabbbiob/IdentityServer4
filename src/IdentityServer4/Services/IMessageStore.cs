﻿// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using IdentityServer4.Core.Models;
using System.Threading.Tasks;

namespace IdentityServer4.Core.Services
{
    public interface IMessageStore<TModel>
    {
        Task WriteAsync(Message<TModel> message);
        Task<Message<TModel>> ReadAsync(string id);
        Task DeleteAsync(string id);
    }
}