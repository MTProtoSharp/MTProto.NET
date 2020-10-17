using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0xd072acb4)]
    public class TLRestrictionReason : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xd072acb4;
            }
        }

        [MTParameter(Order = 0)]
        public string Platform { get; set; }
        [MTParameter(Order = 1)]
        public string Reason { get; set; }
        [MTParameter(Order = 2)]
        public string Text { get; set; }


    }
}
