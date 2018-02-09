namespace G2xHelpers
{
    public static class G2xInteger
    {
        #region IsEvenNumber
        private static bool _IsEvenNumber(int? value)
        {
            return value == null ? false : value.Value % 2 == 0;
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
    }
}