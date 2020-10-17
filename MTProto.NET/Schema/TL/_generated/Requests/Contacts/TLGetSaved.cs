using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Contacts
{
    [MTObject(0x82f1e39f)]
    public class TLGetSaved : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x82f1e39f;
            }
        }



    }
}
