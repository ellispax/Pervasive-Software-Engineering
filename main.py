import RPi.GPIO as GPIO
import time
from time import sleep
from DB_functions.dbFunctions import *
from OCR.ocr import ocr
from OCR.camera import capture
from SERVO.servo import *


#raspberry pi board setup and pin declarations
GPIO.setmode(GPIO.BOARD)

#IR Sensors
IR_in = 16  #IN
IR_out = 37 #OUT

#LED indicators for the entrance
led_red_in = 18
led_green_in = 19

#LED indicators for the Exit 
led_green_out = 29
led_red_out = 31

#buttons for visitor
button1 = 22
button2 = 33

#Setup the pins as Input and Output according to components
GPIO.setwarnings(False)
GPIO.setup(led_red_in,GPIO.OUT)
GPIO.setup(led_green_in, GPIO.OUT)
GPIO.setup(led_green_out,GPIO.OUT)
GPIO.setup(led_red_out, GPIO.OUT)
GPIO.setup(IR_in,GPIO.IN)
GPIO.setup(IR_out,GPIO.IN)
GPIO.setup(button1, GPIO.IN, pull_up_down = GPIO.PUD_UP)
GPIO.setup(button2, GPIO.IN, pull_up_down = GPIO.PUD_UP)

while (1):
    # GPIO.output(led_green_in, False)
    # GPIO.output(led_green_out, False)
    # GPIO.output(led_red_in, True)
    # GPIO.output(led_red_out, True)

    state=GPIO.input(IR_in)
    if state==False:
        
        time.sleep(1)
        print("Object Detected on IN")
        stamp = get_stamp()
        image = capture(stamp)
        num_plate = ocr(image)
        print(num_plate)
        desig = check(num_plate)

        if desig == 'resident':
            
            insert(num_plate, stamp,desig)
            GPIO.output(led_red_in, False)
            set_angle(180.0)
            print("Gate Opened")
            GPIO.output(led_green_in, True)
            sleep(5)
            set_angle(0.0)
            update_counter_in(desig)
            print("Gate Closed")
            GPIO.output(led_green_in, False)
            
        else:
            print("Please Tap if you are visitor")
    else:
        time.sleep(1)
        GPIO.output(led_red_in, True)