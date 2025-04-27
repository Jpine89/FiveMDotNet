This is just a Empty Script to give context on how to start a FiveM Script in Dotnet. 

More will be added and better examples given as I get to it. 


---------------------------------------

This would be added to the csproj of both Client/Server projects. 
This allows you to point your project build to your test server or any folder you would want the resource files to end up.

In the example below we created a Environment Variable, called "FIVEM_SERVER_PATH" which targets a specific folder on your machine.
This just allows you to easily target your fiveM folders without having to hardcode the path in. 
<pre>
	```csharp
	<Target Name="PostBuild" AfterTargets="PostBuildEvent">
		<Exec Command="xcopy /f /r /y /i bin\Debug ..\build\client&#xD;&#xA;xcopy /f /r /y /i ..\resource-files ..\build" Condition="'$(Configuration)' == 'Debug'" />
		<Exec Command="xcopy /f /r /y /i bin\Release ..\build\client&#xD;&#xA;xcopy /f /r /y /i ..\resource-files ..\build" Condition="'$(Configuration)' == 'Release'" />
		<Exec Command="xcopy /f /r /y /i bin\Debug $(FIVEM_SERVER_PATH)\resources\<Script Project Name>\client&#xD;&#xA;xcopy /f /r /y /i ..\resource-files $(FIVEM_SERVER_PATH)\resources\<Script Project Name>\" Condition="'$(Configuration)' == 'Debug'" />
	</Target>
	```
</pre>
