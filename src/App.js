// App.js
import './App.css';
// import { BrowserRouter as Router, Route, Link } from 'react-router-dom';
// import Presentation from './Presentation';
import React, { useState } from 'react';
import Home from './Home';
import Barbarian from './Classes/Barbarian';
import Bard from './Classes/Bard';
import Cleric from './Classes/Cleric';
import Druid from './Classes/Druid';
import Fighter from './Classes/Fighter';
import Monk from './Classes/Monk';
import Paladin from './Classes/Paladin';
import Ranger from './Classes/Ranger';
import Rogue from './Classes/Rogue';
import Sorcerer from './Classes/Sorcerer';
import Warlock from './Classes/Warlock';
import Wizard from './Classes/Wizard';



function App() {
  const [selectedClass, setSelectedClass] = useState('Home');

  const handleClassSelection = (className) => {
    setSelectedClass(className);
  };

  return (
    <div className="App">
      <header className="App-header">
        <div id="dndClasses">
          <button onClick={() => handleClassSelection('Barbarian')}>Barbarian</button>
          <button onClick={() => handleClassSelection('Bard')}>Bard</button>
          <button onClick={() => handleClassSelection('Cleric')}>Cleric</button>
          <button onClick={() => handleClassSelection('Druid')}>Druid</button>
          <button onClick={() => handleClassSelection('Fighter')}>Fighter</button>
          <button onClick={() => handleClassSelection('Monk')}>Monk</button>
          <button onClick={() => handleClassSelection('Paladin')}>Paladin</button>
          <button onClick={() => handleClassSelection('Ranger')}>Ranger</button>
          <button onClick={() => handleClassSelection('Rogue')}>Rogue</button>
          <button onClick={() => handleClassSelection('Sorcerer')}>Sorcerer</button>
          <button onClick={() => handleClassSelection('Warlock')}>Warlock</button>
          <button onClick={() => handleClassSelection('Wizard')}>Wizard</button>
        </div>

        <section id="profile">
          {selectedClass === 'Home' && <Home />}
          {selectedClass === 'Barbarian' && <Barbarian />}
          {selectedClass === 'Bard' && <Bard />}
          {selectedClass === 'Cleric' && <Cleric />}
          {selectedClass === 'Druid' && <Druid />}
          {selectedClass === 'Fighter' && <Fighter />}
          {selectedClass === 'Monk' && <Monk />}
          {selectedClass === 'Paladin' && <Paladin />}
          {selectedClass === 'Ranger' && <Ranger />}
          {selectedClass === 'Rogue' && <Rogue />}
          {selectedClass === 'Sorcerer' && <Sorcerer />}
          {selectedClass === 'Warlock' && <Warlock />}
          {selectedClass === 'Wizard' && <Wizard />}
        </section>
      </header>
    </div>
  );
}

export default App;