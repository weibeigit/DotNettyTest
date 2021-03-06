﻿using System;

namespace DotNetRpcDependency
{
    /// <summary>
    /// Copyright (C) 2017 yjq 版权所有。
    /// 类名：IObjectContainer.cs
    /// 类属性：公共类（非静态）
    /// 类功能描述：IObjectContainer接口
    /// 创建标识：yjq 2017/7/14 23:34:19
    /// </summary>
    public interface IObjectContainer : IIocRegister, IIocResolve
    {
        /// <summary>
        /// 判断是否已注册该服务
        /// </summary>
        /// <param name="serviceType">服务类型</param>
        /// <returns>true表示已注册</returns>
        bool IsRegistered(Type serviceType);

        /// <summary>
        /// 判断是否已注册该服务
        /// </summary>
        /// <typeparam name="TService">服务类型</typeparam>
        /// <returns>true表示已注册</returns>
        bool IsRegistered<TService>();

        /// <summary>
        /// 判断是否已注册该服务
        /// </summary>
        /// <param name="serviceName">注册的服务名字</param>
        /// <param name="serviceType">服务类型</param>
        /// <returns>true表示已注册</returns>
        bool IsRegisteredWithName(string serviceName, Type serviceType);

        /// <summary>
        /// 判断是否已注册该服务
        /// </summary>
        /// <typeparam name="TService">服务类型</typeparam>
        /// <param name="serviceName">注册的服务名字</param>
        /// <returns>true表示已注册</returns>
        bool IsRegisteredWithName<TService>(string serviceName);

        /// <summary>
        /// 开始一个作用域请求，与其它请求相互独立
        /// </summary>
        /// <returns>IIocScopeResolve</returns>
        IIocScopeResolve BeginLeftScope();
    }
}