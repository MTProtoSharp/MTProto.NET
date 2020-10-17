using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x92a72876)]
    public class TLMessageActionGameScore : TLAbsMessageAction
    {
        public override uint Constructor
        {
            get
            {
                return 0x92a72876;
            }
        }

        [MTParameter(Order = 0)]
        public long GameId { get; set; }
        [MTParameter(Order = 1)]
        public int Score { get; set; }


    }
}
