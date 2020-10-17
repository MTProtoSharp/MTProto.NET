using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Contacts
{
    [MTObject(0x8514bdda)]
    public class TLToggleTopPeers : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8514bdda;
            }
        }

        [MTParameter(Order = 0)]
        public bool Enabled { get; set; }


    }
}
