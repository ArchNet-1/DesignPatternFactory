namespace ArchNet.Design.Pattern.Factory
{
    /// <summary>
    /// [MODULE] - [ARCH NET] - [DESIGN PATTERN] - Factory ( Abstract Model )
    /// author : LOUIS PAKEL
    /// </summary>
    public abstract class AbstractModel
    {
        // Properties example type of string
        public abstract string StringType { get; }

        // Properties example type of int
        public abstract int IntType { get; set; }

        // Properties example type of float
        public abstract float FloatType { get; set; }

        // Properties example type of bool
        public abstract bool BoolType { get; set; }

        // Properties example type of double
        public abstract double DoubleType { get; set; }

        // Properties example type of ushort
        public abstract ushort UShortType { get; set; }
    }
}
