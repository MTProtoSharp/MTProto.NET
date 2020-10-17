using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Photos
{
    [MTObject(0x8dca6aa5)]
    public class TLPhotos : TLAbsPhotos
    {
        public override uint Constructor
        {
            get
            {
                return 0x8dca6aa5;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsPhoto> Photos { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
