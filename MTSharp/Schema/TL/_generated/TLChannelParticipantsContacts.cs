using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xbb6ae88d)]
    public class TLChannelParticipantsContacts : TLAbsChannelParticipantsFilter
    {
        public override uint Constructor
        {
            get
            {
                return 0xbb6ae88d;
            }
        }

        [MTParameter(Order = 0)]
        public string Q { get; set; }


    }
}
