import pyautogui
import time

start = time.time()
print('start',start)
time.sleep(3)
end = time.time()
print('end',end)

def find_target(file_name):
    while True:
        time.sleep(1)
        end = time.time()
        #print('end',end)
        file_a = pyautogui.locateOnScreen('B.png')
        # print(file_a)
        if file_a is not None : 
            # print("찾음")
            # pyautogui.click(file_a)
            return file_a

        if (end - start) > 10 :
            # print("3초 지남")
            break

box = find_target('A.png')
pyautogui.click(box)
    


# file_a = pyautogui.locateOnScreen('B.png')
# print(file_a)

# pyautogui.click(file_a,duration=2)