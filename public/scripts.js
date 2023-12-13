// Toggles the dice tray visibility
function toggleDiceTray() {
    const diceTray = document.getElementById('fullDiceTray');
    const clearTray = document.getElementById('refresh');
    
    // Toggle the display style attribute for the dice tray based on the current state. If it's 'block' then change to 'none', and vice-versa
    diceTray.style.display = (diceTray.style.display === 'none' || diceTray.style.display === '') ? 'block' : 'none';
    
    // Toggles the class 'active'
    diceTray.classList.toggle('active');

    clearTray.style.display = (clearTray.style.display === 'none' || clearTray.style.display === '') ? 'block' : 'none';
    clearTray.classList.toggle('active');

    const diceRollerElement = document.getElementById('diceRoller');
    diceRollerElement.classList.toggle('open');

    // Run the changeBtnState function
    changeBtnState();
}
