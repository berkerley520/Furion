﻿// -----------------------------------------------------------------------------
// 让 .NET 开发更简单，更通用，更流行。
// Copyright © 2020-2021 Furion, 百小僧, Baiqian Co.,Ltd.
//
// 框架名称：Furion
// 框架作者：百小僧
// 框架版本：2.10.3
// 源码地址：Gitee： https://gitee.com/dotnetchina/Furion
//          Github：https://github.com/monksoul/Furion
// 开源协议：Apache-2.0（https://gitee.com/dotnetchina/Furion/blob/master/LICENSE）
// -----------------------------------------------------------------------------

using System.ComponentModel;

namespace Furion.VirtualFileServer
{
    /// <summary>
    /// 文件提供器类型
    /// </summary>
    [Description("文件提供器类型")]
    public enum FileProviderTypes
    {
        /// <summary>
        /// 物理文件
        /// </summary>
        [Description("物理文件")]
        Physical,

        /// <summary>
        /// 嵌入资源文件
        /// </summary>
        [Description("嵌入资源文件")]
        Embedded
    }
}