namespace EventScheduler.Data.Exceptions
{
    using System;


    public static class Validator
    {
        public static void CheckIfObjectIsNull(object obj, string message = null)
        {
            if (obj == null)
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfNullOrEmpty(string text, string message = null)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(message);
            }
        }

        public static void CheckIfLengthIsValid(string text, int min = 0, int max, string message = null)
        {
            if (text.Length < min || max < text.Length)
            {
                throw new ArgumentOutOfRangeException(message);
            }
        }
    }
}
