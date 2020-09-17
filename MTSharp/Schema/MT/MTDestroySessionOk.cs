using MTSharp.Attributes;

namespace MTSharp.Schema.MT
{
    [MTObject(0xe22045fc)]
    public class MTDestroySessionOk : MTAbsDestroySessionRes
    {
        public override uint Constructor
        {
            get
            {
                return 0xe22045fc;
            }
        }

        [MTParameter(Order = 0)]
        public long SessionId { get; set; }


    }
}
