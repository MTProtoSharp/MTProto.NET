using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Bots
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
        public TLVector<MTProto.NET.Schema.TL.TLBotCommand> Commands { get; set; }


    }
}
