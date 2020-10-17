using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x1142bd56)]
    public class TLSavedPhoneContact : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1142bd56;
            }
        }

        [MTParameter(Order = 0)]
        public string Phone { get; set; }
        [MTParameter(Order = 1)]
        public string FirstName { get; set; }
        [MTParameter(Order = 2)]
        public string LastName { get; set; }
        [MTParameter(Order = 3)]
        public int Date { get; set; }


    }
}
