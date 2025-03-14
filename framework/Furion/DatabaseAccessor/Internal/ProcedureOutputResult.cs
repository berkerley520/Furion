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

using System.Data;

namespace Furion.DatabaseAccessor;

/// <summary>
/// 存储过程输出返回值
/// </summary>
[SuppressSniffer]
public sealed class ProcedureOutputResult : ProcedureOutputResult<DataSet>
{
    /// <summary>
    /// 构造函数
    /// </summary>
    public ProcedureOutputResult() : base()
    {
    }
}

/// <summary>
/// 存储过程输出返回值
/// </summary>
/// <typeparam name="TResult">泛型版本</typeparam>
[SuppressSniffer]
public class ProcedureOutputResult<TResult>
{
    /// <summary>
    /// 构造函数
    /// </summary>
    public ProcedureOutputResult()
    {
        OutputValues = new List<ProcedureOutputValue>();
    }

    /// <summary>
    /// 输出值
    /// </summary>
    public IEnumerable<ProcedureOutputValue> OutputValues { get; set; }

    /// <summary>
    /// 返回值
    /// </summary>
    public object ReturnValue { get; set; }

    /// <summary>
    /// 结果集
    /// </summary>
    public TResult Result { get; set; }
}