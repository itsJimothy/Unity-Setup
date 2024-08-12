## Unity Setup

### Features
Features the following menu items:
- Tools/Setup/Create Folders
  - Creates a project root folder `_Project` with the following subfolders:
    - Art, Animations, Ignore, Imports, Input, Prefabs
  - Moves the `Scenes` folder into the `_Project` folder.
  - Deletes the `TutorialInfo` folder and the the Readme asset.
  - Moves and renames the `InputSystem_Actions.inputactions` file to `_Project/Input`.
---
- Tools/Setup/Import Essential Assets
- Imports the following assets (make sure you own them and have downloaded them downloaded to your system):
  - Editor Console Pro: https://assetstore.unity.com/packages/tools/utilities/editor-console-pro-11889
  - Selection History Pro: https://assetstore.unity.com/packages/tools/utilities/selection-history-184204
  - Color Studio: https://assetstore.unity.com/packages/tools/painting/color-studio-151892
  - Audio Preview Tool: https://assetstore.unity.com/packages/tools/audio/audio-preview-tool-244446
  - Better Hierarchy: https://assetstore.unity.com/packages/tools/utilities/better-hierarchy-272963?aid=1101lw3sv
  - Commented out due to Unity 6 compatibility issues:
    - Editor Auto Save: https://assetstore.unity.com/packages/tools/utilities/editor-auto-save-234445
    - Editor Coroutines (Editor Auto Save dependency): https://assetstore.unity.com/packages/tools/utilities/editor-coroutines-27373
---
- Tools/Setup/Install Essential Packages
  - Downloads and installs the following packages:
    - Cinemachine: com.unity.cinemachine
    - Jimothy's Unity Utilities: https://github.com/itsJimothy/Unity-Utilities.git
---
- Tools/Setup/Remove Junk Packages
  - Removes the following pre-installed packages:
    - Unity's Version Control - Bloated, use git instead.
    - Visual Scripting - Just don't.
    - Visual Studio Editor - This is a Rider household.
    - Timeline - Not a fan. Add back if needed.
---
- Tools/Setup/Fetch .gitignore
  - Fetches my personal `.gitignore` from a gist I keep updated. Assumes you're using the folder structure from `Tools/Setup/Create Folders`.
---
- Tools/Setup/Import Odin Inspector and Serializer
  - Imports Odin Inspector and Serializer (make sure you own the asset and have downloaded it to your system):
    - https://assetstore.unity.com/packages/tools/utilities/odin-inspector-and-serializer-89041
