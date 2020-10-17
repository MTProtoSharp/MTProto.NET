using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Langpack
{
    [MTObject(0x6a596502)]
    public class TLGetLanguage : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x6a596502;
            }
        }

        [MTParameter(Order = 0)]
        public string LangPack { get; set; }
        [MTParameter(Order = 1)]
        public string LangCode { get; set; }


    }
}
