# MBINCompiler Classic for Atlas Rises

### Links
- [No Man’s Sky Archive](https://github.com/Lenni009/nms-archive) (all mbins from each update!)
- [MBINCompiler](https://github.com/monkeyman192/mbincompiler)
- [No Man’s Sky Retro](https://nomansskyretro.com) (instructions on how to get older versions!)

------
Early versions of No Man’s Sky have a lot of modding *potential*. OpenGL shader code readily modifiable, game scope small enough to comprehend easily, etc., but a lot of the modern luxuries we take for granted were not in the game. Globals are almost unusable due to a lack of names, for example. 

Well, in No Man’s Sky NEXT, we got global names. I recently started working backwards from the NEXT globals to fill in the blanks for my globals EXMLs, and decided forking MBINCompiler would be a better way to go about it.

So here’s the roadmap:

1. Get Atlas Rises globals and structs as good as possible. AR is the latest “classic” version we have and it’s the closest we’ll get to NEXT, so NEXT’s globals will hopefully share a lot of values with AR, making it easy to know what is what. **we’re here.** 
2. Start working backwards. Branch the Pathfinder version of MBINCompiler. Port 1.38.3’s geometry mbin (de)serialization. Match globals. Then do the same for 1.1 and 1.0.
3. Figure out the last few remaining names with CE or just guesswork. 

This is a project with a definite end goal. I shouldn’t lose motivation but please feel free to contribute. It’s going to be a lot of busywork. I’m also a full-time commuter student, so I don’t have *that much* free time in the first place… help is appreciated.

So let’s use some inductive reasoning and have some fun!

~ethanrdoesmc

# how to help!

1. Open up two windows: one with the Atlas Rises version of a globals exml, and the other with the NEXT version of that globals exml. https://github.com/Lenni009/nms-archive/ is a great source. 
2. Start making comparisons. Hit ctrl-f and look for values that match between the two. 
3. If you think you’ve got a match, go ahead and change the name in mbincompiler-classic! Make sure to include a block comment with the offset for the property if there isn’t one already, like so: 

if the property was named Unknown7D:
`/* 0x07D */ public…`

Then just make a pull request!

Tips:
- try to find groups of matching values! It makes it go a lot faster, and you’ll start to find your way around the globals file. This is *especially helpful* with Bools since they’re otherwise extremely hard to match.
- if you’re not sure about one, just leave a comment after the semicolon. 
- if everything lines up (it’s in a group, the type is right, and the property is where it should be) but the value is different, consider that the value may have changed between AR and NEXT. See if the change makes sense with the context of the name.


## original readme as follows
# MBINCompiler

*Updated version to Emoose’s project originally found here: https://github.com/emoose/MBINCompiler

As emoose doesn’t seem to be updating MBINCompiler for support with NMS v1.1, we are updating the program ourselves.

Already a fair few new files can be decompiled, however there is still a bit of work to go until this is fully compatible with 1.1

If you are interested in helping out or modding in general, check out the discord chat: https://discordapp.com/invite/3Ytkxss
