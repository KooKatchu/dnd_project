import React from "react";

const Rogue = () => {
    const img = 'https://litrpgreads.com/wp-content/uploads/2023/10/dnd-rogue.jpg';
    return (
    <div className = "profileInfo">
        <img src = "../Images/rogue.jpg" className = "characterPic" alt = "A Rogue" />
        
        <h1>The Rogue</h1>

        <p>In Dungeons & Dragons (D&D), the Wizard is a spellcasting class renowned for their scholarly pursuit of arcane knowledge and mastery of spellcasting. Wizards rely on their intelligence and study to harness the magical forces of the universe. They possess a spellbook, a carefully curated collection of spells that they can prepare and cast.</p>
        
        <p>Wizards are known for their versatility, as they can choose from a vast array of spells, ranging from offensive and defensive spells to utility and control magic. Unlike some other spellcasting classes, wizards have the ability to learn and transcribe new spells into their spellbook, allowing them to continually expand their magical repertoire.</p>
        
        <p>Wizards are often depicted as the archetypal magic-users, with a deep understanding of the arcane arts and the ability to shape reality through the casting of spells. They play a crucial role in a party, providing powerful magical support and often serving as the primary source of arcane firepower.</p>

    </div>
    );
};
export default Rogue;