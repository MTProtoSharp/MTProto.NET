using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x12b9417b)]
    public class TLUpdateUserPhone : TLAbsUpdate
    {
        public override uint Constructor
        {
            get
            {
                return 0x12b9417b;
            }
        }

        [MTParameter(Order = 0)]
        public int UserId { get; set; }
        [MTParameter(Order = 1)]
        public string Phone { get; set; }


    }
}
