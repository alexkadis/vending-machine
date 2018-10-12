using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Text;
using Capstone;
namespace CapstoneTests
{
    [TestClass]
    public class VendingMachineTest
    {
        [DataTestMethod]
        [DataRow("5", 5)]
        [DataRow("10", 10)]
        [DataRow("2", 2)]
        [DataRow("1", 1)]
        public void TestsIfDepositingCashWorksCorrectly(string input, int expected)
        {
            VendingMachine vm = new VendingMachine();
            vm.Money.AddMoney(input);
            decimal result = vm.Money.MoneyInMachine;

            Assert.AreEqual((decimal)expected, result);
        }

        [TestMethod]
        public void TestsIfReturnCashAsExpected()
        {
            VendingMachine vm = new VendingMachine();
            vm.Money.AddMoney("1.35");
            string result = vm.Money.GiveChange();

            Assert.AreEqual(result, "Your change is 5 quarters, 1 dimes, and 0 nickels");

        }

        [TestMethod]
        public void TestsIfWillReturnOutOfStockIfSold5orMore()
        {
            VendingMachine vm = new VendingMachine();
            var menu = new Menu();
            vm.Money.AddMoney("10");
            vm.RetreiveItem("A4");
            vm.RetreiveItem("A4");
            vm.RetreiveItem("A4");
            vm.RetreiveItem("A4");
            vm.RetreiveItem("A4");
            vm.RetreiveItem("A4");
            string result = vm.VendingMachineItems["A4"].MessageWhenSoldOut;
            string expected = "Sold out of Zapp's Blood Moon Chip!\nBuy something else!";

            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void TestsIfNotEnoughMoneyEnteredToPurchaseItem()
        {
            var vm = new VendingMachine();
            vm.RetreiveItem("A1");
            string result = vm.MessageToUser;
            Assert.AreEqual("Not enough money in the machine to complete the transaction.", result);
        }

    }
}
