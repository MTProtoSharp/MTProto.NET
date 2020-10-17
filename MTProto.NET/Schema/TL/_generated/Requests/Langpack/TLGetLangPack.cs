using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Langpack
{
    [MTObject(0xf2f2330a)]
    public class TLGetLangPack : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xf2f2330a;
            }
        }

        [MTParameter(Order = 0)]
        public string LangPack { get; set; }
        [MTParameter(Order = 1)]
        public string LangCode { get; set; }


    }
}
