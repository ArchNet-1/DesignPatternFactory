// ArchNet · Factory Pattern
// Creates objects from a key (an enum, a string, an id…) without the calling code knowing
// their concrete type. Register one creation function per key, then call Create(key).
// Import the "Weapon Factory" sample from the Package Manager for a full example.
// Docs: https://archnet-plateform.fr/#DesignPatternFactory

using System;
using System.Collections.Generic;

namespace ArchNet.DesignPattern
{
    /// <summary>
    /// Builds a <typeparamref name="TProduct"/> from a key.
    /// <code>
    /// var weapons = new Factory&lt;WeaponType, IWeapon&gt;()
    ///     .Register(WeaponType.Sword, () =&gt; new Sword())
    ///     .Register(WeaponType.Bow, () =&gt; new Bow());
    /// IWeapon weapon = weapons.Create(WeaponType.Bow);
    /// </code>
    /// </summary>
    public class Factory<TKey, TProduct>
    {
        readonly Dictionary<TKey, Func<TProduct>> _creators = new Dictionary<TKey, Func<TProduct>>();

        /// <summary>The keys that can be created.</summary>
        public IEnumerable<TKey> Keys => _creators.Keys;

        /// <summary>Sets how to build the product for this key (replaces any previous one).</summary>
        public Factory<TKey, TProduct> Register(TKey key, Func<TProduct> creator)
        {
            _creators[key] = creator ?? throw new ArgumentNullException(nameof(creator));
            return this;
        }

        public bool CanCreate(TKey key) => _creators.ContainsKey(key);

        /// <summary>Builds the product for this key. Throws when the key was never registered.</summary>
        public TProduct Create(TKey key)
        {
            if (!_creators.TryGetValue(key, out Func<TProduct> creator))
                throw new KeyNotFoundException($"[ArchNet] Factory has nothing registered for '{key}'.");
            return creator();
        }

        /// <summary>Builds the product for this key, or returns false when the key was never registered.</summary>
        public bool TryCreate(TKey key, out TProduct product)
        {
            bool found = _creators.TryGetValue(key, out Func<TProduct> creator);
            product = found ? creator() : default;
            return found;
        }
    }
}
