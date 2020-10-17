using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Help
{
    [MTObject(0x38a08d3)]
    public class TLGetUserInfo : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x38a08d3;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputUser UserId { get; set; }


    }
}
