using NServiceBus;

namespace Commands
{
    public class CreateUserCommand : IMessage
    {
        public int UserId;
    }
}
