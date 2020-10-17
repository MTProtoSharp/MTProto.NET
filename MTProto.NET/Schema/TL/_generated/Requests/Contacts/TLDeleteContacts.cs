using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Contacts
{
    [MTObject(0x96a0e00)]
    public class TLDeleteContacts : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x96a0e00;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsInputUser> Id { get; set; }


    }
}
