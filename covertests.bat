set TESTTOOLPATH="D:\DevFactory\Git\FirewallForCode\shared\Microsoft.Net\DevFactory.Library\packages\OpenCover.4.6.166\tools"

rm -fr TestResults

rm results.xml

%TESTTOOLPATH%\opencover.console.exe -register:user -mergebyhash -skipautoprops -target:"D:\ProjetosGit\FramesharpUniversity-CSharp\runtests.bat"