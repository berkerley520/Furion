// MIT License
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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace Furion.Tools.CommandLine;

/// <summary>
/// Cli 初始化
/// </summary>
public static partial class Cli
{
    /// <summary>
    /// 输入参数信息
    /// </summary>
    internal static Arguments Arguments { get; set; }

    /// <summary>
    /// 参数处理程序
    /// </summary>
    internal static Dictionary<string, Action<ArgumentMetadata>> ArgumentHandlers { get; set; }

    /// <summary>
    /// 静态构造函数
    /// </summary>
    static Cli()
    {
        // 填充参数信息
        Fill();
    }

    /// <summary>
    /// 填充参数信息
    /// </summary>
    private static void Fill()
    {
        // 如果已经填充过，不再重新解析
        if (ArgumentMetadatas != null) return;

        // 获取入口类型
        var entryType = GetEntryType();

        // 填充当前属性值
        Arguments.Populate(entryType);

        // 获取传递参数字典
        Arguments = Arguments.Parse(u =>
        {
            u.TargetType = entryType;
        });
        var argumentDictionary = Arguments.ArgumentDictionary;

        // 解析定义参数集合
        ArgumentMetadatas = Arguments.GetArgumentInfo(entryType)
                                                             .Select(u => new ArgumentMetadata
                                                             {
                                                                 HelpText = u.HelpText,
                                                                 IsCollection = u.IsCollection,
                                                                 LongName = u.LongName,
                                                                 ShortName = u.ShortName,
                                                                 Property = u.Property,
                                                                 IsTransmission = argumentDictionary.ContainsKey(u.ShortName.ToString()) || argumentDictionary.ContainsKey(u.LongName),
                                                                 Value = argumentDictionary.ContainsKey(u.ShortName.ToString())
                                                                    ? argumentDictionary[u.ShortName.ToString()]
                                                                    : (argumentDictionary.ContainsKey(u.LongName)
                                                                            ? argumentDictionary[u.LongName]
                                                                            : default),
                                                                 IsShortName = argumentDictionary.ContainsKey(u.ShortName.ToString()),
                                                                 IsLongName = argumentDictionary.ContainsKey(u.LongName)
                                                             });

        // 数据校验
        if (!ValidateParameters()) Exit();

        // 扫描所有参数处理程序
        ArgumentHandlers = ScanArgumentHandlers();
    }

    /// <summary>
    /// 数据校验
    /// </summary>
    private static bool ValidateParameters()
    {
        var isVaild = true;

        // 进行数据校验
        foreach (var argumentMetadata in ArgumentMetadatas)
        {
            if (!argumentMetadata.Property.IsDefined(typeof(ValidationAttribute))) continue;

            // 获取所有验证特性
            var validationAttributes = argumentMetadata.Property.GetCustomAttributes<ValidationAttribute>();

            // 验证必填
            if (argumentMetadata.Value == null && !argumentMetadata.Property.IsDefined(typeof(RequiredAttribute))) continue;

            // 校验单个值
            ICollection<ValidationResult> results = new List<ValidationResult>();
            var isValid = Validator.TryValidateValue(argumentMetadata.Value, new ValidationContext(argumentMetadata.Value), results, validationAttributes);
            if (isValid) continue;

            Error("Validate Failed: " + (argumentMetadata.IsShortName ? argumentMetadata.ShortName : argumentMetadata.LongName));
            Error(" " + string.Join(',', results.Select(x => x.ErrorMessage)));

            if (isVaild) isVaild = false;
        }

        return isVaild;
    }

    /// <summary>
    /// 扫描所有静态定义处理方法
    /// </summary>
    private static Dictionary<string, Action<ArgumentMetadata>> ScanArgumentHandlers()
    {
        var arugmentHandlers = new Dictionary<string, Action<ArgumentMetadata>>();

        // 查找所有 static 静态方法且带 Handler 结尾的方法且没有返回值
        var methodHandlers = GetEntryType().DeclaredMethods
                                                          .Where(u => u.IsStatic
                                                                   && u.Name.EndsWith("Handler")
                                                                   && u.ReturnType == typeof(void)
                                                                   && u.GetParameters().Length == 1
                                                                   && u.GetParameters()[0].ParameterType == typeof(ArgumentMetadata));
        foreach (var method in methodHandlers)
        {
            var propertyName = method.Name[0..^7];
            arugmentHandlers.Add(propertyName, (Action<ArgumentMetadata>)Delegate.CreateDelegate(typeof(Action<ArgumentMetadata>), method));
        }

        return arugmentHandlers;
    }

    /// <summary>
    /// 获取入口类型
    /// </summary>
    /// <returns></returns>
    private static TypeInfo GetEntryType()
    {
        return Assembly.GetEntryAssembly().DefinedTypes.First(u => u.Name == "Program");
    }
}
