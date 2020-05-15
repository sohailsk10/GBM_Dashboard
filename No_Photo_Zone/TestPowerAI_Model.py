import json
import time
import requests
import cv2
import numpy as np
import urllib3

urllib3.disable_warnings()
print("Warning: Certificates not verified!")

# api_url = "https://10.150.20.65/powerai-vision/api/dlapis/5c36258e-cab1-4ac1-b8dc-623648010d68"
api_url = "https://195.229.90.114/powerai-vision/api/dlapis/cee4ba40-fb3a-4ce4-b09b-ebeb585b0f0f"

def show(image, path):
    data = {}
    SminX, SminY, SmaxX, SmaxY = 0, 0, 0, 0
    MminX, MminY, MmaxX, MmaxY = 0, 0, 0, 0
    with open(path, 'rb') as f:
        s = requests.Session()
        r = s.post(api_url, files={'files': (path, f)}, verify=False)

    if r.text is not None:
        data = json.loads(r.text)

    if data['result'] != 'fail':
        testdata = data["classified"]
        print(type(testdata), testdata)
        if len(testdata) >= 2:
            pass

        for counter in range((len(testdata))):
            if testdata[counter].get('label') == 'system':
                SminX = int(testdata[counter].get('xmin'))
                SminY = int(testdata[counter].get('ymin'))
                SmaxX = int(testdata[counter].get('xmax'))
                SmaxY = int(testdata[counter].get('ymax'))
                cv2.rectangle(image, (SminX, SminY), (SmaxX, SmaxY), (0, 255, 0), 2)

            elif testdata[counter].get('label') == 'mobile':
                MminX = int(testdata[counter].get('xmin'))
                MminY = int(testdata[counter].get('ymin'))
                MmaxX = int(testdata[counter].get('xmax'))
                MmaxY = int(testdata[counter].get('ymax'))
                cv2.rectangle(image, (MminX, MminY), (MmaxX, MmaxY), (0, 255, 0), 2)

        if MminY >= SminY - 20 and MmaxY <= SmaxY + 20:
            cv2.putText(image, "alert!", (50, 50), cv2.FONT_HERSHEY_COMPLEX_SMALL, 1, (0, 255, 0), 1)

        cv2.imwrite("output.jpg", image)
        print(SminX, SminY, SmaxX, SmaxY, MminX, MminY, MmaxX, MmaxY)
        cv2.imshow('image', image)
        cv2.waitKey(1)

path = "frames\\00438.jpg"
image = cv2.imread(path)
show(image, path)



