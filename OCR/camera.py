from picamera import PiCamera
from time import sleep


def capture(stamp):
    camera = PiCamera()
    camera.start_preview()
    sleep(5)
    name = '/home/Documents/Project/images/'+stamp+'.jpg'
    camera.capture(name)
    camera.stop_preview()
    return name

