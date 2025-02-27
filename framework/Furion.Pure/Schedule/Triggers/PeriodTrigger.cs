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

namespace Furion.Schedule;

/// <summary>
/// 毫秒周期（间隔）作业触发器
/// </summary>
[SuppressSniffer]
public class PeriodTrigger : Trigger
{
    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="interval">间隔（毫秒）</param>
    public PeriodTrigger(int interval)
    {
        // 最低运行毫秒数为 100ms
        if (interval < 100) throw new InvalidOperationException($"The interval cannot be less than 100ms, but the value is <{interval}ms>.");

        Interval = interval;
    }

    /// <summary>
    /// 间隔（毫秒）
    /// </summary>
    protected int Interval { get; }

    /// <summary>
    /// 计算下一个触发时间
    /// </summary>
    /// <param name="startAt">起始时间</param>
    /// <returns><see cref="DateTime"/></returns>
    public override DateTime GetNextOccurrence(DateTime startAt)
    {
        return startAt.AddMilliseconds(Interval);
    }

    /// <summary>
    /// 作业触发器转字符串输出
    /// </summary>
    /// <returns><see cref="string"/></returns>
    public override string ToString()
    {
        return $"<{JobId} {TriggerId}> {GetUnit()}{(string.IsNullOrWhiteSpace(Description) ? string.Empty : $" {Description.GetMaxLengthString()}")} {NumberOfRuns}ts";
    }

    /// <summary>
    /// 计算间隔单位
    /// </summary>
    /// <returns></returns>
    private string GetUnit()
    {
        // 毫秒
        if (Interval < 1000) return $"{Interval}ms";
        // 秒
        if (Interval >= 1000 && Interval < 1000 * 60 && Interval % 1000 == 0) return $"{Interval / 1000}s";
        // 分钟
        if (Interval >= 1000 * 60 && Interval < 1000 * 60 * 60 && Interval % (1000 * 60) == 0) return $"{Interval / (1000 * 60)}min";
        // 小时
        if (Interval >= 1000 * 60 * 60 && Interval < 1000 * 60 * 60 * 24 && Interval % (1000 * 60 * 60) == 0) return $"{Interval / (1000 * 60 * 60)}h";

        return $"{Interval}ms";
    }
}