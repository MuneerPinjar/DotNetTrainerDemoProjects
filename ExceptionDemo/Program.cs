using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionDemo
{
  public  class Bank
    {

        public int BankId { get; set; }
        public string Name { get; set; }

        public string Branch { get; set; }

        public void ProcessBankData()
        {
            // Simulate an application - level error
            throw new CustomApplicationException("Error Occured during Bank Data Processing");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                //int a = 12;
                //int b = 0;

                //try
                //{


                //    try
                //    {
                //        throw new NotImplementedException();
                //    }
                //    catch (Exception)
                //    {

                //        throw;
                //    }
                    
                //}

                //catch (Exception)
                //{

                //    throw;
                //}

                //// Divide by Zero
                //int c = a / b;

                // we can get this data during run time or from db or cloud or some external sources
                Bank bank = new Bank();

                bank.ProcessBankData();

                //byte data = byte.Parse("a");
                //Console.WriteLine(data);

                //int[] number = { 8, 12, 43, 5, 25 };
                //int[] divisor = { 2, 1, 6, 5 };



                //for (int i = 0; i < number.Length; i++)
                //{
                //    Console.WriteLine("Number : " + number[i]);
                //    Console.WriteLine("Divisor : " + divisor[i]);
                //    Console.WriteLine("Quotient : " + number[i] / divisor[i]);
                //}



                //Console.WriteLine("Value of c : " + c);


                // we can raise anay sort of exceptions
            }
            catch (DivideByZeroException ex)
            {
                //Log here

                Console.WriteLine("Exception Message :" + ex.Message);
                Console.WriteLine("Not Possible to Divide by Zero");
            }
          

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception Message :" + ex.Message);
                Console.WriteLine("Index out of Range ");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Excetption message : "+ex.Message);
            }

            catch(CustomApplicationException ex)
            {
                Console.WriteLine(ex.Message);

            }
            
            catch (Exception ex)
            {
                //
                Console.WriteLine("Exception Message :" + ex.Message);
            }

          
            finally
            {

                //Important points
                //1 .  Mutliple finally blocks are not allowed in the same program
                //2. It does not contain return, continue, break statments because it does not allow controls to leave the finally block
                //3 . you can also use finally block only with try block mean without catch block but in this situtation, no exceptions handled
                //4. The finally block will be executed after the try and catch block, but before control transfers back to its orgin
                // 5. To realease system resources like database connections or some File IO operations

                Console.WriteLine("Finally block executed");

                Console.WriteLine("System resources are released");

              
            }

          

            // Difference between Errors and Exception

            //Errors
            //1. Errors are unexcpeted issues that may arise during computer program excetuion
            //2. Errors cannot be handled.
            //3. All Errors are exceptions.

            // Exceptions
            //1. Exceptions are unexcepted events that may arise during run=time
            //2. Exceptions can be handled using try - catch mechanism
            //3. All exceptions are not errors
        }
    }
}
