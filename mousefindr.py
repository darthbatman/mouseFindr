import sys, string, os, win32api, win32con, time
from threading import Timer

def checkMouse():
    xCur, yCur = win32api.GetCursorPos()
    global firstTime
    global xCurP
    global yCurP
    if firstTime:
        xCurP = xCur
        yCurP = yCur
        firstTime = False
    else:
        print (xCurP - xCur) * (xCurP - xCur) + (yCurP - yCur) * (yCurP - yCur)
        if ((xCurP - xCur) * (xCurP - xCur) + (yCurP - yCur) * (yCurP - yCur)) > 640000:
            os.system("mousepointer.exe")
        xCurP = xCur
        yCurP = yCur
    t = Timer(0.2, checkMouse)
    t.start()

xCurP = 0
yCurP = 0
firstTime = True
t = Timer(0.2, checkMouse)
t.start()
