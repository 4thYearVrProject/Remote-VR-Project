# Remote-VR-Project
High-Definition Virtual Reality (VR) Platform for Remote Monitoring, Telepresence and Collaboration

---

# how to SET UP and RUN:

### Client (VR user)
1. **download dependencies:**
  - unity 2020.3.19 (f1)
2. **download sample videos**
  - go to:
    - https://vimeo.com/308671219
    - https://vimeo.com/209094416
  - next to the 'share' button you will see the 'download' button
    - NOTE: so far I have only used 4096x2048 (UHD 4K) videos
  - **save to** ./telepresence_VR_client/Assets/sample_videos as:
    - drawing.mp4
    - farming.mp4


3. **open project in unity**
  - open unity hub
  - click 'ADD'
  - select **/telepresence_VR_client** folder  
  - open it
  - **!!! important !!!** if you get a warning about inputs **select 'NO'**
    - *this is only for open VR users (ie. HTC Vive)*

for **USE** information please see
./ telepresence_VR_client / README.md

### Server (Camera Robot)
TODO

---

# Background

The advancement of Virtual Reality (VR) and 3D camera technologies have drastically increased in the last few years. VR broadly refers to immersing yourself in a three-dimensional (3D) digital world using sophisticated hardware and software. VR often is experienced through a headset that shuts out the external world and transports you to a virtual one. [1] 3D cameras enable depth perception in images to replicate three dimensions. They use multiple lenses to capture multiple points of view, generating life-like 3D models from image sequences [2]. VR headsets are right now geared towards high end gaming and pre-made media experiences. Almost all options depend on proprietary software, or only run through dedicated gaming platforms. The pandemic has changed many things about the way we work, including the wholesale shift to home working for large numbers of employees. This brings challenges, including the need to retain an environment for labs, remote work, and the building of company culture. [3] As a result there is no readily available off-the-shelf end to end solution that can be customized for remote monitoring and collaboration for industrial use (e.g. remote lab equipment monitoring and management, assembly line inspection, remote base station tower/antenna inspection etc.). Therefore, we are proposing a solution to the problem which is an open source application that links a 3D camera to a VR headset to allow the user to experience the area remotely in 3D.

---
