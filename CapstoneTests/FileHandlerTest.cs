using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone;

namespace CapstoneTests
{
    [TestClass]
    public class FileHandlerTests
    {
        [TestMethod]
        public static void TestIfItemsImportProperyly()
        {
            FileHandler fileHandler = new FileHandler();

            Dictionary<string, IVendingItem> items = fileHandler.GetVendingItems();
            IVendingItem item = new Chips("Zapp's Voodoo Chips", 3.05M, 5);
            Assert.AreEqual(item, items["A1"]);
        }
        //[TestMethod]
        //public static void ()
        //    {
        //    }
}
}
