using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x200250ba)]
    public class TLUserEmpty : TLAbsUser
    {
        public override uint Constructor
        {
            get
            {
                return 0x200250ba;
            }
        }

        [MTParameter(Order = 0)]
        public int Id { get; set; }


    }
}
