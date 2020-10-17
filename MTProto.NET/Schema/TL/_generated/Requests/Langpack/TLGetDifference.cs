using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Langpack
{
    [MTObject(0xcd984aa5)]
    public class TLGetDifference : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xcd984aa5;
            }
        }

        [MTParameter(Order = 0)]
        public string LangPack { get; set; }
        [MTParameter(Order = 1)]
        public string LangCode { get; set; }
        [MTParameter(Order = 2)]
        public int FromVersion { get; set; }


    }
}
