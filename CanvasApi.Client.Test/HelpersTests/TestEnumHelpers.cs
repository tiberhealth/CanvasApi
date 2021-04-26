using System;
using CanvasApi.Client.Assignments.Enums;
using NUnit.Framework;
using CanvasApi.Client.Helpers;
using TiberHealth.Serializer.Attributes;

namespace CanvasApi.Client.Test.HelpersTests
{
    public class TestEnumHelpers
    {

        public enum TestEnum
        {
            TestValueOne,
            [EnumSerializedValue("test_value_2")] TestValueTwo
        }

        [Test]
        public void TestEnumConversion()
        {
            var enumResult1 = "test_value_one".ToEnum<TestEnum>();
            Assert.IsNotNull(enumResult1);
            Assert.AreEqual(TestEnum.TestValueOne, enumResult1);

            var enumResult1a = "TestValueOne".ToEnum<TestEnum>();
            Assert.IsNotNull(enumResult1a);
            Assert.AreEqual(TestEnum.TestValueOne, enumResult1a);

            var enumResult2 = "test_value_2".ToEnum<TestEnum>();
            Assert.IsNotNull(enumResult2);
            Assert.AreEqual(TestEnum.TestValueTwo, enumResult2);

            var enumResult3 = "test_value_two".ToEnum<TestEnum>();
            Assert.IsNotNull(enumResult3);
            Assert.AreEqual(TestEnum.TestValueTwo, enumResult3);

            var enumResult4 = "TestValueTwo".ToEnum<TestEnum>();
            Assert.IsNotNull(enumResult4);
            Assert.AreEqual(TestEnum.TestValueTwo, enumResult4);

            var enumResult5 = "test_value_xxx".ToEnum<TestEnum>();
            Assert.IsNull(enumResult5);

        }
    }
}
