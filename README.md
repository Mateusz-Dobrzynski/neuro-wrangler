# Neuro Wrangler
## What is Neuro Wrangler?
Neuro Wrangler (temporary name) allows to navigate convoluted mechanics of tabletop RPG _Neuroshima_. It is meant to be a tool which Game Masters can use to run battles with greater efficiency. _Neuroshima_ has numerous, complex mechanics and managing all of them can be a daunting task. Neuro Wrangler is designed to make it easier.  
## Roadmap
- [ ] Storing data about a character
	- [ ] Stats and abilities
	- [ ] Penalties for every ability
	- [ ] Equipment
	- [ ] Creatures other than humans?
	- [ ] Background traits and profession traits?
	- [ ] Saving creatures as `.json` files
- [ ] Ability checks
	- [ ] Basic ability check (bool)
	- [ ] Open ability checks (numerical score)
	- [ ] Ability contests (winner or draw)
- [ ]  Calculating roll disadvantage when using firearms
	- [ ] Distance to the target
	- [ ] Penalties of the shooter
	- [ ] Cover
	- [ ] Weapon type
	- [ ] Armor of the target
- [ ] Battle manager
	- [ ] Interactive battle map
		- [ ] Map is represented by a [[graph]]
		- [ ] Every node contains information about terrain elevation, occupation and whether it's a difficult terrain or not
	- [ ] Initiative queue according to an original _Neuroshima_ concept - 3 single-segment actions will be performed faster than one triple-segment action
	- [ ] Calculating roll disadvantage according to characters' placement on the battle map and simulating rolls
- [ ] Modyfikatory koloru
	- [ ] Steel
		- [ ] Critical wound gives no chance for recovery
	- [ ] Rust
	- [ ] Mercury
	- [ ] Chrome

## Class dependencies structure

```
Creature.cs
  string name
  int xpEarned
  int xpExpended
  int xpTotal
  string backgroundTrait
  string proffessionTrait
  bool alive
  int maxHealth
  int[,] coordinatesPosition
  string posture
  int segmentsRemaining
  abilities
  equipment
  wounds
  Damage()
  Heal()
  Attack()
  Move()
  DropItems()
  EquipItem()
  UnequipItem()
  Peek()
  Kneel()
  Crawl()
  TakeCover()
  SpotEnemy()
  Throw()
  UnlockWeapon()

  Human.cs
    string codename
    string surname
  Machine.cs
  Beast.cs

Item.cs
  string name
  string gamblingType
  UseItem()
  Armor.cs
    int tier
    int strength
  Weapon.cs
    int requiredConstitution
    MeleWeapon.cs
      bool throwable
      int[] damage
    Firearm.cs
      int clipSize
      int damage
      int armorPenetration
      int shootingTime
      int reloadTime
      string firearmType
    Grenade.cs
Stat.cs
  int penalty
  int value
  
Ability(Stat)
  baseStat
  int penalty
  int value

Wound.cs
  string severity
  int penalty

BattleMap.cs
  int[,] coordinates
  Location.cs
    occupation
    level
    items
```