import React from "react";

const Fighter = () => {
    const img = 'https://static1.cbrimages.com/wordpress/wp-content/uploads/2023/08/two-different-dnd-fighters.jpg';

    return (
        <div className = "profileInfo">
            <img src = "../Images/fighter.jpg" className = "characterPic" alt = "A Fighter" />
            
            <h1>The Fighter</h1>
            <p>In Dungeons & Dragons (D&D), a Bard is a versatile and charismatic character class known for their proficiency in both magic and musical abilities. Bards are skilled performers, storytellers, and spellcasters, drawing upon the power of their artistic talents to cast spells and inspire their allies.</p>
            
            <p>They have a unique blend of skills, including musical performance, knowledge of various subjects, and the ability to charm and manipulate others through their charisma. Bards can choose from different Bardic Colleges, each emphasizing a particular aspect of their abilities, such as combat prowess, magical knowledge, or the power of inspiration.</p>
            
            <p>With a wide range of spells and a knack for improvisation, Bards are often seen as the entertainers of the adventuring party, providing both support and a touch of flair to the group's endeavors.</p>
        </div>
    );
};
export default Fighter;
