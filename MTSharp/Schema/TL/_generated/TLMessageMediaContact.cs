using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xcbf24940)]
    public class TLMessageMediaContact : TLAbsMessageMedia
    {
        public override uint Constructor
        {
            get
            {
                return 0xcbf24940;
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
        [MTParameter(Order = 4)]
        public int UserId { get; set; }


    }
}
