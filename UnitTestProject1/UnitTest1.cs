using Microsoft.VisualStudio.TestTools.UnitTesting;
using Table;

namespace Table.Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void Form1LoadTest()
        {
            Form1 form = new Form1();

            form.Form1_Load(null, null);

            
        }
    }
}