using System.IO;
class FDHandling
{
    //File IO
    public static void CreateFile(){
        var folderPath = @"C:\dotnetLearning\NETLearning-prashuva\FirstConsoleApp\7.FileIO";
        var filePath = $"{folderPath}\\student.txt";
        File.WriteAllText(filePath, "This is first line of text");

        Directory.CreateDirectory($"{folderPath}\\Dummy");

        //Create 10 files with names File1.cs, File2.cs, File3.cs.....
        //Each file should contain available 'age' with value as 1, 2, 3, ....
        for(int i =1; i<=10; i++){
            var file = $"File{i}";
            filePath = $"{folderPath}\\Dummy\\{file}.cs";
            File.WriteAllText(filePath, "class " + file + "{ }");  
        }

        //reading
        string content = File.ReadAllText(" ");
        var words = content.Split([' ', ',', '.', ':', '-']);
        Console.WriteLine(words.Length);

    }
}