using MTProto.NET.Attributes;

namespace MTProto.NET.Schema.TL.Requests.Help
{
    [MTObject(0x77fa99f)]
    public class TLDismissSuggestion : MTObject
    {
        public override uint Constructor
        {
            get
            {
                return 0x77fa99f;
            }
        }

        [MTParameter(Order = 0)]
        public string Suggestion { get; set; }


    }
}
