using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace CollectionAsserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private List<string> _users;

        [TestInitialize]
        public void CreateData()
        {
            _users = new List<string>();
            _users.Add("Utku");
            _users.Add("Umut");
            _users.Add("Nuray");
        }

        // Eleman ve sırası aynı olmadılır
        [TestMethod]
        public void Should_be_same_elements_and_order()
        {
            List<string> newUsers = new List<string>();

            newUsers.Add("Utku");
            newUsers.Add("Umut");
            newUsers.Add("Nuray");

            // Collection verilerini karşılaştırır.
            CollectionAssert.AreEqual(newUsers, _users);
        }

        // Eleman aynı sırası farklı olmalı
        [TestMethod]
        public void Elemants_should_be_same_but_order_can_be_different()
        {
            List<string> newUsers = new List<string>();
            newUsers.Add("Nuray");
            newUsers.Add("Utku");
            newUsers.Add("Umut");

            CollectionAssert.AreEquivalent(_users, newUsers);
        }


        [TestMethod]
        public void Should_be_same_elements_and_orderr()
        {
            List<string> newUsers = new List<string>();

            newUsers.Add("Nuray");
            newUsers.Add("Utku");
            newUsers.Add("Umut");

            // Collection verilerini karşılaştırır.

            CollectionAssert.AreNotEqual(newUsers, _users);
        }

        [TestMethod]
        public void Elemants_should_be_different()
        {
            List<string> newUsers = new List<string>();

            newUsers.Add("Nuray");
            newUsers.Add("Utku");
            newUsers.Add("Umut");
            newUsers.Add("Birol");

            CollectionAssert.AreNotEquivalent(newUsers, _users);
        }

        [TestMethod]
        public void Users_should_not_recieve_null_value()
        {
            CollectionAssert.AllItemsAreNotNull(_users);
        }

        [TestMethod]
        public void Users_should_be_unique()
        {
            CollectionAssert.AllItemsAreUnique(_users);
        }

        [TestMethod]
        public void All_elements_should_be_same_type()
        {
            ArrayList list = new ArrayList
            {
                "Utku", "Umut", "Birol"
                //"Utku", "Umut", 1
            };

            CollectionAssert.AllItemsAreInstancesOfType(list, typeof(string));
        }
    }
}