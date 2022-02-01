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
BS1 = False
BS2 = False

while (1):
    # GPIO.output(led_green_in, False)
    # GPIO.output(led_green_out, False)
    # GPIO.output(led_red_in, True)
    # GPIO.output(led_red_out, True)

    state_IN=GPIO.input(IR_in)
    if state_IN==False:
        
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
            print("Please Press Button if you are visitor")
            if GPIO.input(button1) == 0:
                if BS1 == False:
                    insert(num_plate, stamp, desig)
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
        time.sleep(1)
        GPIO.output(led_red_in, True)
    
    state_OUT = GPIO.input(IR_out)

    if state_OUT == False:
        
        time.sleep(1)
        print("Object Detected on out")
        image_out = capture(get_stamp())
        numPlate = ocr(image_out)

        #num_plate = ocr(path)
        #num_plate = 'B2743TZA'
        #np = 'B9674S'
        idx = get_idxout(numPlate)
        proceed, desig = checkExt(idx)
        if proceed == 'go':
            GPIO.output(led_green_out, True)
            set_angle2(180.0)
            print("Gate Opened")
            sleep(5)
            update_out(idx)
            set_angle2(0.0)
            print("Gate Closed")
            GPIO.output(led_green_out, False)
            update_counter_out(desig)
        else:
            print('Error on Exit Check Db or use manual exit')
        
        
        
    else:
        time.sleep(1)
        GPIO.output(led_red_out, True)
        