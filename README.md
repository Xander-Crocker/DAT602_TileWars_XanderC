# DAT602_TileWars_XanderC_2023

This is a tile based game created using C# and MySQL

Game Objective:
The objective of the game is to gather more items than your opponent. Each item
collected by a player will give them a point. Items will be randomly placed on the gameboard
one at a time, each player will need to get to the square before their opponent to collect the item
and receive a point. The game will end when one player has reached the point limit (10).

Gameboard / Movement:
The gameboard will be a 10x10 grid of squares. Players will be able to move up, down,
left, and right along the gameboard. Players will not be able to move diagonally along the grid.
The player's movement will be controlled with the four arrow keys.

Player:
When the game starts players will be placed in either the top right or bottom left corners
of the gameboard. Once the game starts players will be able to move freely around the
gameboard using the arrow keys.

Items:
Items will be randomly placed on the gameboard one at a time. The next item will appear
when the current item is collected by a player. To collect an item a player must get to and stand
on the tile where the item has spawned before their opponent.

Scoring:
Scores are calculated by the number of items each player collects. Each item collected
will give the player a point. The game will end when one player has 10 points. 
