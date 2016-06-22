# arduinoUnity_IMU
Streaming IMU Arduino data into Unity

Uses IMU to get pitch, yaw, and roll to change orientation in Unity.

All calculations are done on Arduino, and Unity simply parses the serial stream and changes the rotation of the gameobject in the scene.

I am using Sparkfun's 9 Degrees of Freedom IMU Breakout - LSM9DS1 found here:
https://www.sparkfun.com/products/13284
