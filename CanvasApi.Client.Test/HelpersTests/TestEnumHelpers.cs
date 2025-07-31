namespace CanvasApi.Client.Test.HelpersTests
{
    public class TestEnumHelpers
    {

        public enum TestEnum
        {
            TestValueOne,
            TestValueTwo
        }

        [Test]
        public void TestEnumConversion()
        {
            var enumResult1 = "test_value_one".ToEnum<TestEnum>();
            ClassicAssert.IsNotNull(enumResult1);
            ClassicAssert.AreEqual(TestEnum.TestValueOne, enumResult1);

            var enumResult1A = "TestValueOne".ToEnum<TestEnum>();
            ClassicAssert.IsNotNull(enumResult1A);
            ClassicAssert.AreEqual(TestEnum.TestValueOne, enumResult1A);

            var enumResult2 = "test_value_2".ToEnum<TestEnum>();
            ClassicAssert.IsNotNull(enumResult2);
            ClassicAssert.AreEqual(TestEnum.TestValueTwo, enumResult2);

            var enumResult3 = "test_value_two".ToEnum<TestEnum>();
            ClassicAssert.IsNotNull(enumResult3);
            ClassicAssert.AreEqual(TestEnum.TestValueTwo, enumResult3);

            var enumResult4 = "TestValueTwo".ToEnum<TestEnum>();
            ClassicAssert.IsNotNull(enumResult4);
            ClassicAssert.AreEqual(TestEnum.TestValueTwo, enumResult4);

            var enumResult5 = "test_value_xxx".ToEnum<TestEnum>();
            ClassicAssert.IsNull(enumResult5);

        }
    }
}
