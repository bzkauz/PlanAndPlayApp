using System;
using NUnit.Framework;
using Services;
using Models;

namespace UnitTestAndroid
{
    [TestFixture]
    public class TestService
    {
        public ILogin<LoginData> DataLogin;
      
        private IWebData webServ;
       

        [SetUp]
        public void Setup()
        {
           DataLogin = new Login("");
           webServ = new WebService();
        }


        [TearDown]
        public void Tear() { }

        [Test]
        public async void Pass()
        {
            var date = await DataLogin.GetLoginDataAsync();
            //loginTest.SendAsync("http://blick.ch");
            Console.WriteLine("test1");
            Assert.True(true);
        }


        [Test]
        public async void WebServTest()
        {
            //Task<Earthquake[]> data = await webServ.GetEarthquakesAsync();

            //MessagingCenter.Subscribe<Earthquake, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var _item = item as Item;
            //    Items.Add(_item);
            //    await DataStore.AddItemAsync(_item);
            //});
            Console.WriteLine("test1");
            Assert.True(true);
        }

        [Test]
        public void Fail()
        {
            Assert.False(true);
        }

        [Test]
        [Ignore("another time")]
        public void Ignore()
        {
            Assert.True(false);
        }

        [Test]
        public void Inconclusive()
        {
            Assert.Inconclusive("Inconclusive");
        }
    }
}