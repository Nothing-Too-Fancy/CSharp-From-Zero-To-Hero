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
            if (!File.Exists(dirtyFile) || !File.Exists(cleanedFile)) throw new ArgumentException("File paths are invalid/do not exist.");
            //File.WriteAllText(cleanedFile, "a");
        }
    }
}
