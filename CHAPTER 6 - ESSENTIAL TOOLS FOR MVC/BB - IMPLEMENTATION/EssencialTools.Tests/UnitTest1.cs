﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EssencialTools.Models;

namespace EssentialTools.Test
{
	[TestClass]
	public class UnitTest1
	{
		/*
		CC UNIT TESTING WITH VISUAL STUDIO -> 137
		CCBB CREATING THE UNIT TESTS -> 139
		>> Listing 6-27. Adding the Test methods to the UnitTest1.cs file -> 139    
		 */

		private IDiscountHelper getTestObject()
		{
			return new MinimumDiscountHelper();
		}

		[TestMethod]
		public void Discount_Above_100()
		{
			// arrange
			IDiscountHelper target = getTestObject();
			decimal total = 200;

			// act
			var discountedTotal = target.ApplyDiscount(total);

			// assert
			Assert.AreEqual(total * 0.9M, discountedTotal);
		}
	}
}