using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OrderManagementSystem;

namespace OrderManagementSystemTest
{
    [TestClass]
    public class ClientTest
    {
        [TestMethod]
        public void TestClient()
        {
            string name = "小方";
            Client client = new Client(name);
            CollectionAssert.Equals(client.ClientName, name);
        }
    }
}
