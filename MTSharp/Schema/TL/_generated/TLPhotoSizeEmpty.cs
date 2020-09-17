using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0xe17e23c)]
    public class TLPhotoSizeEmpty : TLAbsPhotoSize
    {
        public override uint Constructor
        {
            get
            {
                return 0xe17e23c;
            }
        }

        [MTParameter(Order = 0)]
        public string Type { get; set; }


    }
}
