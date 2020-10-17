using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x47a971e0)]
    public class TLStatsURL : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x47a971e0;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }


    }
}
