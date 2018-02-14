namespace G2xHelpers
{
    public static class G2xInteger
    {
        #region IsEvenNumber
        private static bool _IsEvenNumber(int? value)
        {
            return value != null && value.Value % 2 == 0;
        }
        public static bool IsEvenNumber(this int value)
        {
            return _IsEvenNumber(value);
        }
        public static bool IsEvenNumber(this int? value)
        {
            return _IsEvenNumber(value);
        }
        #endregion
        #region IsPrime
        private static bool _IsPrime(int? value)
        {
            if (value == null || value.Value == 1) return false;
            for (int index = 2; index * index <= value; index++)
            {
                if (value.Value % index == 0) return false;
            }
            return true;
        }
        public static bool IsPrime(this int value)
        {
            return _IsPrime(value);
        }
        public static bool IsPrime(this int? value)
        {
            return _IsPrime(value);
        }
        #endregion
    }
}