﻿using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DALTest
{
    public class Test
    {
        AdminInfo a = null;
        EmpInfo e = null;

        public Test()
        {
            a = new AdminInfo();
            e = new EmpInfo();
        }

        [TestCase]
        public void EmailTest()
        {
            MyContext m=new MyContext();
            var ans = m.AdminInfoTable.ToList();
            Assert.AreEqual("admin@gmail.com", ans[0].EmailId);

        }

        [TestCase]
        public void PasswordTest()
        {
            MyContext s = new MyContext();
            var result = s.AdminInfoTable.ToList();
            Assert.AreEqual("admin123",result[0].Password);
        }

        Validate v = new Validate();
        [TestCase]
        public void AdminTest()
        {
           v.AdminTest();
        }
    }
}
