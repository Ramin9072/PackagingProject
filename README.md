# PackagingProject 


follow this step to create package for nuget server for .Net Framework Projects.
- You can download Nuget from this site https://www.nuget.org/downloads.
- install Nuget on your PC.
- Now copy nuget.exe and place it in a specified folder on your computer.
- Create Environment variable and name it as nuget.
- Now create a .NetFramework project and then create a .NetFramework dll inside it.
- Now you have to go to the folder where you want to create the dll related to your package and use the ( nuget spec ) command in 
  - powershell to create the XML file related to your DLL specifications.
  - Open XML file and replace with the following file 
```
 <package>
  <metadata>
    <id>Package</id>
    <version>1.0.0</version>
    <authors>YourUsername</authors>
    <owners>YourUsername</owners>
    <license type="expression">MIT</license>
    <projectUrl>http://PROJECT_URL_HERE_OR_DELETE_THIS_LINE</projectUrl>
    <iconUrl>http://ICON_URL_HERE_OR_DELETE_THIS_LINE</iconUrl>
    <requireLicenseAcceptance>false</requireLicenseAcceptance>
    <description>Package description</description>
    <releaseNotes>Summary of changes made in this release of the package.</releaseNotes>
    <copyright>Copyright 2019</copyright>
    <tags>Tag1 Tag2</tags>
  </metadata>
</package> 
```

Save it.
Open powershell  again and type ( nuget pack )

that's it you make a nuget package for .Net Framework

WELL DONE :clap::clap::clap:
