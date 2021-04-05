import pyautogui
import time
import pyperclip


def doa():
    for i in range(0,5):
        print("i = ", i)

def han_write(text):
    pyperclip.copy(text)
    pyautogui.hotkey('ctrl','key')

def find_target(file_name,timeout=10):
    start = time.time()
    while True:
        time.sleep(1)
        end = time.time()
        file_a = pyautogui.locateOnScreen('B.png')
        if file_a is not None : 
            return file_a
        if (end - start) > timeout :
            # print("3초 지남")
            break


# file_a = pyautogui.locateOnScreen('B.png')
# print(file_a)

# pyautogui.click(file_a,duration=2)