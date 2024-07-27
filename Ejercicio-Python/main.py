import tkinter as tk
from tkinter import ttk  # Importamos ttk para widgets más modernos

def calcular(operacion):
    try:
        num1 = int(entry1.get())
        num2 = int(entry2.get())

        if operacion == "multiplicacion":
            resultado = num1 * num2
        elif operacion == "division":
            if num2 != 0:
                resultado = num1 / num2
            else:
                resultado = "Error: División por cero"

        resultado_label.config(text=f"Resultado: {resultado}")
    except ValueError:
        resultado_label.config(text="Error: Ingresa números válidos")

# Configuración de la ventana principal
window = tk.Tk()
window.title("Calculadora Python")
window.geometry("300x250")  # Tamaño inicial de la ventana
window.resizable(False, False)  # Deshabilita el redimensionamiento

# Estilo visual
style = ttk.Style()
style.theme_use("clam")  # Tema visual más moderno

# Widgets
frame = ttk.Frame(window, padding="10")  # Marco para organizar los widgets
frame.grid(row=0, column=0, sticky=(tk.W, tk.E, tk.N, tk.S))

ttk.Label(frame, text="Número 1:").grid(row=0, column=0, sticky=tk.W)
entry1 = ttk.Entry(frame)
entry1.grid(row=0, column=1, sticky=(tk.W, tk.E))

ttk.Label(frame, text="Número 2:").grid(row=1, column=0, sticky=tk.W)
entry2 = ttk.Entry(frame)
entry2.grid(row=1, column=1, sticky=(tk.W, tk.E))

btn_multiplicar = ttk.Button(frame, text="Multiplicar", command=lambda: calcular("multiplicacion"))
btn_multiplicar.grid(row=2, column=0, columnspan=2, pady=10, sticky=(tk.W, tk.E))

btn_dividir = ttk.Button(frame, text="Dividir", command=lambda: calcular("division"))
btn_dividir.grid(row=3, column=0, columnspan=2, sticky=(tk.W, tk.E))

resultado_label = ttk.Label(frame, text="")
resultado_label.grid(row=4, column=0, columnspan=2, pady=10)

# Ajustar el tamaño de las columnas
window.columnconfigure(0, weight=1)
frame.columnconfigure(1, weight=1)

window.mainloop()
