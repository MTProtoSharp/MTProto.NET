using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Help
{
    [MTObject(0xc661ad08)]
    public class TLGetPassportConfig : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc661ad08;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }


    }
}
