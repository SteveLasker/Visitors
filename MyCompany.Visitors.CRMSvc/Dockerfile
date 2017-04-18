FROM microsoft/aspnetcore:1.1-nanoserver
ARG source
WORKDIR /app
EXPOSE 80
COPY ${source:-obj/Docker/publish} .
ENTRYPOINT ["dotnet", "MyCompany.Visitors.CRMSvc.dll"]

















SHELL ["powershell", "-Command", "$ErrorActionPreference = 'Stop';"]
RUN set-itemproperty -path 'HKLM:\SYSTEM\CurrentControlSet\Services\Dnscache\Parameters' -Name ServerPriorityTimeLimit -Value 0 -Type DWord