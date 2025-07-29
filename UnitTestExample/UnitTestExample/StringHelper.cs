using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestExample
{
    [TestClass] // TestClass attribute.
    public class StringHelper
    {
        [TestMethod] // TestMethod attribute.
        // Fazla boşlukları sil
        public static string DeleteExtraSpaces(string expression)
        {
            expression = expression.Trim();

            string newExpression = string.Empty;

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ' ' && expression[i + 1] == ' ')
                    continue;

                newExpression += expression[i];
            }
            return newExpression;
        }
    }
}