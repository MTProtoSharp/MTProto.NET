using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Help
{
    [MTObject(0xe3309f7f)]
    public class TLTermsOfServiceUpdateEmpty : TLAbsTermsOfServiceUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0xe3309f7f;
            }
        }

        [MTParameter(Order = 0)]
        public int Expires { get; set; }


    }
}
