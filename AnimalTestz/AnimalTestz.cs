using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyInheritanceLibrary;
namespace AnimalTestz
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void TestDogSpeak()
        {
            // Arange // Act // Assert
            //So arrange the dog speak to ensure it tests succesfully
            Dog dog = new Dog();

            // Act
            string result = TestHelper.CaptureConsoleOutput(() => dog.Speak());

            // Assert
            Assert.AreEqual("Woof", result.Trim());

        }

        [TestMethod]
        public void TestCatSpeak()
        {
            // Arange // Act // Assert
            //So arrange the dog speak to ensure it tests succesfully
            Cat cat = new Cat();

            // Act
            string result = TestHelper.CaptureConsoleOutput(() => cat.Speak());

            // Assert
            Assert.AreEqual("Meow", result.Trim());

        }

        [TestMethod]
        public void TestBirdSpeak()
        {
            // Arange // Act // Assert
            //So arrange the dog speak to ensure it tests succesfully
            Bird bird = new Bird();

            // Act
            string result = TestHelper.CaptureConsoleOutput(() => bird.Speak());

            // Assert
            Assert.AreEqual("Chirpy Chirp", result.Trim());

        }
    }
}