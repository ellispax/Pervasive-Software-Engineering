# Pervasive-Software-Engineering
Smart-Residence Parking System

# Raspberry-Pi Codes
This branch contains the codes that will run on the raspberry pi in order to control the automatic gate system for the residence.

# How to Use:
Install MySQL Connector, RPi.GPIO and enable the camera on your raspberry pi.

Connect the components as in the diagram provided in the repo (schematic.png).
Components included are (Raspberry Pi 4, 2x Servo, 2xIR Sensors, 2x Red LEDs, 2x Green LEDs, 1x Push Button, 2x Camera, Breadboard, Connecting wires, resistors)

Configure your database on your server, Either cloud or localhost and specify the credentials in dbConnect.py located in the DB_Functions folder. (DB Structure files provided in the repo)

Register for a free account on Open ALPR for their license plate recognition API and get the secret key. Paste the secret key in the OCR.py file and change the country code according to your country.

Run main.py 

