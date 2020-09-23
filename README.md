# EasyAMP -- A quick & dirty extended control panel for XAMPP users.
## How does it works?
This program currently provides the following funtions:
- start/stop the Apache & MySQL servers.
- Create the apache virtual host settings with only one click.
- Copy Laravel starter project to virtual host web root.
- Navigate to web site on each virtual host.
- Go to the server root directory with windows file manager.

## Configuration
1. First you need to install XAMPP with all default option (this is important). 
XAMPP can be downloaded here: https://www.apachefriends.org/zh_tw/download.html

2. Start XAMPP by running xampp-control.exe in XAMPP directory with **admin privilege**, and check Apache and MySQL service buttons to install services.
<img src="https://github.com/poorworm/easyamp/blob/master/EasyAMP/images/xampp_service.png?raw=true" width="300">

3. **Uncheck** readonly checkbox in 'C:\Windows\System32\drivers\etc\hosts' file' s file attributes.
<img src="https://github.com/poorworm/easyamp/blob/master/EasyAMP/images/hosts_file_attributes.png?raw=true" width="250">

4. Some anti-virus program might deny the access to the hosts file, and you need to exclusion our EasyAMP.exe from anti-virus software which is risky.

## User Guide

### Home Screen
<img src="https://github.com/poorworm/easyamp/blob/master/EasyAMP/images/home_screen.png?raw=true" width="500">

### Virtual Host Add/Remove
<img src="https://github.com/poorworm/easyamp/blob/master/EasyAMP/images/vhost.png?raw=true" width="300">


## TODOS
- [ ] Function to switch between PHP versions
- [ ] Function to switch between database (MySQL, PostgresSQL, SQLite ... )
- [ ] Quick open project with PHPStorm, VSCode, Sublime, PphEd ...
