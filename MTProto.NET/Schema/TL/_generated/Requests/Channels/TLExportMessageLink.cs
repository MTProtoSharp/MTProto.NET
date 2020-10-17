using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Channels
{
    [MTObject(0xceb77163)]
    public class TLExportMessageLink : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0xceb77163;
            }
        }

        [MTParameter(Order = 0)]
        public TLAbsInputChannel Channel { get; set; }
        [MTParameter(Order = 1)]
        public int Id { get; set; }
        [MTParameter(Order = 2)]
        public bool Grouped { get; set; }


    }
}
