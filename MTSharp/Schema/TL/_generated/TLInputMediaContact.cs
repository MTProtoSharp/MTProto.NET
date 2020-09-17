using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xf8ab7dfb)]
    public class TLInputMediaContact : TLAbsInputMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xf8ab7dfb;
            }
        }

        [MTParameter(Order = 0)]
        public string PhoneNumber { get; set; }
        [MTParameter(Order = 1)]
        public string FirstName { get; set; }
        [MTParameter(Order = 2)]
        public string LastName { get; set; }
        [MTParameter(Order = 3)]
        public string Vcard { get; set; }


    }
}
