using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x4bd6e798)]
    public class TLMessageMediaPoll : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0x4bd6e798;
            }
        }

        [MTParameter(Order = 0)]
        public MTProto.NET.Schema.TL.TLPoll Poll { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.TL.TLPollResults Results { get; set; }


    }
}
