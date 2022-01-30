import requests
import base64
import json

#this is connected to the OPEN ALPR API that is used for licence plate recognition
#Add your secret Key and Change country code in the URL (mine is id for Indonesia)
def ocr(IMAGE_PATH):
    SECRET_KEY = 'Secret Key'
    with open(IMAGE_PATH, 'rb') as image_file:
        img_base64 = base64.b64encode(image_file.read())

    url = 'https://api.openalpr.com/v2/recognize_bytes?recognize_vehicle=1&country=id&secret_key=%s' % (SECRET_KEY) 
    r = requests.post(url, data = img_base64)
    try:
        return(r.json()['results'][0]['plate']) #returns the number plate string
        
    except:
        print("No number plate found")
        return 'll-nnnn-ll'

