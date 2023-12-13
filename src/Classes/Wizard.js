import React, { useState, useEffect } from "react";

// const use = (item) => {
//   console.log(`Using ${item.name}`);
//   // Add your logic for using the item here
// };

const Wizard = () => {
  
  const [wizardSpells, setWizardSpells] = useState([]);
  const [wizardCantrips, setwizardCantrips] = useState([]);
  const [wizardBonus, setWizardBonus] = useState([]);
  const [playerWeapons, setPlayerWeapons] = useState([]);

    // Define weaponModifier function
    // const weaponModifier = (damageDie) => {
    //     // Add your logic for modifying weapons here
    //     console.log(`Applying modifier for damage die: ${damageDie}`);
    //   };

  useEffect(() => {
    const fetchData = async () => {
      try {
        const cantrips = await fetch("cantrips.json");
        const cantripsData = await cantrips.json();

        // Filter cantrips for the wizard class
        const wizardCantrips = cantripsData.filter(cantrip => cantrip.classes.includes("Wizard"));
        setwizardCantrips(wizardCantrips);

        const spell = await fetch("spells.json");
        const spellData = await spell.json();

        const wizardSpells = spellData.filter(spell => spell.classes.includes("Wizard"));
        setWizardSpells(wizardSpells);


        const bonus = await fetch("bonus.json");
        const bonusData = await bonus.json();
        const wizardBonus = bonusData.filter(bonus => bonus.class.includes("Wizard"));
        setWizardBonus(wizardBonus);

        const weapons = await fetch("weapons.json");
        const weaponsData = await weapons.json();
        setPlayerWeapons(weaponsData);

        console.log("cantrips: ", cantripsData);
        console.log("spells: ", spellData);
        console.log("weapons", weaponsData);
      } catch (error) {
        console.error("Error fetching info:", error);
      }
    };

    fetchData();
  }, []);
    const img = 'https://www.wargamer.com/wp-content/sites/wargamer/2022/01/dnd-wizard-5e.jpg';
    return (
    <div className = "profileInfo">
        <img src = "../Images/wizard.jpg" className = "characterPic" alt = "A Wizard" />
        
        <h1>The Wizard</h1>

        <p>In Dungeons & Dragons (D&D), the Wizard is a spellcasting class renowned for their scholarly pursuit of arcane knowledge and mastery of spellcasting. Wizards rely on their intelligence and study to harness the magical forces of the universe. They possess a spellbook, a carefully curated collection of spells that they can prepare and cast.</p>
        
        <p>Wizards are known for their versatility, as they can choose from a vast array of spells, ranging from offensive and defensive spells to utility and control magic. Unlike some other spellcasting classes, wizards have the ability to learn and transcribe new spells into their spellbook, allowing them to continually expand their magical repertoire.</p>
        
        <p>Wizards are often depicted as the archetypal magic-users, with a deep understanding of the arcane arts and the ability to shape reality through the casting of spells. They play a crucial role in a party, providing powerful magical support and often serving as the primary source of arcane firepower.</p>

        <h3>Wizard actions:</h3>

        <div id="actions">
        <h3>Spells</h3>
            <div id="spellsInfo">
              <table id="spellsTable">
                  <thead>
                  <tr>
                    <th>Name</th>
                    <th>Level</th>
                    <th>Description</th>
                    <th>School</th>
                    <th>Range</th>
                  </tr>
                  </thead>
                  <tbody>
                  {wizardSpells.map(spell => (
                    <tr key={spell.spellID} className="actionRow">
                      <td className="name">{spell.name}</td>
                      <td className="level">{spell.level}</td>
                      <td className="desc">{spell.description}</td>
                      <td className="school">{spell.school}</td>
                      <td className="range">{spell.range}</td>
                    </tr>
                  ))}
                  </tbody>
              </table>
            </div>  

          <h3>Cantrips</h3>
            <div id="cantripInfo">
              <table id="cantripsTable">
                  <thead>
                  <tr>
                      <th>Name</th>
                      <th>Description</th>
                      <th>School</th>
                      <th>Range</th>
                  </tr>
                  </thead>
                  <tbody>
                  {wizardCantrips.map(cantrip => (
                      <tr key={cantrip.cantripID} className="actionRow">
                      <td className="name">{cantrip.name}</td>
                      <td className="desc">{cantrip.description}</td>
                      <td className="school">{cantrip.school}</td>
                      <td className="range">{cantrip.range}</td>
                      </tr>
                  ))}
                  </tbody>
              </table>
              </div>
              
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
                    {wizardBonus.map(bonus => (
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
export default Wizard;