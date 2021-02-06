using System;

namespace Document_Program_Practice
{
    public static class ProgramIndex
    {
        public static readonly int Base = 0;
        public static readonly int Pro = 1;
        public static readonly int Expert = 2;

        public static int FindIndexWithKey(in string key)
        {
            if (!String.IsNullOrWhiteSpace(key))
            {
                if (key == ProgramKeywords.Base)
                    return Base;
                else if (key == ProgramKeywords.Pro)
                    return Pro;
                else if(key == ProgramKeywords.Expert)
                    return Expert;
            }

            throw new InvalidOperationException("Key is null or white space or doesn't suitable for \"Principle\" keywords");
        }

    }
}