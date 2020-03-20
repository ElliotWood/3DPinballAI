# 3D Pinball AI
<img src="Docs/imgs/Pinball.png" align="middle" width="600"/>

3D Space Cadet Pinball - Deep Reinforcement Learning is an open-source
example of create an AI in .Net using ([Unity ML-Agents][unityMlAgents]) and a game (['3D Space Cadet Pinball'][spaceCadetPinball]), to serve as a learning environment for training intelligent agents to play pinball without supervision.

The Pinball agent is rewarded by the score going up, and all actions and frames that lead to a higher score are remembered. Initially the actions will be random (using a curiosity model) but over time the agent will choose actions that lead to the highest reward (score).

## Features
- A PinballAgent that can learn from an external game (3D Pinball) by watching the screen as a visual observation.
- (TODO:) Use behaviour cloning to watch a recording of the highest score for 3d Space Cadet Pinball
- (TODO:) Fix scaling limitation.

## Prerequistes
- Download and install (['3D Space Cadet Pinball'][spaceCadetPinball])
- Download, install and configure ([Unity][unity])
- Setup a ([Python 3.6 Virtual Environment](Docs/Using-Virtual-Environment.md))

## Training the PinballAgents
- Setup a ([training session](Docs/Training-ML-Agents.md))

## The code
- The brain ([Pinball Agent](Assets/Scripts/PinballAgent.cs)) implemented in .Net
- The eyes ([External Window Manager](Assets/Scripts/ExternalWindowManager.cs)) used to screen capture external window, and send keys to it. You could say one eye watches the window frames and the other looks at the score.
- The AI config ([trainer_config.yaml](Assets/Config/trainer_config.yaml)) the unity ML agents training config.

## Limitation
- The 3D Space Cadet Window must be in focus during training, with no windows overlapping it.
- Currently the PinballAgent can only read the score when Windows is set to 100% scale when training. 
This is due to the method chosen for detecting the score by comparing pixels.

### How to change display scaling settings using recommended values
To change a display scaling size using the recommended settings, use these steps:
1. Open Settings.
2. Click on System.
3. Click on Display.
4. Under the "Scale and layout" section, use the drop-down menu and select the 100% scale setting.
<img src="Docs/imgs/change-scaling-settings-windos-10.jpg" align="middle" width="1183"/>

## Additional Resources
* [Unity ML-Agents][unityMlAgents]


## Credit
Initial concept and code developed by [Elliot Wood][elliotGithub]


## Community and Feedback

This is an open-source project and we encourage and welcome
contributions. Please add detail when submitting new feature branches.

If you run into any problems using this project,
[submit an issue][submitIssue] and
make sure to include as much detail as possible.

## License
[Apache License 2.0](LICENSE)


<!-- Links -->
[elliotGithub]: https://github.com/ElliotWood "Elliot's GitHub"
[submitIssue]: https://github.com/ElliotWood/3DPinballAI/issues "Submit an issue"
[unityMlAgents]: https://github.com/Unity-Technologies/ml-agents "Unity ML Agents GitHub repo"
[spaceCadetPinball]: https://www.groovypost.com/howto/windows-7-3d-pinball-space-cadet-game/ "Space Cadet Pinball"
[unity]: ./Docs/unity-setup.md "Unity Setup Instructions"
