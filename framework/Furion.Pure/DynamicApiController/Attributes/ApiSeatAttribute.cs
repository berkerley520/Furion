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

namespace Microsoft.AspNetCore.Mvc;

/// <summary>
/// 接口参数位置设置
/// </summary>
[SuppressSniffer, AttributeUsage(AttributeTargets.Parameter)]
public class ApiSeatAttribute : Attribute
{
    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="seat"></param>
    public ApiSeatAttribute(ApiSeats seat = ApiSeats.ActionEnd)
    {
        Seat = seat;
    }

    /// <summary>
    /// 参数位置
    /// </summary>
    public ApiSeats Seat { get; set; }
}