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

            Dictionary<string, VendingItem> items = fileHandler.GetVendingItems();
            VendingItem item = new Chip("Zapp's Voodoo Chip", 3.05M, 5);
            Assert.AreEqual(item, items["A1"]);
        }
}
}
