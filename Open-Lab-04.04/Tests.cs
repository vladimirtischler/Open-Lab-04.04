using System;
using System.Collections;
using NUnit.Framework;

namespace Open_Lab_04._04
{
    [TestFixture]
    public class Tests
    {

        private PhoneNumbers pn;

        private const int RandSeed = 404404404;
        private const int RandTestCasesCount = 97;

        [OneTimeSetUp]
        public void Init() => pn = new PhoneNumbers();

        [TestCase(new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 })]
        [TestCase(new []{ 5, 1, 9, 5, 5, 5, 4, 4, 6, 8 })]
        [TestCase(new []{ 3, 4, 5, 5, 0, 1, 2, 5, 2, 7 })]
        [TestCaseSource(nameof(GetRandom))]
        public void FormatPhoneNumberTest(int[] nums) =>
            StringAssert.IsMatch(@"^\([\d]{3}\) [\d]{3}-[\d]{4}$", pn.FormatPhoneNumber(nums));

        private static IEnumerable GetRandom()
        {
            var rand = new Random(RandSeed);

            for (var i = 0; i < RandTestCasesCount; i++)
            {
                var arr = new int[10];

                for (var j = 0; j < 10; j++)
                    arr[j] = rand.Next(10);

                yield return new TestCaseData(arr);
            }
        }

    }
}
