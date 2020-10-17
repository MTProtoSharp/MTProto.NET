using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Auth
{
    [MTObject(0x4ea56e92)]
    public class TLRecoverPassword : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x4ea56e92;
            }
        }

        [MTParameter(Order = 0)]
        public string Code { get; set; }


    }
}
