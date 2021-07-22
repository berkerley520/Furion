﻿// Copyright (c) 2020-2021 百小僧, Baiqian Co.,Ltd.
// Furion is licensed under Mulan PSL v2.
// You can use this software according to the terms and conditions of the Mulan PSL v2.
// You may obtain a copy of Mulan PSL v2 at:
//             http://license.coscl.org.cn/MulanPSL2
// THIS SOFTWARE IS PROVIDED ON AN "AS IS" BASIS, WITHOUT WARRANTIES OF ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO NON-INFRINGEMENT, MERCHANTABILITY OR FIT FOR A PARTICULAR PURPOSE.
// See the Mulan PSL v2 for more details.

using Microsoft.Extensions.Logging;

namespace Furion.Logging
{
    /// <summary>
    /// 构建字符串日志部分类
    /// </summary>
    public sealed partial class StringLoggerPart
    {
        /// <summary>
        /// Information
        /// </summary>
        public void LogInformation()
        {
            SetLevel(LogLevel.Information).Log();
        }

        /// <summary>
        /// Warning
        /// </summary>
        public void LogWarning()
        {
            SetLevel(LogLevel.Warning).Log();
        }

        /// <summary>
        /// Error
        /// </summary>
        public void LogError()
        {
            SetLevel(LogLevel.Error).Log();
        }

        /// <summary>
        /// Debug
        /// </summary>
        public void LogDebug()
        {
            SetLevel(LogLevel.Debug).Log();
        }

        /// <summary>
        /// Trace
        /// </summary>
        public void LogTrace()
        {
            SetLevel(LogLevel.Trace).Log();
        }

        /// <summary>
        /// Critical
        /// </summary>
        public void LogCritical()
        {
            SetLevel(LogLevel.Critical).Log();
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <returns></returns>
        public void Log()
        {
            var logger = !string.IsNullOrWhiteSpace(CategoryName)
                ? App.GetService<ILoggerFactory>(LoggerScoped)?.CreateLogger(CategoryName)
                : App.GetService(typeof(ILogger<>).MakeGenericType(CategoryType), LoggerScoped) as ILogger;

            // 如果没有异常且事件Id为空
            if (Exception == null && EventId == null)
            {
                logger.Log(Level, Message, Args);
            }
            // 如果存在异常且事件Id为空
            else if (Exception != null && EventId == null)
            {
                logger.Log(Level, Exception, Message, Args);
            }
            // 如果异常为空且事件Id不为空
            else if (Exception == null && EventId != null)
            {
                logger.Log(Level, EventId.Value, Message, Args);
            }
            // 如果存在异常且事件Id不为空
            else if (Exception != null && EventId != null)
            {
                logger.Log(Level, EventId.Value, Exception, Message, Args);
            }
            else { }
        }
    }
}