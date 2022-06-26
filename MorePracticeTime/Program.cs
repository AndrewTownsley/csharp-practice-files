namespace MorePracticeTime
{
    internal class Program
    {
      
        static void Main(string[] args)
        {

            /// FILES // FILES // FILES //
            /// 
            /*
             *      // File Methods...
             *      
             *      File.
             *      FileInfo.
             *      
                    .Create();
                    .Copy();
                    .Delete();
                    .Exists();
                    .GetAttributes();
                    .Move();
                    .ReadAllText();*/

            // File - 
            /*   var path = @"c:\somefile.jpg"; 
               File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
               File.Delete(path);
               if(File.Exists(path))
               {
                   // 
               }
               var content = File.ReadAllText(path);

               var fileInfo = new FileInfo(path); 
               fileInfo.CopyTo("...");
               fileInfo.Delete();
               if(fileInfo.Exists)
               {
                   // 
               }
               fileInfo.Read();*/


            // Directory.
            // DirectoryInfo.
            // CreateDirectory();
            /*      .Delete();
                    .Exists();
                    .GetCurrentDirectory();
                    .GetFiles();
                    .Move();
                    .GetLogicalDrives();*/


            /*        Directory.*/

            /*            Directory.CreateDirectory(@"c:\temp\folder1");
            */      /*      var files = Directory.GetFiles(@"c:\Users\acer\Repos", "*.html*", SearchOption.AllDirectories);  
                            foreach(var file in files)
                                Console.WriteLine(file);*/
            /*
                        var directories = Directory.GetDirectories(@"c:\Users\acer\Repos", "*.*", SearchOption.AllDirectories);
                        foreach(var directory in directories)
                            Console.WriteLine(directory);

                        *//*            Directory.Exists(".. directory path here...");*//*

                        var directoryInfo = new DirectoryInfo("...");
                        directoryInfo.GetFiles();
                        directoryInfo.GetDirectories();
                    //*/
            //
            // Path.
            /*
                    .GetDirectoryName();
                    .GetFileName();
                    .GetExtension();
                    .GetTempPath();*/


            var path = @"C:\Users\acer\Repos\codewars-practice\app.js";

            Console.WriteLine("Extension Path: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name w/o Extensiom: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));




            /*var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);*/



        }
    }
}