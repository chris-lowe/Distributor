using NServiceBus;

namespace Commands
{
    public class ChangeUserEmailAddressCommand : IMessage
    {
        public int UserId;
    }
}
