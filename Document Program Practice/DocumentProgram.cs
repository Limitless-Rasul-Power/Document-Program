using System;

namespace Document_Program_Practice
{
    public class DocumentProgram
    {
        public void Open()
        {
            Console.WriteLine("Document opened.");
        }

        public virtual void Edit()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions.");
        }

        public virtual void Save()
        {
            Console.WriteLine("Can Save in Pro and Expert versions.");
        }

        public virtual void DoAllOperations()
        {
            Open();
            Edit();
            Save();
        }
    }
}