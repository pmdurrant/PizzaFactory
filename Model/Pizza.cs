// ***********************************************************************
// Assembly         : PizzaFactory
// Author           : pdurr
// Created          : 01-22-2023
//
// Last Modified By : pdurr
// Last Modified On : 01-23-2023
// ***********************************************************************
// <copyright file="Pizza.cs" company="PizzaFactory">
//     Copyright (c) . All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Class Pizza.
    /// </summary>
    public class Pizza
    {
        /// <summary>
        /// Gets or sets the type of the base.
        /// </summary>
        /// <value>The type of the base.</value>
        public PizzaBase BaseType { get; set; }
        /// <summary>
        /// Gets or sets the topping.
        /// </summary>
        /// <value>The topping.</value>
        public Topping topping { get; set; }

        /// <summary>
        /// The topping cooking time
        /// </summary>
        private int toppingCookingTime;
        /// <summary>
        /// The base cooking time
        /// </summary>
        private int baseCookingTime;
        /// <summary>
        /// The cooking time
        /// </summary>
        private int cookingTime;
        /// <summary>
        /// Gets the cooking time.
        /// </summary>
        /// <returns>System.Int32.</returns>
        public int GetCookingTime()
        {
            return cookingTime;
        }

        /// <summary>
        /// Sets the cooking time.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetCookingTime(int value)
        {
            cookingTime = (topping.ToString().Length * toppingCookingTime) + baseCookingTime;
           
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pizza"/> class.
        /// </summary>
        /// <param name="cookingTime">The cooking time.</param>
        /// <param name="toppingcookingTime">The toppingcooking time.</param>
        public Pizza ( int cookingTime,int toppingcookingTime)
        {
          
            this.toppingCookingTime = toppingcookingTime;
            this.baseCookingTime = cookingTime;
        }
    }
}
