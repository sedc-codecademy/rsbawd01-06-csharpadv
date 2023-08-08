namespace WorkWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C:\Users\almir\Source\Repos\sedc-codecademy\rsbawd01-06-csharpadv\WorkWithFiles\Documents\test.txt

            string absolutePath = "C:\\Users\\almir\\Source\\Repos\\sedc-codecademy\\rsbawd01-06-csharpadv\\WorkWithFiles\\Documents\\test.txt";

            string relativePath = "../../../../../../../../../test.txt";

            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);

            bool documentsExists = Directory.Exists("C:\\Users\\almir\\Source\\Repos\\sedc-codecademy\\rsbawd01-06-csharpadv\\WorkWithFiles\\Documents");

            string appPath = "C:\\Users\\almir\\Source\\Repos\\sedc-codecademy\\rsbawd01-06-csharpadv\\WorkWithFiles\\Documents";

            bool appPathExists = Directory.Exists(appPath);

            string newFolderPath = appPath + "\\NoviFolder";
            
            DirectoryInfo dirInfo = Directory.CreateDirectory(newFolderPath);

            if (Directory.Exists(newFolderPath)) 
            {
                Directory.Delete(newFolderPath);
            }

            string newFilePath = appPath + "\\anotherTest.txt";

            FileStream newFile = File.Create(newFilePath);
            newFile.Close();

            if (File.Exists(newFilePath))
                File.WriteAllText(newFilePath, "Hello from SEDC, we are learning C#");

            //if (File.Exists(newFilePath))
            //{
            //    File.Delete(newFilePath);
            //}

            if (File.Exists(newFilePath))
            {
                string content = File.ReadAllText(newFilePath);

                Console.WriteLine($"File content is:\n{content}");

                File.AppendAllText(newFilePath, "Append text");

                string content2 = File.ReadAllText(newFilePath);
                Console.WriteLine($"... File content is:\n{content2}");
            }

            // Working with streams

            string appPathDir = "C:\\Users\\almir\\Source\\Repos\\sedc-codecademy\\rsbawd01-06-csharpadv\\WorkWithFiles\\Documents";
            string newDir = appPathDir + "\\myFolder";
            string newStreamFile = newDir + "\\test.txt";

            if (Directory.Exists(newDir) == false)
            {
                Directory.CreateDirectory(newDir);
                Console.WriteLine("New directory created");
            }

            if (File.Exists(newStreamFile) == false)
                File.Create(newStreamFile).Close();

            StreamWriter streamWriter = new StreamWriter(newStreamFile);

            using (streamWriter)
            {
                streamWriter.WriteLine("1. Almir");
                streamWriter.WriteLine("2. Zoran");
                streamWriter.WriteLine("3. Biljana");
                streamWriter.WriteLine("4. Miroslav");
                streamWriter.WriteLine("5. Vitomir");
                streamWriter.WriteLine("6. Igor");
                streamWriter.WriteLine("7. Attila");
                streamWriter.WriteLine("8. Milan");
            }

            StreamWriter streamWriterAppend = new StreamWriter(newStreamFile, true);

            using (streamWriterAppend) 
            {
                streamWriterAppend.WriteLine("9. David");
                streamWriterAppend.WriteLine("10. Nikola");
            }

            Console.WriteLine("............. READING THE STREAM - START ..........");

            StreamReader streamReader = new StreamReader(newStreamFile);

            using (streamReader)
            {
                string firstLine = streamReader.ReadLine();
                string secondLine = streamReader.ReadLine();

                string restOfTheContent = streamReader.ReadToEnd();

                Console.WriteLine(firstLine);
                Console.WriteLine(secondLine);
                Console.WriteLine(restOfTheContent);
            }

            Console.WriteLine("............. READING THE STREAM - END ..........");

            Console.WriteLine("We are done with writing to the file");

            Console.ReadLine();
        }
    }
}