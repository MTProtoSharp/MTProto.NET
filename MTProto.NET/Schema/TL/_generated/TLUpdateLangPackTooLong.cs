using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x46560264)]
    public class TLUpdateLangPackTooLong : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x46560264;
            }
        }

        [MTParameter(Order = 0)]
        public string LangCode { get; set; }


    }
}
