using System.IO;
using System.Collections.Generic;

var salesFiles = FindFile("stores");
FindDirectory();
static void FindDirectory() 
    {
        string docs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Console.WriteLine(Path.Combine(docs,"stores"));
        Console.WriteLine(Path.GetExtension("sales"));
    }


foreach (var file in salesFiles)
{
    Console.WriteLine();
}

IEnumerable<string> FindFile(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        // The file name will contain the full path, so only check the end of it
        if (file.EndsWith("sales.json"))
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}