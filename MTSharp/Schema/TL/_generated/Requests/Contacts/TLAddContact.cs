using MTSharp.Attributes;
using MTSharp.Enums;

namespace MTSharp.Schema.TL.Requests.Contacts
{
    [MTObject(0xe8f463d0)]
    public class TLAddContact : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe8f463d0;
            }
        }

        [MTParameter(Order = 0)]
        public int Flags { get; set; }
        [MTParameter(Order = 1, FromFlag = 0, FlagType = FlagType.True)]
        public bool AddPhonePrivacyException { get; set; }
        [MTParameter(Order = 2)]
        public TLAbsInputUser Id { get; set; }
        [MTParameter(Order = 3)]
        public string FirstName { get; set; }
        [MTParameter(Order = 4)]
        public string LastName { get; set; }
        [MTParameter(Order = 5)]
        public string Phone { get; set; }


    }
}