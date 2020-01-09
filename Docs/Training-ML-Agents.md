# Training ML-Agents

## Limitation
- Currently the PinballAgent can only read the score when Windows is set to 100% scale when training. 
- The 3D Space Cadet Window must be in focus during training, with no windows overlapping it.

## Training with mlagents-learn

Use the `mlagents-learn` command to train agents. See ([Python Python 3.6 Virtual Environment](Docs/Using-Virtual-Environment.md)) if not yet installed.

Open the Unity Editor, this will be required when a training session is opened.

Run `mlagents-learn` from the command line to launch the training process. Use
the command line patterns and the `config/trainer_config.yaml` file to control
training options.

The basic command for training is:
```
mlagents-learn 3DPinballAI/Assets/Config/trainer_config.yaml --run-id=FirstRun --train
```

or

```
mlagents-learn <trainer-config-file> --env=<env_name> --run-id=<run-identifier> --train
```
where

* `<trainer-config-file>` is the file path of the trainer configuration yaml.
* `<env_name>`__(Optional)__ is the name (including path) of your Unity
  executable containing the agents to be trained. If `<env_name>` is not passed,
  the training will happen in the Editor. Press the :arrow_forward: button in
  Unity when the message _"Start training by pressing the Play button in the
  Unity Editor"_ is displayed on the screen.
* `<run-identifier>` is an optional identifier you can use to identify the
  results of individual training runs.

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
-[See command-line-training-options](https://github.com/Unity-Technologies/ml-agents/blob/master/docs/Training-ML-Agents.md#command-line-training-options)

### Debugging and Profiling
If you enable the `--debug` flag in the command line, the trainer metrics are logged to a CSV file
stored in the `summaries` directory. The metrics stored are:
  * brain name
  * time to update policy
  * time since start of training
  * time for last experience collection
  * number of experiences used for training
  * mean return