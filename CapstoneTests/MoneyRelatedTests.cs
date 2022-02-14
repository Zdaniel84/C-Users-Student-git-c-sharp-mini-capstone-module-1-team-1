using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.VendingClasses;
using Capstone;
using System.IO;
namespace Capstone
{
    [TestClass()]
    public class MoneyRelatedTests
    {

        [TestMethod]

        public void GiveChange_returnsCorrectChange()
        {
            //arrange
            MoneyRelated moneyRelated = new MoneyRelated();
            moneyRelated.GiveChange();
            moneyRelated.Balance = 2.00M;
            moneyRelated.PriceOfItem = 0.75M;
            //act
            decimal totalChange = moneyRelated.Balance - moneyRelated.PriceOfItem;

            //assert
            Assert.AreEqual(1.25M, totalChange);


        }
        [TestMethod]
        public void ProductSelection_subtractsFromBalance()
        {

            MoneyRelated moneyRelated = new MoneyRelated();
            moneyRelated.Balance = 2.00M;
            moneyRelated.PriceOfItem = 1.00M;

            //act
            moneyRelated.Balance = moneyRelated.Balance - moneyRelated.PriceOfItem;

            Assert.AreEqual(1.00M, moneyRelated.Balance);
        }
        





    }
}
