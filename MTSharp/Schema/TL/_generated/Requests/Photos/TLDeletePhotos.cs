using MTSharp.Attributes;

namespace MTSharp.Schema.TL.Requests.Photos
{
    [MTObject(0x87cf7f2f)]
    public class TLDeletePhotos : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x87cf7f2f;
            }
        }

        [MTParameter(Order = 0)]
        public TLVector<TLAbsInputPhoto> Id { get; set; }


    }
}
