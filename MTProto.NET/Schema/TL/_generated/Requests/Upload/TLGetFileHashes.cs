using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Upload
{
    [MTObject(0xc7025931)]
    public class TLGetFileHashes : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xc7025931;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputFileLocation Location { get; set; }
        [MTParameter(Order = 1)]
        public int Offset { get; set; }


    }
}
