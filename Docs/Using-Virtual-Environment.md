# Using Virtual Environment

## What is a Virtual Environment?
A Virtual Environment is a self contained directory tree that contains a Python installation
for a particular version of Python, plus a number of additional packages. To learn more about
Virtual Environments see [here](https://docs.python.org/3/library/venv.html)

## Why should I use a Virtual Environment?
A Virtual Environment keeps all dependencies for the Python project separate from dependencies
of other projects. This has a few advantages:
1. It makes dependency management for the project easy.
1. It enables using and testing of different library versions by quickly
spinning up a new environment and verifying the compatibility of the code with the
different version.

Requirement - Python 3.6.2 must be installed on the machine you would like
to run ML-Agents on (either local laptop/desktop or remote server). Python 3.6.2 can be
installed from [here](https://www.python.org/downloads/release/python-362/).
1. Add Python to Path Variable 

## Python Version Requirement (Required)
This guide has been tested with [Python 3.6](https://www.python.org/downloads/release/python-362/). Python 3.7 and 3.8 is not supported at this time.

## Installing Pip (Required)

1. Download the `get-pip.py` file using the command `curl https://bootstrap.pypa.io/get-pip.py -o get-pip.py`
1. Run the following `python get-pip.py`
1. Check pip version using `pip3 -V`

## Mac OS X Setup

No supported due to 3D Space Cadet Pinball not available.

## Ubuntu Setup

No supported due to 3D Space Cadet Pinball not available.

## Windows Setup

1. Open Command Prompt with 'Run as Administrator' rights.
1. Create a folder where the virtual environments will reside `md python-envs`
1. To create a new environment named `pinball-env` execute `python -m venv python-envs\pinball-env`
1. To activate the environment execute `python-envs\pinball-env\Scripts\activate`
1. Verify pip version is the same as in the __Installing Pip__ section. In case it is not the
latest, upgrade to the latest pip version using `pip install --upgrade pip`
1. Install ML-Agents package using `pip install mlagents==0.12.0`
1. To deactivate the environment execute `deactivate`

Note:
- Verify that you are using Python 3.6. Launch a command prompt using `cmd` and
 execute `python --version` to verify the version.
- Python3 installation may require admin privileges on Windows.
- This guide is for Windows 10 using a 64-bit architecture only.

### Troubleshooting

We have occassionally observed the following issue when following the above setup steps:

#### Updating PIP in the virtual environment throws exception

You may get a `PermissionError: [WinError 5] Access is denied: <path to pip.exe>` when upgrading PIP from Step 5. 

[![pip Permissions Error](./imgs/pip_error_sm.png)](./imgs/pip_error.png)

Run the upgrade command again to verify that PIP has been successfully upgraded.


#### Incompatible Setup Tools

You may get an error when installing ml-agents `you'll have steuptools 28.8.0 which is incompatible` for multiple dependencies.

[![Incompatible Packages Error](./imgs/Incompatible_Packages_sm.png)](./imgs/Incompatible_Packages.png)

This menas that you likely have installed a version of MLAgents newer than version `0.12.0`. Ensure that you have specifed the correct version of ml-agents to be installed.



## Unity Setup
BARRACUDA PACKAGE DEPENDENCY:

ML-Agents version 0.12 takes a dependency on the "Barracuda" package in the Unity Package Manager. If you do not install this, ML-Agents will not work and you will get a lot of error messages.

To fix this:
1. In the top menu, go to "Window" > "Package Manager"
1. Click "Advanced" and choose "Show preview packages"
1. Find and click on the "Barracuda" package
1. Click "Install" and allow the installation to complete
