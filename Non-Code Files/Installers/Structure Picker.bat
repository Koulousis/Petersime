REM Copying folder
SET Source="J:\Drawings REVIT FAMILIES\02 NEW\Aris\Addins\Tools\Structure Picker"

REM Apllired folder
SET Destination="%UserProfile%\AppData\Roaming\Autodesk\Revit\Addins\2022"

REM S - Copies folders and subfolders recursively excluding the empty one
REM H - Copy hidden and system files and directories. The default value is N
REM C - Ignores errors and forces the command to continue copying
REM Y - Suppresses the confirmation to overwrite destination file if exists

REM [source] [destination] [options]
XCOPY %Source% %Destination% /S /H /C /Y

MSG * "Revit 2022: Structure Picker - Applied" 
