using System;

namespace Document_Program_Practice
{
    public class ProDocumentProgram : DocumentProgram
    {
        public sealed override void Edit()
        {
            Console.WriteLine("Document Edited");
        }

        public override void Save()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet.");
        }

        public override void DoAllOperations()
        {
            Open();
            Edit();
            Save();
        }
    }
}