using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x21ec5a5f)]
    public class TLSecurePlainEmail : TLAbsSecurePlainData
    {
        public override uint Constructor
        {
            get
            {
                return 0x21ec5a5f;
            }
        }

        [MTParameter(Order = 0)]
        public string Email { get; set; }


    }
}
