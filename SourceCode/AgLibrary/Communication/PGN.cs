using System;
using System.Runtime.Serialization;

namespace AgLibrary.Communication
{
    public abstract class PGN
    {
        public static PGN Deserialize(byte pgnValue, byte[] data)
        {
            switch (pgnValue)
            {
                case 0xD6:
                    return PGN_D6.Deserialize(data);
                case 0xDD:
                    return PGN_DD.Deserialize(data);
                default:
                    throw new SerializationException($"Unknown PGN value {pgnValue}");
            }
        }

        public (byte pgnValue, byte[] pgnData) Serialize()
        {
            if (this is PGN_D6 pgn_d6)
                return (0xDD, pgn_d6.Serialize());
            if (this is PGN_DD pgn_dd)
                return (0xDD, pgn_dd.Serialize());
            else
                throw new InvalidOperationException($"Unknown PGN type {GetType()}");
        }
    }
}