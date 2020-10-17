using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Contacts
{
    [MTObject(0x332b49fc)]
    public class TLBlock : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x332b49fc;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputUser Id { get; set; }


    }
}
