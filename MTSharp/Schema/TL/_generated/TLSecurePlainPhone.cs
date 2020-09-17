using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x7d6099dd)]
    public class TLSecurePlainPhone : TLAbsSecurePlainData
    {
        public override uint Constructor
        {
            get
            {
                return 0x7d6099dd;
            }
        }

        [MTParameter(Order = 0)]
        public string Phone { get; set; }


    }
}
