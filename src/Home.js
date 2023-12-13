import React from "react";

const Home = () => {
    const defaultImg = 'https://as1.ftcdn.net/v2/jpg/04/00/12/44/1000_F_400124497_OHvJPuRwdRgeewq5OvCSa0sPHbhUstg6.jpg';

    return (
        <div className = "profileInfo">
            <img src = {defaultImg} className = "characterPic" alt = "A Dragon" />
            <p>Will you harness the arcane powers of a wizard, expertly navigate shadows as a rogue, or embrace the primal strength of a barbarian? The options are as diverse as the characters you can become. Delve into the details of each class, from the graceful bards to the stalwart paladins, and discover the unique abilities and stories that await. It's time to explore the rich tapestry of roles and possibilities—choose your class and immerse yourself in a world where adventure knows no bounds.</p>

        </div>
    );
};

export default Home;
