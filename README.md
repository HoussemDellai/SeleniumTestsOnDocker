Sample code to run Selenium UI tests in Docker containers.
Read the full article here:
https://medium.com/@HoussemDellai/run-selenium-ui-tests-in-docker-containers-f41ae2796b8d


docker run -d -p 4444:4444 -p 5900:5900 -v /dev/shm:/dev/shm selenium/standalone-chrome-debug:3.141.59-yttrium


dotnet test -s .runsettings -- RunConfiguration.remoteWebDriverUrl="http://selenium-hub:4444/wd/hub"