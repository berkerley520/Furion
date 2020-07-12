﻿using Fur.DatabaseVisitor.Tangent.Attributes.Basics;
using System;

namespace Fur.DatabaseVisitor.Tangent.Attributes
{
    /// <summary>
    /// 切面数据库函数特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class DbFunctionAttribute : TangentCompileTypeAttribute
    {
        #region 构造函数 + public DbFunctionAttribute(string name) : base(name)
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">函数名称</param>
        public DbFunctionAttribute(string name) : base(name)
        {
        }
        #endregion
    }
}