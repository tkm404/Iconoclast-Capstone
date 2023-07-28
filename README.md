# Iconoclast-Capstone
### By Thomas McDowell
I had a doozy of a time trying to upload this project to GitHub. I found a solution that worked, but my commit history is out the window. To see the hundred-something commits this took, please view this repo: [https://github.com/tkm404/CapstoneProgLog](https://github.com/tkm404/CapstoneProgLog) 

### Technologies Used:
* C#
* Unity
* VS Code

### Setup/Installation Req's:
* Clone this repository to your desktop
* Download Unity Hub
* Open the project in Unity
* Open the scene "Iconoclast Title Scene"
* Press the play button in the top middle of the Unity Editor screen
* Use the left mouse button to advance through menus, select Leader, and push the "Flip Cards"/"RUMBLE!" button(s) on the game screen.

### References:
* Youtube.com/@Brackeys
* Youtube.com/@MSFarzan
* Youtube.com/@MuddyWolf
* Youtube.com/@tservedio
* Youtube.com/@Blackthornprod
* There are certianly more, but these are the ones that immediately come to mind.

### License MIT (c) Thomas McDowell 2023


#### "Iconoclast" is a card game based loosely on the rules of Rock-Paper-Scissors 
* Two players are presented with three different faction choices, and each player will pick two of those factions to build their decks. (half-check)
* Each faction comes with a pre-made 15 card deck scaling up from weak to powerful cards in decreasing quantity. (check)
* The chosen factions' decks are shuffled together to make the 30 card player deck. (sort of check)
* Players play through a Round by flipping over the top card of both decks simultaneously. (check)
* The player whose card has the higher stats (influenced by their faction type. I.E. Rocks are better against Scissors...) wins the Bout. (check)
* The player who wins the best 3 out of 5 Bouts wins a Round and earns points based on how many Bouts were played (a player earns more points for a Round that goes to Bout 5, for instance). (check)
* A Match ends when either player runs out of cards in their deck. (check)
* Tie games will repeat their Bout until the tie is broken (I.E. the round will not go to Bout 3 for as long as Bout 2 results in a tie). (check)

#### Further Objectives:
* Each faction has a leader, whose ability a player may invoke once per Round. Player's first faction choice is their main leader, who may use this ability. 
* The trailing player is allowed to bet points on the next Round before the next Round begins. If they win, they get that many points extra. If they lose, they lose those points
* A full game or "Set" is played out over the best 2 out of 3 Rounds.



# CapstoneProgLog
Progress Log for Epicodus Capstone Project

### 7/7/2023
*  07:59 Research Unity / C# combination practices.
*  08:23 Setup C# program, begin translation from original JS file to C#.
*  08:44 Make Card model in C# GameManager file.
*  09:00 Probably should have either downloaded Unity to my work laptop, or VS Code to my home desktop... coffee break.
*  09:20 Downloading code visualizer on home PC because its faster than getting unity on my laptop. For now.
*  09:49 Back on track with Unity and VS Code talking to each other.
*  10:19 Begin creating Unity assets and visuals.
*  10:48 Creating basic card design visual.
*  11:08 Begin writing code to link card fields to visual.
*  11:38 Double-check fields, begin linking code to visual.
*  12:00 Find and fix errors, getting ArgOutOfRange error.
*  12:18 Fixed Arg... error. Display for individual basic card works!
*  13:23 Resume Coding. Researching Scriptable Objects re: Unity.
*  13:45 Some debate re: Scriptable Objects. Moving on. Setting placeholder images.
*  14:03 Add placeholder images, add Sprite field to Cards.
*  14:27 Scratch coding the deck element. Will adjust as needed for my game's mechanics.
*  14:45 Research period for best ways to make my decks work.
*  15:05 Returning to original source for now. More research.
*  15:23 Continue research on rendering deck in Unity.
*  15:45 Researching drag and drop Unity functionality.
*  16:05 Switching research sources. Researching best way to implement "turn" functionality.
*  16:34 Light refactor based on new research sources.
*  17:05 Write Capstone Proposal. Submit this repo to Epicodus.

### 7/14/2023
* 08:43 Technical difficulties. Projects on home computer not on cloud storage, so installing Unity on Laptop a good idea, but not immediately productive. Had to swing by home. Desktop being a pill.
* 09:00 Update cards text to scalable mesh as opposed to static text image.
* 09:34 Many null reference errors. Working on a fix.
* 09:51 Shifting gears. Trying a new approach based on what I know so far.
* 10:24 Hit a bit of a dead end. Backtracking.
* 10:58 Re-researching Scriptable Objects.
* 11:41 Scriptable Objects are SUPER USEFUL ACTUALLY!
* 12:07 About halfway through rebuilding database of scriptable cards.
* 12:33 Finish rebuild, start rendering cards. Move project to Laptop.
* 14:29 Back from errands. Resuming card rendering.
* 15:13 Finish first pass of card rendering. Working on Decks.
* 13:26 Project crashed... need to repopulate the cards.
* 15:40 Cards re-rendered, project saved.
* 16:09 Draft game board visual.
* 16:35 Add to board game visual. Create deck visuals.
* 16:55 Research grid layout for Unity. Submitting for today.

### 7/21/2023
* Unlogged ~7/16/2023 Implement hover-zoom method to card objects.
* 08:13 Successfully transferred project to work laptop.
* 08:26 Import assets for card back art.
* 09:10 Setup starting deck and discard positions. Reviewing placement for card flip method.
* 10:13 Create scriptable deck objects.
* 10:39 Research game logic implementation.
* 11:27 Refactor some objects to interact better with scene background.
* 12:09 Create Deck Display, add to deck objects. Test lists populating correctly. Break for lunch.
* 13:40 Researching Character/Deck selection scene implementation.
* 14:02 Update button functionality to move cards to arena area.
* 14:58 Still working on that method. Finding the drawbacks of Scriptable Objects, or at least of how I've set things up.
* 15:34 Think I've figured out how to access Scriptable Object... script in this method. Button console logs correct card list.
* 15:57 Okay, I think I may actually have figured it out; random return seems to work.
* 16:10 Snag: Removing from the scriptable list means manually replacing cards. Need to solve that.
* 16:53 Researching how to instantiate a S.O. via the button method.
* 17:16 So close! Need to not tie instantiation to OnClick method.

### 7/23/23
* Unlogged ~16:00 to 23:29 Spent most of the day trying to figure out a workaround for the OnClick making a new deck issue. It turns out that scriptable objects can't be added to objects at runtime. I made a list of GameObjects to populate the FlipCards button method and that seems to have worked to display both player's cards in the main arena area. Still haven't exactly solved the issue with manually re-inserting cards into the lists after testing, but I took away that interaction for the time being. May have to figure out a repeat of the card method.

### 7/24/23
* 15:30ish-16:03 Cards displaying properly in main arena area and discard piles. Need to better indicate that the middle cards are going to discard piles.
* 17:43 Figured out an instantiation order that works to stagger the discard piles and flip piles.
* 18:09 Add function to flip button to turn off and reveal "RUMBLE!" button.

### 7/25/23
* 10:03 Add toggle feature to buttons to switch between each when clicked.
* 10:47 Debug test of Rumble button acknowledges both player's cards in arena area.
* 11:20 Figure out how to find script text on objects via code reference!
* 15:04 Resume testing. Successfully determine if one card's power is higher than the other!
* 15:11 Pass debug test to determine if bout ends in win or draw for both players with basic stats!
* 15:26 Implement type advantage to boost attack stats, pass debug test!
* 15:46 Type advantage/disadvantage logic working!
* 16:32 Update UI with areas for Win indication and match feedback window.
* 19:59 Back at it. Added UI area to indicate number of bouts played in a round.
* 21:16 UI field for game events no longer transparent for no reason.
* 21:37 UI field for game events updates with correct events.

### 7/26/23
* 10:22 Researching character/deck selection options.
* 10:26 Actually scratch that for now, working on finishing scoring indicators.
* 10:38 Update scrolling match log to display victory message.
* 11:16 Bout indicator "lights" working correctly.
* 11:43 Victory indicator "lights" working correctly, but wrong color for P2.
* 12:07 Upon further inspection, the lights are the wrong color for P1 as well, but at least they're appearing in the right places.
* 13:05 Looking into scene changes for menus, rounds, character selection.
* 13:53 Add title scene, title banner, and play game button (no functionality yet).
* 14:13 Add options menu with "Shenanigans" slider.
* 14:24 Add function to play button to switch to game scene!
* 14:31 Menu buttons all work to do what they say they do.
* 15:09 First pass at character/deck selection screen. Add buttons to advance to game, go back to main menu.
* 16:41 Update UI visuals to be more appealing.
* 17:29 WIP Character/Deck selection screen and code.
* 19:53 Character selection icons up, able to select an icon.
* 20:08 WIP Faction selection screen. Weird visual glitch happened where I can't see certain UI elements in the editor, but I can see them in play mode.
* 21:24 Visual glitch fixed. No idea why it happened, but a bunch of Z values were randomly messed with.
* 21:28 Update leader portraits.

### 7/27/23
* 08:09 Presentation later today, so I'll try to get Leaders to spawn into the game with a deck. Subfaction choice will have to wait. If that works, I might try to get Rounds to work.
* 09:15 Still WIP. The deck occasionally looks like it works, but I haven't been able to replicate the success.
* 09:56 I /THINK/ I figured it out. Leaders are spawning with their correct decks.
* 10:11 Leaders seem to be working with correct decks, P2 seems to be working with a random deck, but that's hard to test.
* 10:50 Leader decks now creating instances of objects so I don't have to manually refill them! Deleted duplicates from Library list.
* 11:09 Make leader select portraits slightly bigger.
* 11:42 Add recurring button to game scene to return to leader select scene.
* 11:55 Add shadows to the deck UI positions to give them some depth.
* 12:05 Adjusted card stats to align better with game philo.
* 12:26 Add score indicators to both player's sides.
* 13:28 Set bout indicators to reset after a round is finished.
* 13:50 Set end point once decks run out of cards. Show Back button on game scene.
