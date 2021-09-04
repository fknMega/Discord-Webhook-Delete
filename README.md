### Discord-Webhook-Delete
**A simple example on how to delete an discord webhook using c#**

The Project I created is using .NET 6.0.0, so if you want to run my own project I created you will have to install .NET 6.0.0
but if you just want to use this ↓ code you won't have too.

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
