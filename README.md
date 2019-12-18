# GE1Assignment
My Assignment for Game Engines 1

I plan to build a program that will intake audio, and then use that data to create procedural visuals. I plan to use this as a visual in 
the background of DJing at my own gigs and parties. I am very passionate about this and will continue to work on this project long after   
the semester is over. I would also like to combine this with a procedural infinite tunnel. The start will begin in the tunnel and go through
it. after some time passes it exits the tunnel and shows some sort of audio visualiser, then after time goes back into the tunnel. 

I have looked at some audio visualizers in youtube which use unity and in the past i have also used a visualizer on an old video editing 
tool when i was younger. I also looked at some of the previous years projects and i hope to draw inspiration from some of the linked ones 
below

videos i found on YT
https://www.youtube.com/watch?v=5pmoP1ZOoNs&list=PL3POsQzaCw53p2tA6AWf7_AWgplskR0Vo
https://www.youtube.com/watch?v=-XcBjhF1U0U
https://www.youtube.com/watch?v=O9IsGkU6-Hk

Previous Year Projects
https://www.youtube.com/watch?v=ZjWBGvVb7Vg&list=PL1n0B6z4e_E5qaYwUOlJ63XI2OR9ty7Bs&index=21
https://www.youtube.com/watch?v=S1h6h17zOMw&list=PL1n0B6z4e_E5qaYwUOlJ63XI2OR9ty7Bs&index=4
https://www.youtube.com/watch?v=MXm9OmzRe2o&list=PL1n0B6z4e_E5qaYwUOlJ63XI2OR9ty7Bs&index=1

Description of what you did?

Was fascinated with the fibonacci sequence and how it is seen in nature through phyllotaxis. I wanted to use this kind of maths sequence to create visuals.
Firstly after coding the sequence and attaching it to a game object (seen in and commented out in phyllotaxis.cs). I then played around with different variable values
to see what looked cool. I then layered these and created my own gradients and colours in unity to use on them. These layered sequences are seen in the SelfDrawer Game Object.

After creating the self drawing object i wanted to create a 3d tunnel. I did this by creating some new phyllotaxis shapes and increasing the z position with the camera anchored
behind. This creates the 3d tunnel effect. I also messed around with putting the same visualiser shapes into the tunnel and the results were very cool.

finally i wanted to add some audio visualisation to the project. Firstly i read in audio data and broke them down into 512 smaples and then broke them down into 8 frequecy
bands. This allowed me to make 8 visualisers with nice height and range. I also added a buffer to make them move more smoothly. I then combined these 3 elements using timers
to enable and disable GOs and scripts to create a performance with the song. I was sadly not able to implement all the things i wanted but am very happy with what i achieved
and hope to continue this work and apply it to my own DJing.



What you are most proud of about the assignment?

The performance at the end. As a DJ i love performing and even though its only a 2/3 minute performance of visuals its cool to think that 'wow i created that'. This bodes
well for the future where i hope to do a lot more projects like this one for my own professional use.



What resources were useful for you (websites, tutorials, assets etc)?

The unity documentation and a couple tutorials combined with the work form this semester to enable me to do this project.




YT VIDEO
https://www.youtube.com/watch?v=Q_Wjxtx1JPA


Becomes:

[![YouTube](http://img.youtube.com/vi/Q_Wjxtx1JPA/0.jpg)](https://www.youtube.com/watch?v=Q_Wjxtx1JPA)
