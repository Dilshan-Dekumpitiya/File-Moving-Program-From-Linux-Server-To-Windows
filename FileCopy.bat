@echo off

:: Set the path to PuTTY's pscp.exe
set PATH=%PATH%;C:\Program Files\PuTTY

rem Set the path to the private key
set PRIVATE_KEY="D:\Asterisk My Projects\Private Key\private_key.ppk"

rem Set the SSH username and hostname of the Linux server
set USERNAME=dms
set HOSTNAME=172.20.10.100

rem Set the remote directory containing files
set REMOTE_DIR=/var/spool/asterisk/monitor/

rem Set the local directory to save the copied files
set LOCAL_DIR=E:\files

rem Create the local directory if it doesn't exist
if not exist %LOCAL_DIR% mkdir %LOCAL_DIR%

rem Copy all files from the remote directory to the local directory
pscp.exe -i %PRIVATE_KEY% -P 22 %USERNAME%@%HOSTNAME%:%REMOTE_DIR%* %LOCAL_DIR%

pause
