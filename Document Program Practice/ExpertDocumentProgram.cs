using System;

namespace Document_Program_Practice
{
    public class ExpertDocumentProgram : ProDocumentProgram
    {
        public override void Save()
        {
            Console.WriteLine("Document Saved in pdf format.");
        }
        public override void DoAllOperations()
        {
            Open();
            Edit();
            Save();
        }
    }
}