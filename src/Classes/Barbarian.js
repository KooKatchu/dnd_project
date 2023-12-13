import React, { useState, useEffect } from "react";

// const use = (item) => {
//   console.log(`Using ${item.name}`);
//   // Add your logic for using the item here
// };

const Barbarian = () => {
  const [playerWeapons, setPlayerWeapons] = useState([]);
  const [barbarianBonus, setBarbarianBonus] = useState([]);

    // Define weaponModifier function
    // const weaponModifier = (damageDie) => {
    //     // Add your logic for modifying weapons here
    //     console.log(`Applying modifier for damage die: ${damageDie}`);
    //   };

  useEffect(() => {
    const fetchData = async () => {
      try {
        const weapons = await fetch("http://fb08.decoded.com:5090/api/actions/weapons");     
        const weaponsData = await weapons.json();
        setPlayerWeapons(weaponsData);

        const bonus = await fetch("http://fb08.decoded.com:5090/api/actions/bonus");
        const bonusData = await bonus.json();
        const barbarianBonus = bonusData.filter(bonus => bonus.class.includes("Barbarian"));
        setBarbarianBonus(barbarianBonus);

        console.log("weapons", weaponsData);
      } catch (error) {
        console.error("Error fetching info:", error);
      }
    };

    fetchData();
  }, []);

  return (
    <div className="profileInfo">
      <img
        src="../Images/barbarian.jpg"
        className="characterPic"
        alt="A barbarian"
      />

      <h1>The Barbarian</h1>

      <p>In Dungeons & Dragons (D&D), the barbarian is a spellcasting class renowned for their scholarly pursuit of arcane knowledge and mastery of spellcasting. barbarians rely on their intelligence and study to harness the magical forces of the universe. They possess a spellbook, a carefully curated collection of spells that they can prepare and cast.</p>

      <p>barbarians are known for their versatility, as they can choose from a vast array of spells, ranging from offensive and defensive spells to utility and control magic. Unlike some other spellcasting classes, barbarians have the ability to learn and transcribe new spells into their spellbook, allowing them to continually expand their magical repertoire.</p>

      <p>barbarians are often depicted as the archetypal magic-users, with a deep understanding of the arcane arts and the ability to shape reality through the casting of spells. They play a crucial role in a party, providing powerful magical support and often serving as the primary source of arcane firepower.</p>

      <h3>Barbarian actions:</h3>

      <div id="actions">
        <div id="bonusInfo">
          <h3>Bonus Actions</h3>
          <table id="bonusTable">
          <thead>
            <tr>
              <th>Name</th>
              <th>Description</th>
            </tr>
          </thead>
          <tbody>
              {barbarianBonus.map(bonus => (
                <tr key={bonus.weaponId} className="actionRow">
                  <td className="name">{bonus.name}</td>
                  <td className="desc">{bonus.description}</td>
                </tr>
              ))}
            </tbody>
          </table>
        </div>

                {/* <div id="weaponsInfo">
          <h3>Weapons</h3>
          <table id="weaponsTable">
            <thead>
              <tr>
                <th>Name</th>
                <th>Description</th>
                <th>Range</th>
                <th>Modifier</th>
              </tr>
            </thead>
            <tbody>
              {playerWeapons.map(weapon => (
                <tr key={weapon.weaponId} className="actionRow">
                  <td className="name">{weapon.name}</td>
                  <td className="desc">{weapon.description}</td>
                  <td className="range">{weapon.range}</td>
                  <td className="damageDie">{weapon.damageDice ? weapon.damageDice : 'N/A'}</td>
                  <td className="use">
                  {weapon.damage && (
                    <button type="button" id={`weaponUse_${weapon.weaponId}`} onClick={() => weaponModifier(weapon.die)}>
                    Add {weapon.damage}
                    </button>                          
                  )}
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        </div> */}
      </div>
    </div>
  );
};

export default Barbarian;
