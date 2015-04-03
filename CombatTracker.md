# Introduction #

The idea of the combat tracker module is to leverage the work of tracking turns and life(HP) of the characters involved in a combat. Also a key thing is the location of the characters in the map, so the idea is to develop a tracker that can take care of the following features:
  1. Character life
  1. Character turns and who is the one to act first using an initiative system
  1. Character location (the position of the character in the map)
  1. Character size
  1. Character status (is she poisoned, deaf, etc)
  1. Other tools, like identifing a player character from an NPC, hiding characters, etc.

# Details #

## Character life ##

Character life is depicted by HP gauges, this are set with a current value and a maximum value. a character is considered fallen if the current hp drops to 0, at that moment it will be marked with a different color in the visualizer (see: [MultiDisplayVisualization](MultiDisplayVisualization.md)) and in the DM view.

Although this is the behavior, the hp can go to negatives to support some games where a 0 hp means unconscious and -X means death.

## Character turns and initiative ##

The system uses a initiative system to track turns (as most games does) it has two buttons to move through initiatives, one will move ascending(prev) and the other descending (next). For it to work correctly the characters must have initiative values set, otherwise everyone will go in initiative 0, so set it please.

## Character location ##

Is controlled by a map view of the action, just drag the icons around and reposition the characters. Although possible is highly discouraged positioning characters outside map boundaries since drag and drops will get crazy. (i've warned you)

## Character size ##

It is posible to set a different size for characters so there can be a fight against larger enemies (say a dragon) where it occupies a 3x3 area, while the characters are only on 1x1 squares. So at the moment of creation of the combatant it is possible to specify the size of the creature in question.

## Character status ##
**(not available yet)**
Different statuses as well as a detailed editor is shown when right or double clicking a character on the map or with the menu or buttons the editor shown will allow the DM to set different status ailments, counters and so on which are displayed as icons in the [MultiDisplayVisualization](MultiDisplayVisualization.md) and as text on the DM Screen.

## More tools ##
### Player characters ###
Player characters are distinguished by the player checkbox this allows the display of the HP of the character in numbers on the [MultiDisplayVisualization](MultiDisplayVisualization.md) so that players knows exactly how much life its left. Disabling this check will hide this numbers so they never know how much hp an enemy has exactly.
### Hide characters (visible checkbox) ###
If this checkbox is marked then characters can be seen on the [MultiDisplayVisualization](MultiDisplayVisualization.md) otherwise they remain hidden there. You can always see them on your DM screen.