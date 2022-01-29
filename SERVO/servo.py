import time
from time import sleep
import RPi.GPIO as GPIO



#Servo motors
SERVO_IN = 11   #IN
SERVO_OUT = 12  #OUT

#Pin setup
GPIO.setup(SERVO_IN, GPIO.OUT)
GPIO.setup(SERVO_OUT, GPIO.OUT)

hertz = 50

def set_angle(angle):
    # calculate the duty cycle
    duty_cycle = (float(angle)/24.0) + 2.5
    # activate the servo pin
    GPIO.output(SERVO_IN, True)
    # change the duty cycle to calculated value
    pwm.ChangeDutyCycle(duty_cycle)
    # send signal 0.5 seconds
    sleep(2)
    # deactivate the servo pin
    GPIO.output(SERVO_IN, False)
    # change the duty cycle to 0
    pwm.ChangeDutyCycle(0)
    # print the duty cycle
    # print(duty_cycle);

def set_angle2(angle):
    # calculate the duty cycle
    duty_cycle = (float(angle)/24.0) + 2.5
    # activate the servo pin
    GPIO.output(SERVO_OUT, True)
    # change the duty cycle to calculated value
    pwm2.ChangeDutyCycle(duty_cycle)
    # send signal 0.5 seconds
    sleep(2)
    # deactivate the servo pin
    GPIO.output(SERVO_OUT, False)
    # change the duty cycle to 0
    pwm2.ChangeDutyCycle(0)
    # print the duty cycle
    # print(duty_cycle);



pwm = GPIO.PWM(SERVO_IN, hertz)
# Then start it with 0 duty cycle so it doesn't set any angles on startup
pwm.start(0.0)

pwm2 = GPIO.PWM(SERVO_OUT, hertz)
# Then start it with 0 duty cycle so it doesn't set any angles on startup
pwm2.start(0.0)

# Set angle to 90 degree
set_angle(90)
set_angle2(90)