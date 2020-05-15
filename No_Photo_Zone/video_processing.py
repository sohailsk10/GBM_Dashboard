import os
import json
import glob
import requests
import cv2
import argparse
import urllib3
from datetime import datetime
from database_entry import entry_to_db

urllib3.disable_warnings()
print("[INFO] Warning: Certificates not verified!")

num = 0
img_array = []
size = []
no_of_videos = 0
videos = []
original_list = []
inserted = False
camera_stop = False
# api_url = "https://10.150.20.65/powerai-vision/api/dlapis/d3d5e84e-7b8a-42d5-acd7-30899dce3aa7"
api_url = "https://195.229.90.114/powerai-vision/api/dlapis/12b51a15-41f8-47a0-bde7-5b73b786a5f7"


def preprocess():
    # if not os.path.exists('no_photo_zone_input'):
    #     os.makedirs('no_photo_zone_input')
    if not os.path.exists('no_photo_zone_output'):
        os.makedirs('no_photo_zone_output')
    for imagepath1 in glob.glob('no_photo_zone_input\\*.jpg'):
        os.remove(imagepath1)
    for imagepath2 in glob.glob('no_photo_zone_output\\*.jpg'):
        os.remove(imagepath2)


def create_video(video_name, video_violation_list, fps):
    print("[INFO] creating video")
    no_of_videos = 0

    for v in video_violation_list:
        s = (0, 0)
        start_frame, end_frame = v[0], v[1]
        violation_no = "violation_" + str(no_of_videos)

        for fn in range(start_frame, end_frame):
            if start_frame <= end_frame:
                file_name = "no_photo_zone_output" + os.sep + str(fn) + ".jpg"
                img = cv2.imread(file_name)
                try:
                    h, w, l = img.shape
                    s = (w, h)
                    img_array.append(img)
                except AttributeError:
                    break
            else:
                break

        if not os.path.exists(
                "processed_video" + os.sep + video_name.split(".")[-2].split("\\")[
                    -1] + os.sep + datetime.now().strftime(
                    "%Y") + os.sep + datetime.now().strftime("%m") + os.sep + datetime.now().strftime(
                    "%d") + os.sep + datetime.now().strftime("%H") + os.sep + violation_no):
            os.makedirs(
                "processed_video" + os.sep + video_name.split(".")[-2].split("\\")[
                    -1] + os.sep + datetime.now().strftime(
                    "%Y") + os.sep + datetime.now().strftime("%m") + os.sep + datetime.now().strftime(
                    "%d") + os.sep + datetime.now().strftime("%H") + os.sep + violation_no)

        violation_video = video_name.split(".")[-2].split("\\")[-1] + "_violation" + str(no_of_videos) + '.mp4'
        vv_path = "processed_video" + os.sep + video_name.split(".")[-2].split("\\")[
            -1] + os.sep + datetime.now().strftime(
            "%Y") + os.sep + datetime.now().strftime("%m") + os.sep + datetime.now().strftime(
            "%d") + os.sep + datetime.now().strftime("%H") + os.sep + violation_no + os.sep + violation_video
        print("Video Violtion path", vv_path)
        out_file = cv2.VideoWriter(vv_path, cv2.VideoWriter_fourcc(*'mp4v'), fps, s)

        for j in range(len(img_array)):
            out_file.write(img_array[j])

        vf_name = video_name.split(".")[-2].split("\\")[-1] + "_violation_frame_" + str(no_of_videos) + ".jpg"
        vf_path = "processed_video" + os.sep + video_name.split(".")[-2].split("\\")[
            -1] + os.sep + datetime.now().strftime(
            "%Y") + os.sep + datetime.now().strftime("%m") + os.sep + datetime.now().strftime(
            "%d") + os.sep + datetime.now().strftime("%H") + os.sep + violation_no + os.sep + vf_name
        print(vf_path)
        cv2.imwrite(vf_path, img_array[(len(img_array) // 2)])

        # TODO: Make entry in mysql datbase
        print("============================================================================================================")
        cwd = os.getcwd() + "\\"
        print(cwd.replace("\\", "\\\\") + "video_for_process\\\\")
        print(video_name)
        print(cwd.replace("\\", "\\\\") + "video_for_process\\\\" + video_name)
        print(cwd.replace("\\", "\\\\") + vv_path.replace("\\", "\\\\"))
        print(cwd.replace("\\", "\\\\") + vf_path.replace("\\", "\\\\"))
        print("============================================================================================================")
        entry_to_db(cwd.replace("\\", "\\\\") + "video_for_process\\\\", video_name, cwd.replace("\\", "\\\\") + "video_for_process\\\\" + video_name, cwd.replace("\\", "\\\\") + vv_path.replace("\\", "\\\\"), cwd.replace("\\", "\\\\") + vf_path.replace("\\", "\\\\"))

        out_file.release()
        img_array.clear()
        no_of_videos += 1


def parse_args():
    desc = 'Capture and display offline video'
    parser = argparse.ArgumentParser(description=desc)
    parser.add_argument('--filepath', dest='filepath', type=str, help='Enter a file Path to pprocess.')
    args = parser.parse_args()
    return args


def show(frame, fps):
    global num, camera_stop, inserted
    data = {}
    SminX, SminY, SmaxX, SmaxY = 0, 0, 0, 0
    MminX, MminY, MmaxX, MmaxY = -100, -100, -100, -100
    cv2.imwrite("image.jpg", frame)
    with open("image.jpg", 'rb') as f:
        s = requests.Session()
        r = s.post(api_url, files={'files': ("image.jpg", f)}, verify=False)

    if r.text is not None:
        data = json.loads(r.text)

    if data['result'] != 'fail':
        testdata = data["classified"]

        for counter in range((len(testdata))):
            if testdata[counter].get('label') == 'system':
                SminX = int(testdata[counter].get('xmin'))
                SminY = int(testdata[counter].get('ymin'))
                SmaxX = int(testdata[counter].get('xmax'))
                SmaxY = int(testdata[counter].get('ymax'))
                # cv2.rectangle(image, (SminX, SminY), (SmaxX, SmaxY), (0, 255, 0), 2)
                # cv2.putText(image, str(testdata[counter].get('label')), (SminX, SminY + 10),
                # cv2.FONT_HERSHEY_COMPLEX_SMALL, 1, (255, 0, 0), 1)

            elif testdata[counter].get('label') == 'mobile':
                MminX = int(testdata[counter].get('xmin'))
                MminY = int(testdata[counter].get('ymin'))
                MmaxX = int(testdata[counter].get('xmax'))
                MmaxY = int(testdata[counter].get('ymax'))
                # cv2.rectangle(image, (MminX, MminY), (MmaxX, MmaxY), (0, 255, 0), 2)
                # cv2.putText(image,
                # str(testdata[counter].get('label')), (MminX, MminY + 10), cv2.FONT_HERSHEY_COMPLEX_SMALL, 1, (255,
                # 0, 0), 1)

        if MminY >= SminY - 30 and MmaxY <= SmaxY - 10:
            cv2.putText(frame, "Taking photo", (50, 50), cv2.FONT_HERSHEY_COMPLEX_SMALL, 3, (0, 0, 255), 2)
            if not inserted:
                videos.append([num - int(fps * 2), num + int(fps * 3)])
                inserted = True
        else:
            inserted = False

        cv2.imshow('image', frame)
        key = cv2.waitKey(1)
        if key == ord('q'):
            camera_stop = True
        cv2.imwrite("no_photo_zone_output\\" + str(num) + ".jpg", frame)
        num += 1


def list_slicing(video_list, original_list):
    if not video_list == []:
        start = video_list[0][0]
        end = video_list[0][1]
        original_list.append([start, end])
        video_list.pop(0)
        counter = 0

        for i in range(len(video_list)):
            i += counter
            if start < video_list[i][0] < end:
                video_list.remove(video_list[i])
                counter -= 1

        list_slicing(video_list, original_list)


def main(video_path):
    print("[INFO] in main with " + video_path)
    video = cv2.VideoCapture(video_path)
    FPS = video.get(cv2.CAP_PROP_FPS)
    while not camera_stop:
        ret, image = video.read()
        if not ret:
            print("[INFO] Done detecting.")
            list_slicing(videos, original_list)
            # Writing in csv
            # print("[INFO] Writing Vidoes List in csv")
            # for i in original_list:
            #     print(i)
            #     with open("videos_list.csv", "a+") as file:
            #         writer = csv.writer(file)
            #         writer.writerow([i])
            #         end writing
            create_video(video_path.split("\\")[-1], original_list, FPS)
            break
        show(image, FPS)
    video.release()
    cv2.destroyAllWindows()


preprocess()
# main("processed_video\\Video2_20sec.mp4")    # TODO: Remove this line in production


