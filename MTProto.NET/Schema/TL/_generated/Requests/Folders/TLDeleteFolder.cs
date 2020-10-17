using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Folders
{
    [MTObject(0x1c295881)]
    public class TLDeleteFolder : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x1c295881;
            }
        }

        [MTParameter(Order = 0)]
        public int FolderId { get; set; }


    }
}
