# Neuro Wrangler
## What is Neuro Wrangler?
Neuro Wrangler (temporary name) allows to navigate convoluted mechanics of tabletop RPG _Neuroshima_. It is meant to be a tool which Game Masters can use to run battles with greater efficiency. _Neuroshima_ has numerous, complex mechanics and managing all of them can be a daunting task. Neuro Wrangler is designed to make it easier.
## Roadmap
- [ ] Storing data about a character
	- [x] Stats and abilities
	- [x] Penalties for every ability
	- [ ] Equipment
	- [x] Creatures other than humans
	- [x] Background traits and profession traits
	- [ ] Saving creatures as `.json` files
- [ ] Ability checks
	- [x] Basic ability check (bool)
	- [x] Open ability checks (numerical score)
	- [x] Ability contests (winner or draw)
- [ ]  Calculating roll disadvantage when using firearms
	- [ ] Distance to the target
	- [ ] Penalties of the shooter
	- [ ] Cover
	- [ ] Weapon type
	- [ ] Armor of the target
- [ ] Battle manager
	- [ ] Interactive battle map
		- [ ] Map is represented by a graph
		- [ ] Every node contains information about terrain elevation, occupation and whether it's a difficult terrain or not
	- [ ] Initiative queue according to an original _Neuroshima_ concept - 3 single-segment actions will be performed faster than one triple-segment action
	- [ ] Calculating roll disadvantage according to characters' placement on the battle map and simulating rolls
- [ ] Modyfikatory koloru
	- [ ] Steel
		- [ ] Critical wound gives no chance for recovery
	- [ ] Rust
	- [ ] Mercury
	- [ ] Chrome