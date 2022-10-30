# MBINCompiler Classic for Atlas Rises

I have a weird thing for pre-NEXT No Man’s Sky. It just hits different. Honestly I wasn’t even disappointed at launch.

Early versions of No Man’s Sky have a lot of modding *potential* due to being designed… fairly openly. OpenGL shader code readily modifiable, game scope small enough to comprehend easily, etc., but a lot of the modern luxuries we take for granted were not in the game. Globals are almost unusable due to a lack of names, for example. 

Well, in No Man’s Sky NEXT, we got global names.

I recently started working backwards from the NEXT globals to fill in the blanks for my globals EXMLs, and decided forking MBINCompiler would be a better way to go about it.

So here’s the (early made-at-2am) roadmap:

1. Get Atlas Rises globals and structs as good as possible. AR is the latest “classic” version we have and it’s the closest we’ll get to NEXT, so NEXT’s globals will hopefully share a lot of values with AR, making it easy to know what is what. **we’re here.** 
  
2. Start working backwards. Fork the Pathfinder version of MBINCompiler. Port 1.38.3’s geometry mbin (de)serialization. Match globals. Then do the same for 1.1 and 1.0.
 
3. Figure out the last few remaining values. 

This is a project with a definite end goal. I shouldn’t lose motivation but please feel free to contribute. It’s going to be a lot of busywork. I’m also a full-time commuter student, so I don’t have *that much* free time in the first place… help is appreciated.

So let’s use some inductive reasoning and have some fun!

~ethanrdoesmc

Also, note to self, monkeyman192 suggested using the latest NMSTemplate.cs as a lot of issues have been fixed since 1.38.3. This may apply to other base structs. 

**original readme as follows**
# MBINCompiler

*Updated version to Emoose’s project originally found here: https://github.com/emoose/MBINCompiler

As emoose doesn’t seem to be updating MBINCompiler for support with NMS v1.1, we are updating the program ourselves.

Already a fair few new files can be decompiled, however there is still a bit of work to go until this is fully compatible with 1.1

If you are interested in helping out or modding in general, check out the discord chat: https://discordapp.com/invite/3Ytkxss