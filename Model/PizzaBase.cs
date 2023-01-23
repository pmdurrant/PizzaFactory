// ***********************************************************************
// Assembly         : PizzaFactory
// Author           : pdurr
// Created          : 01-22-2023
//
// Last Modified By : pdurr
// Last Modified On : 01-22-2023
// ***********************************************************************
// <copyright file="PizzaBase.cs" company="PizzaFactory">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace Model
{
    /// <summary>
    /// Enum PizzaBase
    /// </summary>
    public enum PizzaBase : ushort
    {
        /// <summary>
        /// The deep pan
        /// </summary>
        DeepPan,
        /// <summary>
        /// The stuffed crust
        /// </summary>
        StuffedCrust = 1,
        /// <summary>
        /// The thinand crispy
        /// </summary>
        ThinandCrispy = 2
    }
}