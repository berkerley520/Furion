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

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;
using System.Linq.Expressions;

namespace Furion.Localization;

/// <summary>
/// 全局多语言静态类
/// </summary>
[SuppressSniffer]
public static class L
{
    /// <summary>
    /// String 多语言
    /// </summary>
    public static IStringLocalizer Text => App.GetService<IStringLocalizerFactory>(App.RootServices)?.Create();

    /// <summary>
    /// Html 多语言
    /// </summary>
    public static IHtmlLocalizer Html => App.GetService<IHtmlLocalizerFactory>(App.RootServices)?.Create();

    /// <summary>
    /// String 多语言
    /// </summary>
    /// <typeparam name="T">特定类型</typeparam>
    /// <remarks><see cref="IStringLocalizer{T}"/></remarks>
    public static IStringLocalizer<T> TextOf<T>()
    {
        return App.GetService<IStringLocalizer<T>>(App.RootServices);
    }

    /// <summary>
    /// Html 多语言
    /// </summary>
    /// <typeparam name="T">特定类型</typeparam>
    /// <remarks><see cref="IHtmlLocalizer{T}"/></remarks>
    public static IHtmlLocalizer<T> HtmlOf<T>()
    {
        return App.GetService<IHtmlLocalizer<T>>(App.RootServices);
    }

    /// <summary>
    /// 设置当前选择的语言
    /// </summary>
    /// <param name="culture"></param>
    /// <param name="immediately">是否立即对当前线程有效，设置 true 表示立即有效，默认情况下只会影响下一次请求</param>
    public static void SetCulture(string culture, bool immediately = false)
    {
        // 是否立即修改当前线程 UI 区域性
        if (immediately) SetCurrentUICulture(culture);

        var httpContext = App.HttpContext;
        if (httpContext == null) return;

        // 如果 Response 已经完成输出，则禁止写入
        if (httpContext.Response.HasStarted) return;

        httpContext.Response.Cookies.Append(
            CookieRequestCultureProvider.DefaultCookieName,
            CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
            new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
        );
    }

    /// <summary>
    /// 获取当前选择的语言
    /// </summary>
    /// <returns></returns>
    public static RequestCulture GetSelectCulture()
    {
        var httpContext = App.HttpContext;
        if (httpContext == null) return default;

        // 获取请求特性
        var requestCulture = httpContext.Features.Get<IRequestCultureFeature>();
        return requestCulture.RequestCulture;
    }

    /// <summary>
    /// 设置当前线程 UI 区域性
    /// </summary>
    /// <param name="culture"></param>
    /// <remarks>对当前线程（代码）立即有效</remarks>
    /// <returns></returns>
    public static void SetCurrentUICulture(string culture)
    {
        // https://learn.microsoft.com/zh-cn/dotnet/api/system.globalization.cultureinfo.currentuiculture?view=net-6.0
        // 修改线程当前的 UI 区域性
        CultureInfo.CurrentUICulture = new CultureInfo(culture);
    }

    /// <summary>
    /// 获取当前线程 UI 区域性
    /// </summary>
    /// <returns></returns>
    public static CultureInfo GetCurrentUICulture()
    {
        // https://learn.microsoft.com/zh-cn/dotnet/api/system.globalization.cultureinfo.currentuiculture?view=net-6.0
        return CultureInfo.CurrentUICulture;
    }

    /// <summary>
    /// 获取系统提供的语言列表
    /// </summary>
    /// <returns></returns>
    public static Dictionary<string, string> GetCultures()
    {
        var httpContext = App.HttpContext;
        if (httpContext == null) return new Dictionary<string, string>();

        // 获取请求本地特性选项
        var locOptions = httpContext.RequestServices.GetService<IOptions<RequestLocalizationOptions>>().Value;

        // 获取语言符号和名称
        var cultureItems = locOptions.SupportedUICultures
            .ToDictionary(u => u.Name, u => u.DisplayName);

        return cultureItems;
    }

    /// <summary>
    /// 根据实体类属性名获取对应的多语言配置
    /// </summary>
    /// <typeparam name="TResource">通常命名为 SharedResource </typeparam>
    /// <param name="propertyExpression">属性表达式</param>
    /// <returns></returns>
    public static LocalizedString GetString<TResource>(Expression<Func<TResource, string>> propertyExpression)
    {
        return Text.GetString(propertyExpression);
    }
}