using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xc331e80a)]
    public class TLInputGameShortName : TLAbsInputGame
    {
        public override uint Constructor
        {
            get
            {
                return 0xc331e80a;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputUser BotId { get; set; }
        [MTParameter(Order = 1)]
        public string ShortName { get; set; }


    }
}
