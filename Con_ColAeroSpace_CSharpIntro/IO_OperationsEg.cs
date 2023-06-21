using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_ColAeroSpace_CSharpIntro
{
    internal class IO_OperationsEg
    {
        static void Main(string[] args)
        {
            DriveInfoDemo();

            DirInfoandFileInfo();
            FileBinOperation();
            FileTextOperation();



            Console.ReadLine();

        }

        private static void DirInfoandFileInfo()
        {
            Console.WriteLine("Enter Dir Path for Details:");

            DirectoryInfo d = new DirectoryInfo(Console.ReadLine());
            DirectoryInfo[] dinfos = d.GetDirectories();
            foreach (DirectoryInfo di in dinfos)
            {
                Console.WriteLine(di.Name);
                Console.WriteLine("-----Direcotry Informations----\n\n");
                Console.WriteLine("Full Name={0}", di.FullName);
                Console.WriteLine("Root={0}", di.Root);
                Console.WriteLine("Attributes={0}", di.Attributes);
                Console.WriteLine("  Creation Time={0}", di.CreationTime);
                Console.WriteLine($" Creation Time={di.CreationTime}");

                Console.WriteLine("Name={0}", di.Name);
                Console.WriteLine("Parent={0}", di.Parent);

                Console.WriteLine("-----Files Info-----");


                string fp = @"";
                foreach (FileInfo finfo in di.GetFiles())
                {
                    Console.WriteLine($"File Name{finfo.Name} \n  FullName :{finfo.FullName} \n CreationTime :{finfo.CreationTime}");
                }

            }


        }

        private static void DriveInfoDemo()
        {
            Console.Clear();


            DriveInfo[] di = DriveInfo.GetDrives();
            Console.WriteLine("Total Partitions");

            foreach (DriveInfo items in di)
            {

                Console.WriteLine(items.Name);
            }



            Console.Write("\nEnter the Partition\\ specific Drive ::");
            string ch = Console.ReadLine();

            DriveInfo driveInfo = new DriveInfo(ch);

            Console.WriteLine("\n");

            Console.WriteLine("Drive Name::{0}", driveInfo.Name);
            Console.WriteLine("Total Space::{0}", driveInfo.TotalSize);
            Console.WriteLine("Free Space::{0}", driveInfo.TotalFreeSpace);
            Console.WriteLine("Drive Format::{0}", driveInfo.DriveFormat);
            Console.WriteLine("Volume Label::{0}", driveInfo.VolumeLabel);
            Console.WriteLine("Drive Type::{0}", driveInfo.DriveType);
            Console.WriteLine("Root dir::{0}", driveInfo.RootDirectory);
            Console.WriteLine("Ready::{0}", driveInfo.IsReady);



            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        static void FileBinOperation()
        {




            FileInfo fi = new FileInfo("Demo.bin");
            using (BinaryWriter bw = new BinaryWriter(fi.OpenWrite()))
            {

                string str = "Never be the reason someone asked God for peace";


                bw.Write(str);
            }

            //Reading   
            FileInfo f = new FileInfo("Demo.bin");
            using (BinaryReader br = new BinaryReader(fi.OpenRead()))
            {

                Console.WriteLine(br.ReadString());
            }
            Console.ReadLine();


        }


        static void FileTextOperation()
        {

            if (File.Exists("test.txt"))
            {
                string content = File.ReadAllText("test.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }
            Console.WriteLine("Please enter new content for the file:");
            string newContent = Console.ReadLine();
            File.WriteAllText("test.txt", newContent);


        }
    }
}
