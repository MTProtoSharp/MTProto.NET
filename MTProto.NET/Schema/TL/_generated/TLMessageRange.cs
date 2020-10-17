using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xae30253)]
    public class TLMessageRange : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xae30253;
            }
        }

        [MTParameter(Order = 0)]
        public int MinId { get; set; }
        [MTParameter(Order = 1)]
        public int MaxId { get; set; }


    }
}
