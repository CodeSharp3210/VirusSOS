import os
from flask import Flask, request

app = Flask(__name__)
SAVE_FOLDER = r"C:\Users\Nonna\Desktop\Progetti\VirusSOS\Server\Contenuto"
os.makedirs(SAVE_FOLDER, exist_ok=True)

@app.route('/upload', methods=['POST'])
def upload_text():
    testo = request.form.get('testo')
    if not testo:
        return "Nessun testo ricevuto", 400
    print("Consegna:")
    print(testo)

    return "Testo salvato con successo!", 200

if __name__ == "__main__":
    app.run(host="0.0.0.0", port=5000)