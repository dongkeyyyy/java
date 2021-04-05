import pyautogui
import time
import myfunc as mf

time.sleep(2)


pyautogui.hotkey('win','r')
pyautogui.write('mspaint')
pyautogui.hotkey('enter')

time.sleep(2)

window = pyautogui.getWindowWithTitle('제목 없음 - 그림판')[0]  # 그림판이 2개가 실행되있을경우 제일 첫번째에 실행된 그림판에 실행한다
time.sleep(1)
window.maximize()

# pyautogui.moveTo(332,73,duration=2)
# pyautogui.click(332,73)  마우스 커서로 할려다가 안되던거

box = pyautogui.locateOnScreen('FONT.PNG')
pyautogui.click()

time.sleep(1)
myfunc.han_write('참 잘했어요')



time.sleep(3)
window.close()