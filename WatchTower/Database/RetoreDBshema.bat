@ECHO OFF
SET /P reply="Override DATABASE ?" 
IF not "%reply%"=="Y" GOTO Error

echo .read schema.sql | sqlite3.exe ..\bin\Debug\WatchTower.db

@ECHO OFF
SET /P reply=Done! 
IF not "%reply%"=="zzzzz" GOTO Error 