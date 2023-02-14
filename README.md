# OSC Send

*Max 8.5*

This collection of Max for Live Devices sends information about a Live-Set and it's tracks via OSC[^1] to other software.

<br/>

#### The collection consists of six devices:
#### Live Set Specific
##### *Devices sending information about the Set*.
**OSC_Scene_Send** *Audio-Effect*
- sends the Scene that is currently playing 
- works in Session View

**OSC_Locator_Send** *Audio-Effect*
- sends the last locator
- sends the remaining quarter-notes until the next locator
- works in Arrangement View

<br/>

#### Track Specific
##### *Devices sending information about the track they are on.*
##### The message automatically includes the Trackname.
**OSC_Beat_Send** *Audio-Effect*
- sends the current beat/note within one bar
- choose between quarter-, eighth-, sixteenth- or thirty-second-notes

**OSC_Bar_Send** *Audio-Effect*
- send the bar the is currently playing

**OSC_MIDI_Send** *MIDI-Effect*
- send currently playing MIDI-notes (pitch and velocity)

**OSC_Automation_Send** *Audio-Effect*
- send dan Automation specifically made for this device
- choose between three knobs and one button

<br/>
<br/>

#### Examples
**OSC_Send.als** *Ableton Live Set*
- Ableton Live 11
- Live Set including all the devices
- including Scenes, locators and automation to showcase all functionalities 

**OSC_Receive.maxpats** *Max Patch*
- Max 8.5
- Max Patch receiving and displaying all messages from the devices in the OSC_Send-Set

**Unity_OSC_Receive** *Unity Project*
- Unity 2021.3.16f1
- Unity project receiving and displaying some messages[^2] from the devices in the OSC_Send-Set
- the OSC-script is taken from this [Repo](https://thomasfredericks.github.io/UnityOSC).

<br/>
<br/>

[^1]: The host is set to *127.0.0.1* and the port is set to *5555* by default.
[^2]: Only *int* and *foat* is possible at the moment.
