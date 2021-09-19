rem MainRVTest.bat
@echo off
MainRVTest
@if "%ERRORLEVEL%" == "0" goto good
:fail1
    echo Execution Failed
    echo return value = %ERRORLEVEL%
    goto end1
:good1
    echo Execution Succeeded
    echo return value = %ERRORLEVEL%
    goto end
:end1
MainRVTest  Mary
@if "%ERRORLEVEL%" == "0" goto good0
:fail0
    echo Execution Failed
    echo return value = %ERRORLEVEL%
    goto end0
:good0
    echo Execution Succeeded
    echo return value = %ERRORLEVEL%
    goto end0
:end0
