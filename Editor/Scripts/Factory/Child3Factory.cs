namespace ArchNet.Design.Pattern.Factory
{
    /// <summary>
    /// [MODULE] - [ARCH NET] - [DESIGN PATTERN] - Factory ( Child Factory )
    /// author : LOUIS PAKEL
    /// </summary>
    public class Child3Factory : ChildFactory
    {
        #region Private Fields

        private bool _boolType;
        private int _intType;
        private double _doubleType;
        private ushort _uShortType;
        private float _floatType;

        #endregion

        /// <summary>
        /// Description : Constructor Factory
        /// </summary>
        /// <param name="pBoolType"></param>
        /// <param name="pIntType"></param>
        /// <param name="pDoubleType"></param>
        /// <param name="pUShortType"></param>
        /// <param name="pFloatType"></param>
        public Child3Factory(bool pBoolType, int pIntType, double pDoubleType, ushort pUShortType, float pFloatType)
        {
            _intType = pIntType;
            _boolType = pBoolType;
            _doubleType = pDoubleType;
            _uShortType = pUShortType;
            _floatType = pFloatType;
        }

        /// <summary>
        /// Description : Get Model type of ChilModel3
        /// </summary>
        /// <returns></returns>
        public override AbstractModel GetModel()
        {
            return new ChildModel3(_boolType, _intType, _doubleType, _uShortType, _floatType);
        }
    }
}
