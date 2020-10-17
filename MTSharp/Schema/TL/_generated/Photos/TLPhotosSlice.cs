using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Photos
{
    [MTObject(0x15051f54)]
    public class TLPhotosSlice : TLAbsPhotos
    {
        public override uint Constructor
        {
            get
            {
                return 0x15051f54;
            }
        }

        [MTParameter(Order = 0)]
        public int Count { get; set; }
        [MTParameter(Order = 1)]
        public TLVector<TLAbsPhoto> Photos { get; set; }
        [MTParameter(Order = 2)]
        public TLVector<TLAbsUser> Users { get; set; }


    }
}
