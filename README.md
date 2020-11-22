# Escape Mines Game

A fun game that helps a litle turtle scapes from a minefield.

## How it's work

The game settings is a text file which should follow this format.

- The first line should define the board size
- The second line should contain a list of mines (i.e. list of co-ordinates separated by a space)
- The third line of the file should contain the exit point.
- The fourth line of the file should contain the starting position of the turtle.
- The fifth line to the end of the file should contain a series of moves.

Ex:

``` text
5 4
1,1 1,3 3,3
2 4
1 0 N
R M M M M R M
R R M M L M M M M L M
```

Where

- R = Rotate 90 degrees to the right
- L = Rotate 90 degrees to the left
- N = North direction
- S = South direction
- W = West direction
- E = East direction
- M = Move

## How to play

``` cmd
MineEscape.exe "your_config_file.txt"
```

## Results

Results can be:

- Success – if the turtle finds the exit point
- Mine Hit – if the turtle hits a mine
- Still in Danger – it the turtle has not yet found the exit