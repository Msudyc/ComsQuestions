using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Commons;

namespace FB
{
    public partial class FBEx
    {
        [TestMethod]
        public void FB_SumNumbersTest1()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                r = new TreeNode(3), 
                rl = new TreeNode(4),
                rr = new TreeNode(5);
            root.Left = l; 
            root.Right = r;
            r.Left = rl; 
            r.Right = rr;
            Assert.AreEqual(281, SumNumbers(root));
        }

        [TestMethod]
        public void FB_SumNumbersTest2()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                r = new TreeNode(3);
            root.Left = l; 
            root.Right = r;
            Assert.AreEqual(25, SumNumbers(root));
        }

        [TestMethod]
        public void FB_SumNumbersTest3()
        {
            TreeNode root = new TreeNode(1);
            Assert.AreEqual(1, SumNumbers(root));
        }
    };
}