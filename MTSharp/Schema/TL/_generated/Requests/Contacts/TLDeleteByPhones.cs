using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Contacts
{
    [MTObject(0x1013fd9e)]
    public class TLDeleteByPhones : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1013fd9e;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<string> Phones { get; set; }


    }
}
