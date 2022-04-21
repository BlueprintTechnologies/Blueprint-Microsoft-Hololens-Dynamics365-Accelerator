# MixedReality Development on Hololens AR
Research and Development on Microsoft Mixed Reality

1) Checkout source code https://github.com/BlueprintConsulting/MixedReality

2) Install Unity Hub

3) Run Unity Hub. 
   Select the latest Unity build from Official Releases.
   Select both UWP components
   Select Visual Studio 2017 Community if it's not on your PC
   Download and install

3.5) Install Visual Studio Tools for Unity: https://docs.microsoft.com/en-us/visualstudio/cross-platform/visual-studio-tools-for-unity?view=vs-2017 
   
4) Run Unity and open project CRM

5) Goto Files -> Build Settings, switch Platform to Universal Windows Platform, Target: Hololens

6) Build and Select "App" as the folder

7) Goto App folder, open CRM solution in Visual Studio
   Start without Debugging
   The new app will be deployed to Remote Devices (HoloLens)