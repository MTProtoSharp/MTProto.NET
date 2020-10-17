using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Messages
{
    [MTObject(0x32ca8f91)]
    public class TLGetWebPage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x32ca8f91;
            }
        }

        [MTParameter(Order = 0)]
        public string Url { get; set; }
        [MTParameter(Order = 1)]
        public int Hash { get; set; }


    }
}
