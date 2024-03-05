# File-Moving-Program-From-Linux-Server-To-Windows
This project was created for the purpose of implementing a file-moving program from a Linux server to a local Windows path

## Steps

1. Install Putty in C:\Program Files\PuTTY location

2. Generate SSH Key Pair: Use PuTTYgen to generate a public/private key pair. (To connect remote server)

      - Open PuTTYgen.
      - Click "Generate" and follow the instructions to generate the key pair.
      - Save the private key (usually with a .ppk extension) in local machine and the public key in remote server.

 3. Copy Public Key to Server:

    - Copy the contents of the public key (from PuTTYgen) to the ~/.ssh/authorized_keys file on the Linux server.

 4. Change all the variables as desired

### IDE

- Visual Studio

#### NOTE : After publishing this project and setting the executable file in the Windows Task Scheduler, it can be run as a scheduled task.
