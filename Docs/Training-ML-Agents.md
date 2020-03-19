# Training ML-Agents

## Limitation
- Currently the PinballAgent can only read the score when Windows is set to 100% scale when training. 
- The 3D Space Cadet Window must be in focus during training, with no windows overlapping it.

## Start Training

1. Open Unity, and open the 3DPinballAI project
1. In the Project pane, select Assets > Scenes > main
1. Build the project by selecting File > Build Settings > Build - ensuring the project builds correctly.
1. Open your favourite terminal <sup>[1](#footnote1)</sup>
1. Activate your [virtual Puthon environment][virtualEnvironment] by running `.\python-envs\pinball-env\Scripts\activate` <sup>[2](#footnote2)</sup>
1. Start the training by running `mlagents-learn <PATH_TO_PROJECT>\3DPinballAI\Assets\Config\trainer_config.yaml --run-id=FirstRun --train`

    - the `trainer_config.yaml` specifies parameters the training algorithm will use.
    - the `run-id` parameter can be named anything you like, this is specified so you can save, and reload different training runs later.

7. ml-agents will execute and prompt you to press play in Unity
    - `INFO:mlagents.envs:Start training by pressing the Play button in the Unity Editor.`
8. Press play the Play button in Unity
9. A new 3D Pinball game will start.
10. The 3D Pinball window needs to stay focused and in the foreground with no other windows overlapping it.
11. Sit back and watch as the Training attempts to figure out how to play.

### Monitoring Training 

During a training session, the training program prints out and saves updates at
regular intervals (specified by the `summary_freq` option). The saved statistics
are grouped by the `run-id` value so you should assign a unique id to each
training run if you plan to view the statistics. You can view these statistics
using TensorBoard during or after training by running the following command:

```sh
tensorboard --logdir=summaries --port 6006
```

And then opening the URL: [localhost:6006](http://localhost:6006).

**Note:** The default port TensorBoard uses is 6006. If there is an existing session
running on port 6006 a new session can be launched on an open port using the --port
option.

When training is finished, you can find the saved model in the `models` folder
under the assigned run-id — in the cats example, the path to the model would be
`models/FirstRun/VisualPinball.nn`.

While this example used the default training hyperparameters, you can edit the
[training_config.yaml file](3DPinballAI/Assets/Config/trainer_config.yaml) with a text editor to set
different values.

### Command Line Training Options
-[See command-line-training-options][commandLineTrainingOptions]

### Debugging and Profiling
If you enable the `--debug` flag in the command line, the trainer metrics are logged to a CSV file
stored in the `summaries` directory. The metrics stored are:
  * brain name
  * time to update policy
  * time since start of training
  * time for last experience collection
  * number of experiences used for training
  * mean return


  <!-- Footnotes -->
<hr/>

<a name="footnote1">1</a>: You can use the Command Prompt, [Powershell][powershell] or [Windows Terminal][windowsTerminal].

<a name="footnote2">2</a>: If you used different folder names in the Virtual Environment Setup, you'll need to use those instead. 

<!-- links -->
[virtualEnvironment]: Docs/Using-Virtual-Environment.md "Virtual Python Environment instructions"
[commandLineTrainingOptions]: https://github.com/Unity-Technologies/ml-agents/blob/master/docs/Training-ML-Agents.md#command-line-training-options "Command line training options for ML-Agents"
