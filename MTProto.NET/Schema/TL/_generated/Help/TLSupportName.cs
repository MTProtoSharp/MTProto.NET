using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Help
{
    [MTObject(0x8c05f1c9)]
    public class TLSupportName : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x8c05f1c9;
            }
        }

        [MTParameter(Order = 0)]
        public string Name { get; set; }


    }
}
