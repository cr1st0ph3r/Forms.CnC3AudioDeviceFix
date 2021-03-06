# Forms.CnC3AudioDeviceFix
A simple application to help circumvent a problem in Command and Conquer 3 (and expansion) related to Hands-free AG hardware.

<img src="/docs/mainForm.png"/>

Depending on the type of sound hardware present on the machine, the game will choose the Hands-free AG because the game uses the microphone for multiplayer, and depending on the device also, this will cause the game to produce no sound, but it is not the game that produces no sound, but rather the device itself preventing audio output trough its main headphone channel due to its Hands-free AG being 'in use'.

<img src="/docs/soundsMenu.png"/>

This fix could be achieved by hand, by going to the devices manager menu and deactivating the Hands-free AG before game launch and reactivating it later, or ever trough some batch scripts, but this way is more convenient of sorts.

Enabling or disabling hardware devices trough c# is not an out of box experience, though through some clever coding it is achieved, the code responsible for this, as well as a good explanation about how it works can be found at : [https://www.codeproject.com/Articles/21503/Hardware-Helper-Library-for-C](https://www.codeproject.com/Articles/21503/Hardware-Helper-Library-for-C)



#### Notes
In order for this application to work, there are four attributes that need to be changed in app.config, so the program knows where the game is and also what device to look for when disabling/enabling.
