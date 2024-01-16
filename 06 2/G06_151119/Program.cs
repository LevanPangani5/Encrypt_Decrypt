using System;
using System.IO;
using System.Text;


namespace G06_151119
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream Container = new FileStream("D:\\G03_.txt" , FileMode.Create);
            StreamWriter Containerwriter = new StreamWriter(Container);
            Containerwriter.WriteLine("Me");
            Containerwriter.WriteLine("Shen");
            Containerwriter.WriteLine("Is");
            Containerwriter.Close();           
            //password is xe  tu xes ar chawert faili ar gaishifreba
            string inputfile;
            string outputfile;                       
            GetSetup.GetFileNames(out inputfile, out outputfile);
            string password = GetSetup.GetPassword();
            Encryptor worker = new Encryptor(inputfile, outputfile);
            var command =GetSetup.GetCommand();
            if (command == ConsoleKey.D1)
                worker.Encrypt(password);
            else
                worker.Decrypt(password);
           
        }
    }
}
