Created_By: Morgan Houston
Created_Date: 10/17/2020
Purpose: Pinball game for CS4173 to demonstrate 2D physics.

Created outer boundary of walls.
Placed a ball chute on the right side.
Placed plunger in chute connected to invisible anchor with spring.
Hold the down arrow key to pull the spring back. Release the key to send the ball up the chute.
Created paddles and their holders. Use left and right arrow keys to activate.
Left paddle has twice as much motor force as the right paddle.
Placed two flat bumpers above paddle holders. Pinball is applied an impulse force of the direction of the normal of the bumper.
Placed verticle chutes behind the two flat bumpers.
Placed two circular bumpers towards the top of the playing field. The right one has twice as much impulse force as the left one.
Pinball is applied an impulse force of the direction of the normal where it contacted the circular bumper.
Placed black diamond in playing field.
Pinball has bouncy 2D physics material.
When the pinball falls below the paddles and hits the bottom boundary, It gets destroyed and respawned in chute at anchor point.
Added small platform that moves left and right. Made it a one-way platform.
Everytime a pinball spawns, it receives a random bounciness and friction from 0.5-1f and 0-1f respectively.
You can press b to toggle on/off the random values.
You can press r to reset the game to a new pinball.
