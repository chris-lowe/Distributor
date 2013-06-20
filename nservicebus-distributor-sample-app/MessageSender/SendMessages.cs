using System;
using Commands;
using NServiceBus;

namespace MessageSender
{
    public class SendMessages : IWantToRunAtStartup

    {
        public IBus Bus { get; set; }

        public void Run()
        {
            Console.WriteLine("Press 'Enter' to send messages.");
            Console.WriteLine("To exit, Ctrl + C");

            while (Console.ReadLine() != null)
            {
                for (var i = 0; i < 50; i++)
                {
                    var createUserMessage = new CreateUserCommand() { UserId = i };
                    Bus.Send(createUserMessage);

                    var changeEmailMessage = new ChangeUserEmailAddressCommand() { UserId = i };
                    Bus.Send(changeEmailMessage);
                }

                Console.WriteLine("Done");
            }
        }

        public void Stop()
        {
            
        }
    }
}
