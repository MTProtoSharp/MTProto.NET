using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Contacts
{
    [MTObject(0x2caa4a42)]
    public class TLGetContactIDs : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x2caa4a42;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }


    }
}
