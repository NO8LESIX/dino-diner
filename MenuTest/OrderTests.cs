using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTests
    {
        [Fact]
        public void CorrectTotalCost()
        {
            Order od = new Order();
            od.Items.Add(new Water());
            Assert.Equal(0.10, od.TotalCost, 2);
        }
        [Fact]
        public void CorrectSubTotalCost()
        {
            Order od = new Order();
            od.Items.Add(new Water());
            Assert.Equal(0.10, od.TotalCost, 2);
        }
    }
}
