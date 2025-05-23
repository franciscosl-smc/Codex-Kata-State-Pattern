## ☕ Kata: La Orden del Café — Barista Workflow Edition

Imagina que estás desarrollando el sistema de pedidos de una cafetería artesanal. Cada pedido pasa por distintas etapas desde que se toma la orden hasta que el cliente recibe su café. Tu reto es modelar este flujo utilizando el **patrón State-as-Type**, en el que **cada etapa del pedido se representa con una clase distinta y las transiciones se realizan mediante métodos específicos**.

Tu objetivo es garantizar que:

* Cada pedido solo pueda realizar acciones válidas según su etapa actual (por ejemplo, no se puede entregar un pedido que aún no ha sido preparado).
* Las transiciones entre etapas sean claras y seguras.
* Se sigan buenas prácticas de diseño orientado a objetos, incluyendo el uso de **TDD** y principios de **Object Calisthenics**.

La solución debe ser limpia, expresiva y evitar errores de uso incorrecto del sistema gracias al diseño.

---

### ✅ Requisitos paso a paso

1. **Crear un pedido nuevo** con la información del tipo de café solicitado.
2. **Permitir que un pedido pase a estar en preparación** cuando el barista lo acepta.
3. **Permitir añadir ingredientes** (como leche o sirope) mientras el pedido está en preparación.
4. **Indicar que el pedido está listo para ser recogido** una vez completada la preparación.
5. **Permitir entregar el pedido al cliente** solo cuando esté listo para servir.
6. **Bloquear cualquier acción posterior** una vez que el pedido ha sido entregado.
7. **Impedir cualquier acción que no tenga sentido según la etapa del pedido**.
8. **Mantener los datos relevantes de cada etapa**, como la hora en que comenzó la preparación, los ingredientes añadidos o quién entregó el pedido.
9. **Validar todo el flujo a través de pruebas** construidas antes de cada implementación.
10. **Aplicar principios de diseño orientado a objetos**, evitando estructuras frágiles o de propósito general.
