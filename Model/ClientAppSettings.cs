// ***********************************************************************
// Assembly         : PizzaFactory
// Author           : pdurr
// Created          : 01-22-2023
//
// Last Modified By : pdurr
// Last Modified On : 01-22-2023
// ***********************************************************************
// <copyright file="ClientAppSettings.cs" company="PizzaFactory">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
/// <summary>
/// The Model namespace.
/// </summary>
namespace PizzaFactory.Model
{
    /// <summary>
    /// Class ClientAppSettings.
    /// </summary>
    public class ClientAppSettings
    {
        /// <summary>
        /// Gets or sets the no of pizza.
        /// </summary>
        /// <value>The no of pizza.</value>
        public int NoOfPizza { get; set; }

        /// <summary>
        /// Gets or sets the base cooking time.
        /// </summary>
        /// <value>The base cooking time.</value>
        public int BaseCookingTime { get; set; }
    }
}
