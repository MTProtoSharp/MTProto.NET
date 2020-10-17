using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Channels
{
    [MTObject(0xf0173fe9)]
    public class TLChannelParticipantsNotModified : TLAbsChannelParticipants
    {
        public override uint Constructor
        {
            get
            {
                return 0xf0173fe9;
            }
        }



    }
}
