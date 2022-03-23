# Forms.CnC3AudioDeviceFix
A simple application to help circumvent a problem in Command and Conquer 3 (and expansion) related to Hands-free AG hardware

Depending on the type of sound hardware present on the machine, the game will choose the Hands-free AG because the game uses the microphone for multiplayer, and depending on the device also, this will cause the game to produce no sound, but it is not the game that procudes no sound, but the devile itself preventing audio output trough its main headphone channel due to its Hands-free AG beind 'in use'.
<img src="/docs/soundsMenu.png"/>

This fix culd be achieved by hand, by going to device menager and deactivating the Hands-free AG before game launch and reactivating it later, or ever trough some batch scripts, but this way is more convenient of sorts.

Enabling or disabling hardware devices trough c# is not an out of box experience, though through some clever coding it is achievable, the code responsible for this, as well as a good explanation about how it works can be found at : [https://www.codeproject.com/Articles/21503/Hardware-Helper-Library-for-C](https://www.codeproject.com/Articles/21503/Hardware-Helper-Library-for-C)



#### Notes
in order for this application to work, there are four attributes that needs to be changed in app.congig, so the program knows where the game is and also what device to look for when disabling/enabling.
