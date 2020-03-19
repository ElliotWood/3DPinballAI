# Using Virtual Environment

## What is a Virtual Environment?
A Virtual Environment is a self contained directory tree that contains a Python installation
for a particular version of Python, plus a number of additional packages. To learn more about
Virtual Environments see [here][pythonVirtualEnvironments]

## Why should I use a Virtual Environment?
A Virtual Environment keeps all dependencies for the Python project separate from dependencies
of other projects. This has a few advantages:
1. It makes dependency management for the project easy.
1. It enables using and testing of different library versions by quickly
spinning up a new environment and verifying the compatibility of the code with the
different version.

Requirement - Python 3.6.2 must be installed on the machine you would like
to run ML-Agents on (either local laptop/desktop or remote server). Python 3.6.2 can be
installed from [here][pythonDownload]).


## Requirements

### __Note__
- The instructions are applied to a Windows machine only, since we're setting up for Space Cadent Pinball which doesn't work on other platforms.
- This guide is for Windows 10 using a 64-bit architecture only. 

### __Install Python__
This guide has been tested with [Python 3.6][pythonDownload]. (Python 3.7 and 3.8 is not supported at this time.)

1. Using the Web Installer for Python is the easiest way to get Python 3.6 installed.
1. You should use the following installer options for this project (if you're unsure)

![Python Optional Features, Select "py launcher", ignore everything else](./imgs/python_optional.png)

![Python Advanced Options, Ensure "Add Python to Environment Variables" is checked](./imgs/python_advanced.png)

3. Open your favourite terminal <sup>[1](#footnote1)</sup> and ensure that you have the right version of Python installed by running `python --version`. You should see "Python 3.6.2"

### __Install Pip__
1. Open your favourite terminal <sup>[1](#footnote1)</sup>
1. Download the `get-pip.py` file using the command `curl https://bootstrap.pypa.io/get-pip.py -o get-pip.py`
1. Run the following `python get-pip.py`
1. Check pip version using `pip -V`. you should see "pip 20.0.2"


###  __Create Virtual Python Environment__

1. Open your favourite terminal<sup>[1](#footnote1)</sup> as an Administrator <sup>[2](#footnote2)</sup>
1. Create a folder where the virtual environments will reside `md python-envs`
1. To create a new environment named `pinball-env` execute `python -m venv python-envs\pinball-env`
1. To activate the environment execute `python-envs\pinball-env\Scripts\activate`
1. Verify pip version is the same as in the __Install Pip__ section. 
    - If you don't have the latest pip in the virutal envornment, you can upgrade it by executing `python -m pip install --upgrade pip`
1. Install ML-Agents package using `pip install mlagents==0.12.0` <sup>[3](#footnote3)</sup>
1. To deactivate the environment execute `deactivate`

## Finish

You're now ready to start [Training][training] the pinball machine.

<!-- Footnotes -->
<hr/>

<a name="footnote1">1</a>: You can use the Command Prompt, [Powershell][powershell] or [Windows Terminal][windowsTerminal]. 

<a name="footnote2">2</a>: Right click and choose "Run as Administrator".

<a name="footnote3">3</a>: You must use version 0.12.0 of ML-Agents.



<!-- Links -->
[pythonVirtualEnvironments]: https://docs.python.org/3/library/venv.html "Python Virtual Environments Documentation"
[pythonDownload]: https://www.python.org/downloads/release/python-362/ "Download Python 3.6"
[powershell]: https://docs.microsoft.com/en-au/powershell/scripting/install/installing-powershell-core-on-windows?view=powershell-7 "Install Powershell on Windows"
[windowsTerminal]: https://www.microsoft.com/en-us/p/windows-terminal-preview/9n0dx20hk701?activetab=pivot:overviewtab "Windows Terminal"
[training]: ./Training-ML-Agents.md "Training tutorial" 
