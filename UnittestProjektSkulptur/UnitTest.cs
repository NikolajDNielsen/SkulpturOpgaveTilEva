using System;
using Windows.UI.Popups;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using SkulpturOpgaveTilEva.Model;

namespace UnittestProjekt
{
    [TestClass]
    public class SkulpturTest
    {
        private Skulptur Skulptur;

        //Exception

        [TestInitialize]

        [TestMethod]


        public void CheckNavnTest()
        {
            try
            {
                Assert.ThrowsException<ArgumentException>(() => Skulptur.Navn = null);
                Assert.ThrowsException<ArgumentException>(() => Skulptur.Navn = "");
                Assert.ThrowsException<ArgumentException>(() => Skulptur.Navn = "12345");
                Skulptur.Navn = "1122";
                Assert.AreEqual("1122", Skulptur.Navn);
                Assert.ThrowsException<ArgumentException>(() => Skulptur.Navn = "123");
            }
            catch (Exception)
            {

                MessageDialog messageDialog = new MessageDialog("Fejl34567", "Kunne ikke sætte bruger til admin678!!!");
                messageDialog.ShowAsync();

                throw;
            }

        }

    }
}
