﻿// MIT License
//
// Copyright (c) 2020-present 百小僧, Baiqian Co.,Ltd and Contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Furion;

/// <summary>
/// UseInject 配置选项
/// </summary>
public sealed class UseInjectOptions
{
    /// <summary>
    /// 配置 Swagger
    /// </summary>
    /// <param name="configure"></param>
    public void ConfigureSwagger(Action<SwaggerOptions> configure)
    {
        SwaggerConfigure = configure;
    }

    /// <summary>
    /// 配置 Swagger UI
    /// </summary>
    /// <param name="configure"></param>
    public void ConfigureSwaggerUI(Action<SwaggerUIOptions> configure)
    {
        SwaggerUIConfigure = configure;
    }

    /// <summary>
    /// Swagger 配置
    /// </summary>
    internal static Action<SwaggerOptions> SwaggerConfigure { get; private set; }

    /// <summary>
    /// Swagger UI 配置
    /// </summary>
    internal static Action<SwaggerUIOptions> SwaggerUIConfigure { get; private set; }
}