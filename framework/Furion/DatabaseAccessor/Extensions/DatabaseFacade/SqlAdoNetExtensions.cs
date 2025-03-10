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

using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data;
using System.Data.Common;

namespace Furion.DatabaseAccessor;

/// <summary>
/// ADONET 拓展类
/// </summary>
[SuppressSniffer]
public static class SqlAdoNetExtensions
{
    /// <summary>
    /// 执行 Sql 返回 DataTable
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="commandType">命令类型</param>
    /// <param name="parameters">命令参数</param>
    /// <param name="behavior">行为</param>
    /// <returns>DataTable</returns>
    public static DataTable ExecuteReader(this DatabaseFacade databaseFacade, string sql, DbParameter[] parameters = null, CommandType commandType = CommandType.Text, CommandBehavior behavior = CommandBehavior.Default)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand) = databaseFacade.PrepareDbCommand(sql, parameters, commandType);

        // 读取数据
        using var dbDataReader = dbCommand.ExecuteReader(behavior);

        // 填充到 DataTable
        var dataTable = dbDataReader.ToDataTable();

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        dbCommand.Dispose();

        return dataTable;
    }

    /// <summary>
    /// 执行 Sql 返回 DataTable
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="commandType">命令类型</param>
    /// <param name="model">命令模型</param>
    /// <param name="behavior">行为</param>
    /// <returns>(DataTable dataTable, DbParameter[] dbParameters)</returns>
    public static (DataTable dataTable, DbParameter[] dbParameters) ExecuteReader(this DatabaseFacade databaseFacade, string sql, object model, CommandType commandType = CommandType.Text, CommandBehavior behavior = CommandBehavior.Default)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand, dbParameters) = databaseFacade.PrepareDbCommand(sql, model, commandType);

        // 读取数据
        using var dbDataReader = dbCommand.ExecuteReader(behavior);

        // 填充到 DataTable
        var dataTable = dbDataReader.ToDataTable();

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        dbCommand.Dispose();

        return (dataTable, dbParameters);
    }

    /// <summary>
    /// 执行 Sql 返回 DataTable
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="parameters">命令参数</param>
    /// <param name="commandType">命令类型</param>
    /// <param name="behavior">行为</param>
    /// <param name="cancellationToken">异步取消令牌</param>
    /// <returns>DataTable</returns>
    public static async Task<DataTable> ExecuteReaderAsync(this DatabaseFacade databaseFacade, string sql, DbParameter[] parameters = null, CommandType commandType = CommandType.Text, CommandBehavior behavior = CommandBehavior.Default, CancellationToken cancellationToken = default)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand) = await databaseFacade.PrepareDbCommandAsync(sql, parameters, commandType, cancellationToken);

        // 读取数据
        using var dbDataReader = await dbCommand.ExecuteReaderAsync(behavior, cancellationToken);

        // 填充到 DataTable
        var dataTable = dbDataReader.ToDataTable();

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        await dbCommand.DisposeAsync();

        return dataTable;
    }

    /// <summary>
    /// 执行 Sql 返回 DataTable
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="model">命令模型</param>
    /// <param name="commandType">命令类型</param>
    /// <param name="behavior">行为</param>
    /// <param name="cancellationToken">异步取消令牌</param>
    /// <returns>(DataTable dataTable, DbParameter[] dbParameters)</returns>
    public static async Task<(DataTable dataTable, DbParameter[] dbParameters)> ExecuteReaderAsync(this DatabaseFacade databaseFacade, string sql, object model, CommandType commandType = CommandType.Text, CommandBehavior behavior = CommandBehavior.Default, CancellationToken cancellationToken = default)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand, dbParameters) = await databaseFacade.PrepareDbCommandAsync(sql, model, commandType, cancellationToken);

        // 读取数据
        using var dbDataReader = await dbCommand.ExecuteReaderAsync(behavior, cancellationToken);

        // 填充到 DataTable
        var dataTable = dbDataReader.ToDataTable();

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        await dbCommand.DisposeAsync();

        return (dataTable, dbParameters);
    }

    /// <summary>
    /// 执行 Sql 语句返回受影响行数
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="parameters">命令参数</param>
    /// <param name="commandType">命令类型</param>
    /// <returns>受影响行数</returns>
    public static int ExecuteNonQuery(this DatabaseFacade databaseFacade, string sql, DbParameter[] parameters = null, CommandType commandType = CommandType.Text)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand) = databaseFacade.PrepareDbCommand(sql, parameters, commandType);

        // 执行返回受影响行数
        var rowEffects = dbCommand.ExecuteNonQuery();

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        dbCommand.Dispose();

        return rowEffects;
    }

    /// <summary>
    /// 执行 Sql 语句返回受影响行数
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="model">参数模型</param>
    /// <param name="commandType">命令类型</param>
    /// <returns>(int rowEffects, DbParameter[] dbParameters)</returns>
    public static (int rowEffects, DbParameter[] dbParameters) ExecuteNonQuery(this DatabaseFacade databaseFacade, string sql, object model, CommandType commandType = CommandType.Text)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand, dbParameters) = databaseFacade.PrepareDbCommand(sql, model, commandType);

        // 执行返回受影响行数
        var rowEffects = dbCommand.ExecuteNonQuery();

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        dbCommand.Dispose();

        return (rowEffects, dbParameters);
    }

    /// <summary>
    /// 执行 Sql 语句返回受影响行数
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="parameters">命令参数</param>
    /// <param name="commandType">命令类型</param>
    /// <param name="cancellationToken">异步取消令牌</param>
    /// <returns>受影响行数</returns>
    public static async Task<int> ExecuteNonQueryAsync(this DatabaseFacade databaseFacade, string sql, DbParameter[] parameters = null, CommandType commandType = CommandType.Text, CancellationToken cancellationToken = default)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand) = await databaseFacade.PrepareDbCommandAsync(sql, parameters, commandType, cancellationToken);

        // 执行返回受影响行数
        var rowEffects = await dbCommand.ExecuteNonQueryAsync(cancellationToken);

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        await dbCommand.DisposeAsync();

        return rowEffects;
    }

    /// <summary>
    /// 执行 Sql 语句返回受影响行数
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="model">命令模型</param>
    /// <param name="commandType">命令类型</param>
    /// <param name="cancellationToken">异步取消令牌</param>
    /// <returns>(int rowEffects, DbParameter[] dbParameters)</returns>
    public static async Task<(int rowEffects, DbParameter[] dbParameters)> ExecuteNonQueryAsync(this DatabaseFacade databaseFacade, string sql, object model, CommandType commandType = CommandType.Text, CancellationToken cancellationToken = default)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand, dbParameters) = await databaseFacade.PrepareDbCommandAsync(sql, model, commandType, cancellationToken);

        // 执行返回受影响行数
        var rowEffects = await dbCommand.ExecuteNonQueryAsync(cancellationToken);

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        await dbCommand.DisposeAsync();

        return (rowEffects, dbParameters);
    }

    /// <summary>
    /// 执行 Sql 返回单行单列的值
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="parameters">命令参数</param>
    /// <param name="commandType">命令类型</param>
    /// <returns>单行单列的值</returns>
    public static object ExecuteScalar(this DatabaseFacade databaseFacade, string sql, DbParameter[] parameters = null, CommandType commandType = CommandType.Text)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand) = databaseFacade.PrepareDbCommand(sql, parameters, commandType);

        // 执行返回单行单列的值
        var result = dbCommand.ExecuteScalar();

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        dbCommand.Dispose();

        return result != DBNull.Value ? result : default;
    }

    /// <summary>
    /// 执行 Sql 返回单行单列的值
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="model">命令模型</param>
    /// <param name="commandType">命令类型</param>
    /// <returns>(object result, DbParameter[] dbParameters)</returns>
    public static (object result, DbParameter[] dbParameters) ExecuteScalar(this DatabaseFacade databaseFacade, string sql, object model, CommandType commandType = CommandType.Text)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand, dbParameters) = databaseFacade.PrepareDbCommand(sql, model, commandType);

        // 执行返回单行单列的值
        var result = dbCommand.ExecuteScalar();

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        dbCommand.Dispose();

        return (result != DBNull.Value ? result : default, dbParameters);
    }

    /// <summary>
    /// 执行 Sql 返回单行单列的值
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="parameters">命令参数</param>
    /// <param name="commandType">命令类型</param>
    /// <param name="cancellationToken">异步取消令牌</param>
    /// <returns>单行单列的值</returns>
    public static async Task<object> ExecuteScalarAsync(this DatabaseFacade databaseFacade, string sql, DbParameter[] parameters = null, CommandType commandType = CommandType.Text, CancellationToken cancellationToken = default)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand) = await databaseFacade.PrepareDbCommandAsync(sql, parameters, commandType, cancellationToken);

        // 执行返回单行单列的值
        var result = await dbCommand.ExecuteScalarAsync(cancellationToken);

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        await dbCommand.DisposeAsync();

        return result != DBNull.Value ? result : default;
    }

    /// <summary>
    /// 执行 Sql 返回单行单列的值
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="model">命令模型</param>
    /// <param name="commandType">命令类型</param>
    /// <param name="cancellationToken">异步取消令牌</param>
    /// <returns>(object result, DbParameter[] dbParameters)</returns>
    public static async Task<(object result, DbParameter[] dbParameters)> ExecuteScalarAsync(this DatabaseFacade databaseFacade, string sql, object model, CommandType commandType = CommandType.Text, CancellationToken cancellationToken = default)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand, dbParameters) = await databaseFacade.PrepareDbCommandAsync(sql, model, commandType, cancellationToken);

        // 执行返回单行单列的值
        var result = await dbCommand.ExecuteScalarAsync(cancellationToken);

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        await dbCommand.DisposeAsync();

        return (result != DBNull.Value ? result : default, dbParameters);
    }

    /// <summary>
    /// 执行 Sql 返回 DataSet
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="commandType">命令类型</param>
    /// <param name="parameters">命令参数</param>
    /// <param name="behavior">行为</param>
    /// <returns>DataSet</returns>
    public static DataSet DataAdapterFill(this DatabaseFacade databaseFacade, string sql, DbParameter[] parameters = null, CommandType commandType = CommandType.Text, CommandBehavior behavior = CommandBehavior.Default)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand) = databaseFacade.PrepareDbCommand(sql, parameters, commandType);

        // 读取数据
        using var dbDataReader = dbCommand.ExecuteReader(behavior);

        // 填充到 DataSet
        var dataSet = dbDataReader.ToDataSet();

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        dbCommand.Dispose();

        return dataSet;
    }

    /// <summary>
    /// 执行 Sql 返回 DataSet
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="commandType">命令类型</param>
    /// <param name="model">命令模型</param>
    /// <param name="behavior">行为</param>
    /// <returns>(DataSet dataSet, DbParameter[] dbParameters)</returns>
    public static (DataSet dataSet, DbParameter[] dbParameters) DataAdapterFill(this DatabaseFacade databaseFacade, string sql, object model, CommandType commandType = CommandType.Text, CommandBehavior behavior = CommandBehavior.Default)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand, dbParameters) = databaseFacade.PrepareDbCommand(sql, model, commandType);

        // 读取数据
        using var dbDataReader = dbCommand.ExecuteReader(behavior);

        // 填充到 DataSet
        var dataSet = dbDataReader.ToDataSet();

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        dbCommand.Dispose();

        return (dataSet, dbParameters);
    }

    /// <summary>
    /// 执行 Sql 返回 DataSet
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="parameters">命令参数</param>
    /// <param name="commandType">命令类型</param>
    /// <param name="behavior">行为</param>
    /// <param name="cancellationToken">异步取消令牌</param>
    /// <returns>DataSet</returns>
    public static async Task<DataSet> DataAdapterFillAsync(this DatabaseFacade databaseFacade, string sql, DbParameter[] parameters = null, CommandType commandType = CommandType.Text, CommandBehavior behavior = CommandBehavior.Default, CancellationToken cancellationToken = default)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand) = await databaseFacade.PrepareDbCommandAsync(sql, parameters, commandType, cancellationToken);

        // 读取数据
        using var dbDataReader = await dbCommand.ExecuteReaderAsync(behavior, cancellationToken);

        // 填充到 DataSet
        var dataSet = dbDataReader.ToDataSet();

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        await dbCommand.DisposeAsync();

        return dataSet;
    }

    /// <summary>
    /// 执行 Sql 返回 DataSet
    /// </summary>
    /// <param name="databaseFacade">ADO.NET 数据库对象</param>
    /// <param name="sql">sql 语句</param>
    /// <param name="model">命令模型</param>
    /// <param name="commandType">命令类型</param>
    /// <param name="behavior">行为</param>
    /// <param name="cancellationToken">异步取消令牌</param>
    /// <returns>(DataSet dataSet, DbParameter[] dbParameters)</returns>
    public static async Task<(DataSet dataSet, DbParameter[] dbParameters)> DataAdapterFillAsync(this DatabaseFacade databaseFacade, string sql, object model, CommandType commandType = CommandType.Text, CommandBehavior behavior = CommandBehavior.Default, CancellationToken cancellationToken = default)
    {
        // 初始化数据库连接对象和数据库命令对象
        var (_, dbCommand, dbParameters) = await databaseFacade.PrepareDbCommandAsync(sql, model, commandType, cancellationToken);

        // 读取数据
        using var dbDataReader = await dbCommand.ExecuteReaderAsync(behavior, cancellationToken);

        // 填充到 DataSet
        var dataSet = dbDataReader.ToDataSet();

        // 释放命令对象
        dbCommand.Parameters?.Clear();
        await dbCommand.DisposeAsync();

        return (dataSet, dbParameters);
    }
}