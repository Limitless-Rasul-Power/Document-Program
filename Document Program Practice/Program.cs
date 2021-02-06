using System;
using System.Windows.Forms;

namespace Document_Program_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            DocumentProgram[] documentPrograms = Configuration.GetPrograms();

            while (true)
            {
                Console.WriteLine("Keys: \"basic\", \"pro\", \"expert\"");
                Console.Write("Enter key please: ");
                string key = Console.ReadLine().ToLower();

                while (Verify.IsKeyNotExist(key))
                {
                    Console.Clear();
                    Console.Write("\nEnter one of this keys(\"basic\", \"pro\", \"expert\"): ");
                    key = Console.ReadLine().ToLower();
                }
                Console.Clear();

                try
                {
                    documentPrograms[ProgramIndex.FindIndexWithKey(key)].DoAllOperations();
                    Console.Write("\nPress \"Enter\" to continue...");
                    Console.ReadLine();
                }
                catch (InvalidOperationException caption)
                {
                    Console.Clear();
                    MessageBox.Show(caption.Message, "Document Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Console.Clear();
            }
        }
    }
}