using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;



namespace FileIODemo
{

    class ReadFileUsingStreamReader
    {
        public void data()
        {

            StreamReader streamReader = new StreamReader(@"D:\testfileUsingStreamWriter");

            try
            {
                Console.WriteLine("Content of the file :");

                // this is use to specify from wher to start reading the input stream
                streamReader.BaseStream.Seek(0, SeekOrigin.Begin);

                // To read the line from the input stream
                string str = streamReader.ReadLine();

                /// to read the whole file line by line
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = streamReader.ReadLine();
                }


                Console.ReadLine();

            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                // to close the stream
                streamReader.Close();

            }

          
            


        }
    }

    class WriteToFile
    {

        public void Data()
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(@"D:\testfileUsingStreamWriter");

                Console.WriteLine("Enter the text that you want to write to a file : ");

                //To Read the input from the user
                string str = Console.ReadLine();

                ///To write a line in buffer
                streamWriter.WriteLine(str);

                //To write in output stream
                streamWriter.Flush();


                //To close the stream
                streamWriter.Close();

            }
            catch (EncoderFallbackException)
            {
                throw;
            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
        



        }

    }

    internal class Program
    {
       
        static void Main(string[] args)
        {   
            string path = @"D:\testdata.txt";
            Action DoSomething = () => Console.WriteLine("Hello world");

            DoSomething();


            FileStream fileStream = new FileStream(@"D:\newfileUsingFileStream", FileMode.Create, FileAccess.Write, FileShare.None);
            try
            {

                //if (File.Exists(path)/*)*/
                //{
                //    Console.WriteLine("File Exists");


                //    // read the file using readalllines method of file class
                //    string[] dataFromFile;
                //     dataFromFile = File.ReadAllLines(path);


                //    foreach (string line in dataFromFile)
                //    {
                //        Console.WriteLine(line);
                //    }

                //    Console.WriteLine("Using ReadAllText method");
                //    // ReadAllText
                //    string data = File.ReadAllText(path);
                //    Console.WriteLine(data);


                //    //  File copy
                //    string filetoCopy = @"D:\copyofTestData.txt";
                //    if (!File.Exists(filetoCopy))
                //    {
                //        File.Copy(path, filetoCopy);
                //    }

                //    File.Delete(filetoCopy);

                //    data = "New test data";

                //    File.WriteAllText(path, data);

                //    File.AppendAllText(path, "Append the data");



                //    Console.ReadLine();


                //}
                //else
                //{
                //    //throw new FileNotFoundException();


                //}


                // using FileStream class 




                // store the text in the file

                //    var testdata = " this is some test sample data to be written on the file created using Filestream class";

                ////// store the text in a byte array with UTF8 enconding (8 bit unicode transformation Format_
                /////


                //byte[] writearrydata = Encoding.UTF8.GetBytes(testdata);


                //fileStream.Write(writearrydata, 0, testdata.Length);

                //fileStream.Close();



                //FileStream fileRead = new FileStream(@"D:\newfileUsingFileStream", FileMode.Open, FileAccess.Read, FileShare.Read);

                //byte[] readArr =  new byte[testdata.Length];
                //int count;

                //// using readmethod read untill end of the line
                //while((count = fileRead.Read(readArr, 0, readArr.Length)) > 0)
                //{
                //   Console.WriteLine(Encoding.UTF8.GetString(readArr,0,count));
                //}

                //fileRead.Close();
                //Console.ReadLine()/*;*/


                //using StreamWriter


                //WriteToFile writeToFile = new WriteToFile();
                //writeToFile.Data();
                //Console.ReadKey();


                // using StreamReader

                ReadFileUsingStreamReader readFileUsingStreamReader = new ReadFileUsingStreamReader();

                readFileUsingStreamReader.data();


                Console.ReadLine();
                Console.ReadLine();
                


            }

          

            catch (FileNotFoundException ex)
            {
                Console.WriteLine(" File does not exists :"+ex.Message);
            }

            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                // code here to handle security breaches 
                // log the security breach and also alert your application admintrator
                byte[] writearrydata = Encoding.UTF8.GetBytes(ex.Message +" DateTime : "+DateTime.Now.ToString());
                fileStream.Write(writearrydata, 0, ex.Message.Length);


            }

            catch (Exception ex)
            {

                throw;
            }

            finally
            {
                fileStream.Close();
                
            }


            // File exists or not


        }
    }
}
