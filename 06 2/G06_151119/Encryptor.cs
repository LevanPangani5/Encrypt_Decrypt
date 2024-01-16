using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace G06_151119 {
	class Encryptor {
		public string InputFilePath { get; private set; }
		public string OutputFilePath { get; private set; }

		public Encryptor(string inputFilePath, string outputFilePath) {
			InputFilePath = inputFilePath;
			OutputFilePath = outputFilePath;
		}
        


        public void Encrypt(string password) {
			using (var reader = new StreamReader(InputFilePath))
			using (var writer = new StreamWriter(OutputFilePath)) {
                Random r = new Random();              
                int[] transporter = new int[reader.BaseStream.Length];
                int[] collector = new int[transporter.Length];

                if (password == "xe")
                {
                    for (int i = 0; i < transporter.Length; i++)
                    {
                        transporter[i] = reader.Read();
                    }

                    for (int i = 0; i < transporter.Length; i++)
                    {
                        writer.Write((char)transporter[i] - 1);
                    }
                }
                if(password != "xe")
                {
                    Console.WriteLine("Wrong password you can't Encrypt this file");
                }
                
			}
		}

		public void Decrypt(string password) {
            using (var reader = new StreamReader(InputFilePath))
            using (var writer = new StreamWriter(OutputFilePath))
            {
                int[] transporter = new int[reader.BaseStream.Length];

                for (int i = 0; i < transporter.Length; i++)
                {
                    transporter[i] = reader.Read();
                }
                if (password == "xe")
                {
                    for (int i = 0; i < transporter.Length; i++)
                    {
                        writer.Write((char)transporter[i] + 1);
                    }
                }
                else
                {
                    for (int i = 0; i < transporter.Length; i++)
                    {
                        writer.Write((char)transporter[i]);
                    }
                }

            }
		}
	}
}
