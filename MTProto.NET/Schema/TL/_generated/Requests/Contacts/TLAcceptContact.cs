using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Contacts
{
    [MTObject(0xf831a20f)]
    public class TLAcceptContact : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf831a20f;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputUser Id { get; set; }


    }
}
