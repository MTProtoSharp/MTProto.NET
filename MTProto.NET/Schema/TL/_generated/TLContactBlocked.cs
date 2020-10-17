using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x561bc879)]
    public class TLContactBlocked : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x561bc879;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public int Date { get; set; }


    }
}
