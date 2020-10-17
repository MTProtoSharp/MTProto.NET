using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xfc2e05bc)]
    public class TLChatInviteExported : TLAbsExportedChatInvite
    {
        public override uint Constructor
        {
            get
            {
                return 0xfc2e05bc;
            }
        }

        [MTParameter(Order = 0)]
        public string Link { get; set; }


    }
}
