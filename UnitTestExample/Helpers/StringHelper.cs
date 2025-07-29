namespace Helpers
{
    public class StringHelper
    {
        //Girilen ifadenin başında ve sonundaki fazla boşluklar silinmelidir.
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