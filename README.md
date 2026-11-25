<p align="center">
  <a href="https://archnet-plateform.fr"><img src="https://archnet-plateform.fr/ArchNetLogoWithBck.png" alt="ArchNet" width="240"></a>
</p>

# ArchNet · Factory Pattern

Creates objects from a key without the calling code knowing their concrete type: Factory<TKey, TProduct>.

- Unity **6000.0** or newer · No dependency.
- Part of [ArchNet](https://archnet-plateform.fr), free and open-source Unity packages

## Install

*Window > Package Manager > + > Install package from git URL…*

```
https://github.com/ArchNet-1/DesignPatternFactory.git
```

## Use

```csharp
using ArchNet.DesignPattern;

var weapons = new Factory<WeaponType, IWeapon>()
    .Register(WeaponType.Sword, () => new Sword())
    .Register(WeaponType.Bow, () => new Bow());
IWeapon bow = weapons.Create(WeaponType.Bow);
```

Import the **Weapon Factory** sample for a full example.

## License

See [LICENSE.md](LICENSE.md).
