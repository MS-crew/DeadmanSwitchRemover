<h1 align="center">Deadman Switch Remover - Dms Remover</h1> 
<div align="center">
<a href="https://github.com/MS-crew/DeadmanSwitchRemover/releases"><img src="https://img.shields.io/github/downloads/MS-crew/DeadmanSwitchRemover/total?style=for-the-badge&logo=githubactions&label=Downloads" alt="GitHub Release Download"></a> <a href="https://github.com/MS-crew/DeadmanSwitchRemover/releases"><img src="https://img.shields.io/badge/Build-1.5.2-brightgreen?style=for-the-badge&logo=gitbook" alt="GitHub Releases"></a> 
<a href="https://github.com/MS-crew/DeadmanSwitchRemover/blob/master/LICENSE">
<img src="https://img.shields.io/badge/Licence-GNU_3.0-blue?style=for-the-badge&logo=gitbook" alt="General Public License v3.0"></a> 
<a href="https://github.com/ExMod-Team/EXILED"><img src="https://img.shields.io/badge/Exiled-9.5.1-red?style=for-the-badge&logo=gitbook" alt="GitHub Exiled"></a> 
</div>

## Deadman Switch Remover

- **Deadman Switch Remover:** Removes the Deadman Switch in the game or prevents it from activating until a certain amount of time has passed.
- **Deadman Switch Delayer:** Prevents the DeadMan Switch from turning on before a certain number of minutes without completely removing it.
- **Dms and Auto Warhead conflict prevention** It prevents the two warheads from overlapping.

## Installation

1. Download the release file from the GitHub page [here](https://github.com/MS-crew/DeadmanSwitchRemover/releases).
2. Extract the contents into your `\AppData\Roaming\EXILED\Plugins` directory.
3. Configure the plugin according to your server’s needs using the provided settings.
4. Restart your server to apply the changes.

## Feedback and Issues

This is the initial release of the plugin. We welcome any feedback, bug reports, or suggestions for improvements.

- **Report Issues:** [Issues Page](https://github.com/MS-crew/DeadmanSwitchRemover/issues)
- **Contact:** [discerrahidenetim@gmail.com](mailto:discerrahidenetim@gmail.com)

Thank you for using our plugin and helping us improve it!

Default Config
```yml
is_enabled: true
debug: false
# Should DMS be permanently disabled?
permenantly_remove: true
# Deadman switch should wait at least how many minutes to start? 
MinimumStartMinutes: 15
```
