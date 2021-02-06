using System;

namespace Document_Program_Practice
{
    public static class Verify
    {
        public static bool IsKeyNotExist(in string key)
        {
            if(!String.IsNullOrWhiteSpace(key))
            {
                if (key == ProgramKeywords.Base || key == ProgramKeywords.Pro || key == ProgramKeywords.Expert)
                    return false;
            }

            return true;
        }
    }
}
