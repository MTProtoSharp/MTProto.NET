using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL
{
    [MTObject(0x4f11bae1)]
    public class TLUserProfilePhotoEmpty : TLAbsUserProfilePhoto
    {
        public override uint Constructor
        {
            get
            {
                return 0x4f11bae1;
            }
        }



    }
}
