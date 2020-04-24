import pynput
from pynput.keyboard import Key, Listener


def on_press(key):
    print(key + " was pressed")

def on_release(key):
    if key == key.esc:
        return False
    

with Listener(on_press=on_press, on_release=on_release) as listener:
    listener.join()