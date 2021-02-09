using UnityEngine;

namespace ArchNet.Design.Pattern.Factory
{
    /// <summary>
    /// [MODULE] - [ARCH NET] - [DESIGN PATTERN] - Factory ( Example )
    /// author : LOUIS PAKEL
    /// </summary>
    public class Example : MonoBehaviour
    {
        public void Start()
        {
            ChildFactory factory = null;

            string lChildName = "ChildModel1";

            switch (lChildName)
            {
                case "ChildModel1":
                    factory = new Child1Factory(true, 0, 0, 0, 0.0f);
                    break;
                case "ChildModel2":
                    factory = new Child2Factory(true, 0, 0, 0, 0.0f);
                    break;
                case "ChildModel3":
                    factory = new Child3Factory(true, 0, 0, 0, 0.0f); ;
                    break;
                default:
                    break;
            }

            AbstractModel abstractModel = factory.GetModel();
        }

    }
}
