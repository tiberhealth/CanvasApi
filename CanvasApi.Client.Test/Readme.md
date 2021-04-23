# Instructions for using CanvasAPI Tests



The Canvas API tests use user-secrets to get the information about the Test Canvas API to test against. 



To setup the Canvas Test, you will need to setup the User Secrets on your workstation. 



Navigate to the CanvasApi.Client.Test source directory using your command editor.

Add the user secrets to your workstation for this project.

``` 
dotnet user-secrets set CanvasHost "https://canvas.rolesvillesoftware.com"
dotnet user-secrets set TestCanvasApiToken "<<Your Canvas API Token here>>"
```



To see what secrets are set for your workstation

```
dotnet user-secrets list
```



