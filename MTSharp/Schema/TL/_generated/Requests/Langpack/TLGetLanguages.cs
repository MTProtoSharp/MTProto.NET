using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Langpack
{
    [MTObject(0x42c6978f)]
    public class TLGetLanguages : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x42c6978f;
            }
        }

        [MTParameter(Order = 0)]
        public string LangPack { get; set; }


    }
}
