using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x22e24e22)]
    public class TLGetDialogUnreadMarks : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x22e24e22;
            }
        }



    }
}
