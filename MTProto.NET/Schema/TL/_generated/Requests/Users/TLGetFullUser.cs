using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Users
{
    [MTObject(0xca30a5b1)]
    public class TLGetFullUser : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xca30a5b1;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputUser Id { get; set; }


    }
}
