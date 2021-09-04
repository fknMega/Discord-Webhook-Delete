### Discord-Webhook-Delete
**A simple example on how to delete an discord webhook using c#**

Here's the discord webhook docs: https://discord.com/developers/docs/resources/webhook#delete-webhook

and the .NET WebRequest: https://docs.microsoft.com/en-us/dotnet/api/system.net.webrequest?view=net-5.0



            Console.Write("Input your webhook url: ");
            string input = Console.ReadLine();


            try
            {

                var request = WebRequest.Create(input);
                request.Method = "DELETE";
                var response = (HttpWebResponse)request.GetResponse();

                Console.WriteLine("\nWebhook has been deleted!");

            } catch (Exception ex)
            {

                Console.WriteLine("\nFailed! \n\n" + ex.Message);

            }
