# Decorator Pattern – Ejemplo Café ☕

Este repositorio contiene un ejemplo simple y didáctico del **patrón de diseño Decorator**, implementado en **C#**.

El objetivo es mostrar cómo agregar funcionalidades a un objeto de forma dinámica, sin modificar su clase original.

---

## 🧠 ¿Qué es el patrón Decorator?

El patrón Decorator permite:

- Agregar responsabilidades a un objeto **en tiempo de ejecución**
- Evitar la creación de múltiples subclases
- Mantener el principio **Open/Closed** (abierto para extensión, cerrado para modificación)

Es una alternativa flexible a la herencia.

---

## 🧩 Ejemplo del repositorio

### 📌 Escenario
- Tenemos un **Café simple**
- Podemos agregarle ingredientes opcionales:
  - Leche
  - Azúcar
- Cada agregado:
  - Modifica la descripción
  - Incrementa el precio

Cada ingrediente se implementa como un **decorador**.

---

## 🧱 Estructura del patrón en el código

| Rol del patrón | Clase |
|---------------|------|
| Component | `Cafe` |
| ConcreteComponent | `CafeSimple` |
| Decorator | `CafeDecorator` |
| ConcreteDecorator | `ConLeche`, `ConAzucar` |
| Client | `Program` |

---

## 🔁 Funcionamiento

Los decoradores envuelven al objeto base y delegan el comportamiento, agregando funcionalidad extra:

```csharp
Cafe pedido = new CafeSimple();
pedido = new ConLeche(pedido);
pedido = new ConAzucar(pedido);

