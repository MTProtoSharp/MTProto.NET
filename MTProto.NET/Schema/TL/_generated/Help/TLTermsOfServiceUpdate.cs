using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Help
{
    [MTObject(0x28ecf961)]
    public class TLTermsOfServiceUpdate : TLAbsTermsOfServiceUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x28ecf961;
            }
        }

        [MTParameter(Order = 0)]
        public int Expires { get; set; }
        [MTParameter(Order = 1)]
        public MTProto.NET.Schema.TL.Help.TLTermsOfService TermsOfService { get; set; }


    }
}
