using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Help
{
    [MTObject(0xa098d6af)]
    public class TLPassportConfig : TLAbsPassportConfig
    {
        public override uint Constructor
        {
            get
            {
                return 0xa098d6af;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.TL.TLDataJSON CountriesLangs { get; set; }


    }
}
