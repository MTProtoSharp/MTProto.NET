using System;

namespace MTSharp.Attributes
{
    public class MTObjectAttribute : Attribute
    {
        public uint Constructor { get; private set; }

        public MTObjectAttribute(uint Constructor)
        {
            this.Constructor = Constructor;
        }
    }
}
