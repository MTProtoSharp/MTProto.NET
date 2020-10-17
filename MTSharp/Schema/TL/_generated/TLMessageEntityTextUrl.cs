using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x76a6d327)]
    public class TLMessageEntityTextUrl : TLAbsMessageEntity
    {
        public override uint Constructor
        {
            get
            {
                return 0x76a6d327;
            }
        }

        [MTParameter(Order = 0)]
        public int Offset { get; set; }
        [MTParameter(Order = 1)]
        public int Length { get; set; }
        [MTParameter(Order = 2)]
        public string Url { get; set; }


    }
}
