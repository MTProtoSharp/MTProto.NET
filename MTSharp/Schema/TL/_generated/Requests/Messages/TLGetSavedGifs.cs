using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Messages
{
    [MTObject(0x83bf3d52)]
    public class TLGetSavedGifs : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x83bf3d52;
            }
        }

        [MTParameter(Order = 0)]
        public int Hash { get; set; }


    }
}
