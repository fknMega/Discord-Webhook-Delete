using System;
using System.Net;
namespace DeletionExample
{
    class Program
    {
        static void Main(string[] args)
        {


            //Get the url of the input the user gives
            Console.Write("Input your webhook url: ");
            string input = Console.ReadLine();


            //Use a DELETE request method to delete the webhook - if it fails you will get an error
            try
            {

                //Create a new WebRequest with a DELETE method, and get the url (https://docs.microsoft.com/en-us/dotnet/api/system.net.webrequest?view=net-5.0)
                var request = WebRequest.Create(input);
                request.Method = "DELETE";
                var response = (HttpWebResponse)request.GetResponse();

                //if we don't get an error here ^ it will say that everything's good
                Console.WriteLine("\nWebhook has been deleted!");

            } catch (Exception ex)
            {

                //Throw an error if it fails
                Console.WriteLine("\nFailed! \n\n" + ex.Message);

            }




            //! Wait for enter key to exit program (DOESN'T HAVE ANYTHING TO DO WITH THE WEBHOOK DELETER) !
            Console.WriteLine("\n\nPress <Enter> to exit");

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
            }



        }
    }
}
