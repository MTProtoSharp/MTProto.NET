using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Bots
{
    [MTObject(0x805d46f6)]
    public class TLSetBotCommands : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x805d46f6;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<MTSharp.Schema.TL.TLBotCommand> Commands { get; set; }


    }
}
