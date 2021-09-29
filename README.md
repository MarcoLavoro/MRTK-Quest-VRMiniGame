# MRTK-Quest-VRMiniGame
MRTK-Quest is a Mixed Reality Toolkit (MRTK) extension for Oculus Quest (1&2), now with support for Rift/Rift S as well.
It was built to showcase the hand-driven interaction model designed by Microsoft for HoloLens 2, on the Oculus ecosystem.

**As of [MRTK 2.5](https://microsoft.github.io/MixedRealityToolkit-Unity/version/releases/2.5.0/Documentation/ReleaseNotes.html), Oculus platforms are officially supported, leveraging the code that powers MRTK-Quest. Going forward, Microsoft will be maintaining Oculus support.**

## Main features
- Full support for articulated hand tracking, and simulated hand tracking using controllers with avatar hands.
- Support for Oculus Link on Quest with controllers, which means rapid iteration without builds.
- Full support for any interaction in the MRTK designed to work for HoloLens 2.

# Unity version
- Unity 2019.4.12f1+ LTS

# Supported target devices
- Oculus Quest 1 & 2  - Android / Windows Standalone w/ Link
- Oculus Rift/S - Windows Standalone

# How to play
The game is designed to be played on a couch. (sit position)
Press play on the main menu, then take a look at the panel in front of you.
On the blue panel in front of you, there will be some desserts.
Take all the desserts from around you and put them on the plate in front of you, then press the big blue button under the plate.


## FAQ
There is a way to let people bend more or less?
- Yes! the level is designed to let you move the: front, side left, side right, the roof of the level.

There is a way to let people interact only with some object.
- Yes! you have only to change the code to not generate randomly the desserts list

## SETUP

### Unity Setup
MRTK will be located in your **External** folder.
It **NEEDED** to be imported to let the project work

If inside the Asset folder you will find one of these files or folders:
- MRTK
- MRTK.meta
- MixedRealityToolkit.Generated
- MixedRealityToolkit.Generated.meta

**DELETE** these files.

Then when these files are not present

Run with Administrator permission:
    - On Windows run the bat External/createSymlink.bat by double-clicking it. 
    - On OS X execute the shell script via "./createSymlink.sh".
    This will link the MRTK folders cloned via the submodule into the project.
    
Good work!
