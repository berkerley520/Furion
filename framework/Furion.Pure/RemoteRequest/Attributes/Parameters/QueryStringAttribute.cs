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

namespace Furion.RemoteRequest;

/// <summary>
/// 配置查询参数
/// </summary>
[SuppressSniffer, AttributeUsage(AttributeTargets.Parameter)]
public class QueryStringAttribute : ParameterBaseAttribute
{
    /// <summary>
    /// 构造函数
    /// </summary>
    public QueryStringAttribute()
    {
    }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="alias"></param>
    public QueryStringAttribute(string alias)
    {
        Alias = alias;
    }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="alias"></param>
    /// <param name="format"></param>
    public QueryStringAttribute(string alias, string format)
        : this(alias)
    {
        Format = format;
    }

    /// <summary>
    /// 参数别名
    /// </summary>
    public string Alias { get; set; }

    /// <summary>
    /// 时间类型参数格式化
    /// </summary>
    public string Format { get; set; }
}