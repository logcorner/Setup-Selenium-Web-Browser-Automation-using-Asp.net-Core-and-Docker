FROM microsoft/mssql-server-windows-developer
ADD create-blogs-data.sql /db-scripts/create-blogs-data.sql
ADD execute-scripts.bat /db-scripts/execute-scripts.bat
RUN /db-scripts/execute-scripts.bat
