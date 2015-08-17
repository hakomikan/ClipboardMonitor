using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClipboardMonitor;
using System.Windows.Forms;

namespace ClipboardMonitorTest
{
    [TestClass]
    public class ClipboardMonitorTest
    {
        [TestMethod]
        public void TestBasic()
        {
            var viewer = new ClipboardMonitor.ClipboardMonitor();
            IDataObject content = null;

            viewer.ClipboardReceived += () => content = Clipboard.GetDataObject();

            Assert.AreEqual(null, content);
            Clipboard.SetText("test");
            Assert.AreNotEqual(null, content);
        }
    }
}
