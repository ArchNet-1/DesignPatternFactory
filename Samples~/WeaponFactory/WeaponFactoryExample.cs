// ArchNet · Factory Pattern — sample
// Add this component to a GameObject and press Play: it builds each weapon from its type
// and logs it. The calling code only knows IWeapon, never Sword or Bow.
// Docs: https://archnet-plateform.fr/#DesignPatternFactory

using ArchNet.DesignPattern;
using UnityEngine;

namespace ArchNet.Samples.Factory
{
    public enum WeaponType { Sword, Bow }

    public interface IWeapon
    {
        string Name { get; }
        int Damage { get; }
    }

    public class Sword : IWeapon
    {
        public string Name => "Sword";
        public int Damage => 12;
    }

    public class Bow : IWeapon
    {
        public string Name => "Bow";
        public int Damage => 8;
    }

    public class WeaponFactoryExample : MonoBehaviour
    {
        readonly Factory<WeaponType, IWeapon> _weapons = new Factory<WeaponType, IWeapon>()
            .Register(WeaponType.Sword, () => new Sword())
            .Register(WeaponType.Bow, () => new Bow());

        void Start()
        {
            foreach (WeaponType type in _weapons.Keys)
            {
                IWeapon weapon = _weapons.Create(type);
                Debug.Log($"{type} -> {weapon.Name} ({weapon.Damage} damage)");
            }
        }
    }
}
