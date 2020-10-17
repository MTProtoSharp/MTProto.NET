using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xb4608969)]
    public class TLChannelParticipantsAdmins : TLAbsChannelParticipantsFilter
    {
        public override uint Constructor
        {
            get
            {
                return 0xb4608969;
            }
        }



    }
}
