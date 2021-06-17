# Ransom
This is NT230 class - laboratory project for educational purposes only.

# Note
The launcher is disguised under MS Word icon. It will download from attacker server the ransomware hence the ransomware need to be built and hosted on the attacker server. After the downloading has completed, the ransomware will be invoked and the launcher will kill itself.
This application has been checked by VirusTotal:
- launcher: https://www.virustotal.com/gui/file/3d93c21358b8002e2e2afec8f7cca4291cce3147fd1b3b89b0cf5b7dba4927dd/
- ransomware: https://www.virustotal.com/gui/file/d9cdfd94e109da2f89b505b041360eca35054a3144e8d3cab13b4be541ecd48a/

# Future study
## Key storage
One of the most important factor to the ransomware is how it get and how it stores the key. This is a note for myself to future improvement for this project.
In this project, I created a launcher which will download and execute the ransomware. While encryption phase, the ransomware will also encrypted the launcher and itself if we set to MASS INFECTION mode (or manually modify the target directory/location). By that, in my opinion, victim can not reverse the program to get the encryption key. Alternatively, we could kill the ransomware by having it overwriting itself with random bytes. However, there are better ways to store ransomware's key.
After some discussion with my friends and peers, I come up with 2 ways to store ransomware's key more efficiently:
- Using 2 different keys: 1 symmetric key for encryption + 1 asymmetric key (public key) to encrypt the symmetric key. The private key will be sent to user once they pay the ransom.
- Ransomware won't initially have the key but retrieving it from the hacker server.
- Rebuild this application by C/C++ as mentioned by my mentor that, in Visual Studio 2019, the Ransomware built by C++ would cause trouble for programmer to reverse the program due to the difference in code between reverse version and building version.

# Reference
\[1\]   [How to create ENCRYPTING RANSOMWARE in visual studio (C#)](https://www.youtube.com/watch?v=UfHgALGjtJs)
