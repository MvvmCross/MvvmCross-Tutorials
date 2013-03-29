using Cirrious.MvvmCross.Plugins.Messenger;

namespace FractalGen.Core.Services
{
    public class TickMessage : MvxMessage
    {
        public TickMessage(object sender)
            : base(sender)
        {
        }
    }
}