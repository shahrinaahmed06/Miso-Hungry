# Miso Hungry Game

COMP602 Software Development Practice

**About Game**

Dinner tonight, yea alright!
You play as a lad who has forgotten to cook dinner for tonight!
it is your job to get through the levels  with all the ingredients you need to cook dinner that night.

Miso Hungry Game revolves around the player collecting miso and other ingredients while evading obstacles and finally reach the checkout in a given period of time in each level.
There are three levels in which level 1 serves as tutorial level while level 2 and 3 is where player begins their challenge! 
Each level has their own difficulty level based on the time limit, amount of collectible sprites and obstacles.

Collecting the miso and ingredients will add to your score points, whereas colliding with the obstacles will deduct your score. Be careful! When timer runs out or your score reaches 0, game is over and you have to restart the level!

Goodluck making your dinner! 


Please refer to "Miso Hungry" folder for final version of project. <br/><br/>


**Game Overview**

- **Game Controls** <br/>
 To move the avatar, use the arrow keys on the keyboard (up, down, right and left) accordingly.
 
 - **Game Features** <br/>
Menu and levels selection  <br/>
Collect miso and ingredients  <br/>
Evade moving obstacles   <br/>
Pause button <br/>
Timer display <br/>
Sound effects and game music <br/>
Checkout to proceed to next level <br/>
Change avatar <br/>
Mute music option <br/>
Score display <br/>

**1. Main Menu** <br/>
When game loads, main menu is displayed. 
- Play button: This will display levels and avatar selection menu.
- Settings button: This will display settings option.
- Exit button: This will completely exit the game.

<p align="center">
  <img width="600" height="300" src="https://user-images.githubusercontent.com/62451840/85294159-69e63000-b4f2-11ea-85c3-db8d6753a9e8.PNG">
</p>


**2. Avatar and Levels Selection Menu** <br/>
This scene is displayed when player clicks on play button in 'Main Menu'.
- Avatar selection: Player clicks on any avatar they want. If none is clicked, default will be the first avatar, the main girl character.
- Level selection: Player clicks on which level they want to play. It will open the level accordingly.
- Back button : This will display 'Main Menu' back.

<p align="center">
  <img width="600" height="300" src="https://user-images.githubusercontent.com/62451840/85294707-17f1da00-b4f3-11ea-8900-9f6b59eeb150.PNG">
</p>


**3. First Level (Tutorial)** <br/>
This level is displayed when 'Level 1' button is clicked in 'Avatar and Levels Selection Menu'.
- Ready button: This will load the tutorial level.
- Back button: This will return player to 'Avatar and Levels Selection Menu'.

<p align="center">
  <img width="600" height="300" src="https://user-images.githubusercontent.com/62451840/85296576-b67f3a80-b4f5-11ea-9545-c73322fc0296.PNG">
</p>


**4. First Level (Tutorial)** <br/>
This level is displayed when 'Ready' button is clicked in 'Tutorial Descriptor'.

<p align="center">
  <img width="600" height="300" src="https://user-images.githubusercontent.com/62451840/85294948-5be4df00-b4f3-11ea-8942-e271d015e8db.png">
</p>


**5. Second Level (Level 1)** <br/>
This level is displayed when 'Level 2' button is clicked in 'Avatar and Levels Selection Menu' or when player reaches door checkout in Tutorial level.

<p align="center">
  <img width="600" height="300" src="https://user-images.githubusercontent.com/62451840/85295086-8d5daa80-b4f3-11ea-97f2-19b68a2b381e.png">
</p>


**6. Third level (Level 2)** <br/>
This level is displayed when 'Level 3' button is clicked in 'Avatar and Levels Selection Menu' or when player reaches door checkout in Level 1.

<p align="center">
  <img width="600" height="300" src="https://user-images.githubusercontent.com/62451840/85295129-9cdcf380-b4f3-11ea-9939-19adbc62ca32.png">
</p>


All levels have timer and score displayed, and pause button. When player hits collectible sprites (miso, leek and spoon), the score is added, whereas score is deducted when player hits wasabi obstacle. The wall only blocks player path. <br/>
When player reaches door checkout, the next level will load accordingly. <br/>

**Pause button** <br/>
This will open pause menu panel. Timer is paused as well.
- Resume button: This will resume the current level playing.
- Main Menu button: This will return player to 'Main Menu'.
- Quit button: This will exit the game completely.

<p align="center">
  <img width="600" height="300" src="https://user-images.githubusercontent.com/62451840/85296441-8041bb00-b4f5-11ea-823c-b85fff3e3bdc.PNG">
</p>


**Game Over panel**  <br/>
When timer or score reaches 0, then game over panel is displayed.
- Main Menu button: This will return player to 'Main Menu'.
- Restart button: This will restart the current scene playing.
- Quit button: This will exit the game completely.

<p align="center">
  <img width="600" height="300" src="https://user-images.githubusercontent.com/62451840/85296002-dcf0a600-b4f4-11ea-9b16-f69d1f466eb3.PNG">
</p>


**7. Game Over** <br/>
This is displayed when player reaches door checkout in the last level.  
- Restart button: This will load tutorial level again (back to first level) as level 2 is the last level in game.
- Main Menu: This will return player to 'Main Menu'.
- Quit button: This will exit the game completely.

<p align="center">
  <img width="600" height="300" src="https://user-images.githubusercontent.com/62451840/85297144-84baa380-b4f6-11ea-8a39-2d2f72d85842.png">
</p>

