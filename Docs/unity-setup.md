# Unity Setup

## Install Unity
1. Download and install [Unity Hub][unityHub] if you don't have it already.
2. Run Unity Hub, and select the Projects tab
3. Click "ADD" and select the location of this Project
4. If you don't already have Unity 2019.2.10f1 installed, selecting the project will prompt you to install it. - Click install if required.

![Unity Hub Project screen with Installation promp](./imgs/unity_hub_project.png)

5. Once installed, you can return to the Projects tab and open the Project
6. Ensure Baracuda Package Manageris installed (see below)


## Barracuda Package

ML-Agents version 0.12 takes a dependency on the "Barracuda" package in the Unity Package Manager. 

1. Open the Pinball prject in Unity
1. From the menu bar, go to "Window" > "Package Manager"
1. Click "Advanced" and choose "Show preview packages"
1. Search for the "Barracuda" package
1. Expand and choose "see all versions"
1. Select version "preview - 0.4.0"
1. Click "Update to 0.4.0-preview" and allow the installation to complete



<!-- Links -->
[unityHub]: https://unity3d.com/get-unity/download "Unity Hub 2.3.0 download"
