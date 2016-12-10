using System;

namespace Support
{
    public static class Verify
    {
        private static int _num;
        // 计算出错数量

        public static void Reset()
        {
            _num = 0;
        }

        public static void CheckError()
        {
            if (_num != 0)
            {
                throw new Exception("VERIFICATION ERROR: Current case has " + _num + " verification error!");
            }
            _num = 0;
        }

        public static void ShouldBeEqualsTo(this string actual, string expected, string text = null)
        {
            if (expected.Equals(actual)) return;
            _num++;
            if (!string.IsNullOrEmpty(text))
            {
                Log.DoLog("==========" + text + "==========");
            }
            Log.DoLog("==========ShouldBeEqualsTo==========");
            Log.DoLog("Expected value is: " + expected);
            Log.DoLog("Actual value is: " + actual);
            Log.DoLog("=============================");
        }

        public static void ShouldNotBeEqualsTo(this string actual, string expected)
        {
            if (!expected.Equals(actual)) return;
            _num++;
            Log.DoLog("==========ShouldNotBeEqualsTo==========");
            Log.DoLog("Expected value is: " + expected);
            Log.DoLog("Actual value is: " + actual);
            Log.DoLog("=============================");
        }

        public static void ShouldBeTrue(this bool condition)
        {
            if (condition) return;
            _num++;
            Log.DoLog("==========ShouldBeTrue==========");
            Log.DoLog("Expected value is: True");
            Log.DoLog("Actual value is: False");
        }

        public static void ShouldBeFalse(this bool condition)
        {
            if (!condition) return;
            _num++;
            Log.DoLog("==========ShouldBeFalse==========");
            Log.DoLog("Expected value is: False");
            Log.DoLog("Actual value is: True");
            Log.DoLog("=============================");
        }

        public static void ShouldContain(this string actual, string expected)
        {
            if (actual.Contains(expected)) return;
            _num++;
            Log.DoLog("==========ShouldContain==========");
            Log.DoLog("Expected value is: " + expected);
            Log.DoLog("Actual value is: " + actual);
            Log.DoLog("=============================");
        }
        // NotContain
        public static void ShouldNotContain(this string actual, string expected)
        {
            if (!actual.Contains(expected)) return;
            _num++;
            Log.DoLog("==========ShouldNotContain==========");
            Log.DoLog("Expected value is: " + expected);
            Log.DoLog("Actual value is: " + actual);
            Log.DoLog("=============================");
        }
    }
}
