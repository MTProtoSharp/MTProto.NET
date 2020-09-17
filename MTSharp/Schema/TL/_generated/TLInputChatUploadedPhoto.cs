using MTSharp.Attributes;

namespace MTSharp.Schema.TL
{
    [MTObject(0x927c55b4)]
    public class TLInputChatUploadedPhoto : TLAbsInputChatPhoto
    {
        public override uint Constructor
        {
            get
            {
                return 0x927c55b4;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputFile File { get; set; }


    }
}
