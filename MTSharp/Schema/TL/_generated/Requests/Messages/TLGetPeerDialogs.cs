using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0xe470bcfd)]
    public class TLGetPeerDialogs : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xe470bcfd;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsInputDialogPeer> Peers { get; set; }


    }
}
