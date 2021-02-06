namespace Document_Program_Practice
{
    public static class Configuration
    {
        public static DocumentProgram[] GetPrograms()
        {
            DocumentProgram[] documentPrograms = new DocumentProgram[]
            {
                new DocumentProgram(),
                new ProDocumentProgram(),
                new ExpertDocumentProgram()
            };

            return documentPrograms;
        }
    }
}
