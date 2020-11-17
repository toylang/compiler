using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Toy.Compiler.UnitTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void ParseArgumentTest()
        {
            var sf = "abc";
            var args = new string[] { "-sf", sf };
            var arguments = Program.ParseArgument(args);
            Assert.AreEqual(sf, arguments.SourceFile);
        }
    }
}
