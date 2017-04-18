FROM microsoft/aspnet:4.6.2
ARG source
WORKDIR /inetpub/wwwroot
COPY ${source:-obj/Docker/publish} .

# Enable WCF 
#RUN powershell -Command Add-WIndowsFeature NET-WCF-HTTP-Activation45

# Add Some Registry
# RUN set-itemproperty -path 'HKLM:\SYSTEM\CurrentControlSet\SomeService\SomeNode' -Name SomeConfig -Value 0 -Type DWord

# Add Some Component
#RUN msiexec SomeComponent














SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop';"]
RUN set-itemproperty -path 'HKLM:\SYSTEM\CurrentControlSet\Services\Dnscache\Parameters' -Name ServerPriorityTimeLimit -Value 0 -Type DWord