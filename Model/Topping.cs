// ***********************************************************************
// Assembly         : PizzaFactory
// Author           : pdurr
// Created          : 01-22-2023
//
// Last Modified By : pdurr
// Last Modified On : 01-22-2023
// ***********************************************************************
// <copyright file="Topping.cs" company="PizzaFactory">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Enum Topping
    /// </summary>
    public enum Topping:short
    {

        /// <summary>
        /// The hamand mushroom
        /// </summary>
        HamandMushroom = 0,
        /// <summary>
        /// The pepperoni
        /// </summary>
        Pepperoni = 1,
        /// <summary>
        /// The vegetable
        /// </summary>
        Vegetable = 2
    }
}
