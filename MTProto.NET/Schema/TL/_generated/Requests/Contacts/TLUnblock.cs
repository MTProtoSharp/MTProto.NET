using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Contacts
{
    [MTObject(0xe54100bd)]
    public class TLUnblock : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe54100bd;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputUser Id { get; set; }


    }
}
