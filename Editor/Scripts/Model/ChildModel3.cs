namespace ArchNet.Design.Pattern.Factory
{
    /// <summary>
    /// [MODULE] - [ARCH NET] - [DESIGN PATTERN] - Factory ( Child Model )
    /// author : LOUIS PAKEL
    /// </summary>
    public class ChildModel3 : AbstractModel
    {
        #region Private Fields

        private readonly string _stringType;
        private bool _boolType;
        private int _intType;
        private double _doubleType;
        private ushort _uShortType;
        private float _floatType;

        #endregion

        /// <summary>
        /// Description : Constructor 
        /// </summary>
        /// <param name="pBoolType"></param>
        /// <param name="pStringType"></param>
        /// <param name="pIntType"></param>
        /// <param name="pDoubleType"></param>
        /// <param name="pUShortType"></param>
        /// <param name="pFloatType"></param>
        public ChildModel3(bool pBoolType, int pIntType, double pDoubleType, ushort pUShortType, float pFloatType)
        {
            _stringType = "ChildModel3";
            _boolType = pBoolType;
            _intType = pIntType;
            _doubleType = pDoubleType;
            _uShortType = pUShortType;
            _floatType = pFloatType;
        }

        #region Properties

        public override string StringType
        {
            get { return _stringType; }
        }

        public override int IntType
        {
            get { return _intType; }
            set { _intType = value; }
        }
        public override float FloatType
        {
            get { return _floatType; }
            set { _floatType = value; }
        }

        public override bool BoolType
        {
            get { return _boolType; }
            set { _boolType = value; }
        }
        public override double DoubleType
        {
            get { return _doubleType; }
            set { _doubleType = value; }
        }

        public override ushort UShortType
        {
            get { return _uShortType; }
            set { _uShortType = value; }
        }

        #endregion
    }
}
