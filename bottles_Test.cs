 
namespace _31stAugust.nUnitTests
{
    public class Tests
    {
        private Bottles bt { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
           bt = new Bottles();  
        }


        [TestCase]

        public void bottles_test()
        {
            string sample = "1 bottle of beer on the wall , 1 bottle of beer.\n" + "Take it down and pass it around , no more bottles of beer on the wall .\n";

            string result = bt.verse(1);
            
            Assert.That(result, Is.EqualTo(sample));
        }

        [TestCase]
        public void bottles_test2()
        {
            string sample = "No more bottles of beer on the wall , no more   bottles of beer.\n" +
                    "Go to the store and buy some more , 99 bottles of beer on the wall.\n";

            string output = bt.verse(0);

            Assert.AreEqual(sample, output);
        }


        [Test]

        public void bottles_test3()
        {
            string expected = "98 bottles of beer on the wall , 98 bottles of beer .\n" + "Take one down and pass it around , 97 bottles of beer on the wall.\n";
            
            string output = bt.verse(98);
            
            Assert.AreEqual(expected, output);
        }

        
    }
}