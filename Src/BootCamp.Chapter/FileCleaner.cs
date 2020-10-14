using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public static class FileCleaner
    {
        /// <summary>
        /// Cleans up dirtyFileName 
        /// </summary>
        /// <param name="dirtyFile">Dirty file with "_" placed in random places.</param>
        /// <param name="cleanedFile">Cleaned up file without any "_".</param>
        public static void Clean(string dirtyFile, string cleanedFile)
        {

            dirtyFile = Path.GetFullPath(Path.Combine(@"..\..\..\..\..\Tests\BootCamp.Chapter.Tests\", dirtyFile));
            if (!File.Exists(Path.GetFullPath(dirtyFile))) throw new ArgumentException("File paths are invalid/do not exist.");

            string dirtyFileContents = File.ReadAllText(dirtyFile);
            if (dirtyFileContents.Contains('_'))
            {
                dirtyFileContents = dirtyFileContents.Replace("_", String.Empty);
            }

            File.WriteAllText(Path.GetFullPath(cleanedFile), dirtyFileContents);

        }
    }
}
