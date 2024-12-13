# INVOITRADE CHALLENGE

Este proyecto consiste en mejorar y refactorizar el código de un sistema que gestiona el descuento de diferentes tipos de documentos financieros. El objetivo principal es hacer el código más limpio, fácil de entender y adaptable para futuras funcionalidades, además de implementar las nuevas características descritas a continuación.

## Descripción del Proyecto

El sistema gestiona tres tipos principales de documentos:

- **Facturas**  
- **Órdenes de Pago**  
- **Pagarés**  

Cada tipo de documento tiene comportamientos únicos en cuanto a descuentos, fechas y estados que definen su ciclo de vida.

## Objetivo del Challenge

El desafío consiste en refactorizar el código y añadir las siguientes funcionalidades clave:

### Funcionalidades Requeridas

1.***Api***
   Exponer las API, para creacion, obtención y cambio de estado. Tener en cuenta la seguridad de los datos de la misma (No es requerido un JWT ni ningun metodo de authenticación)

2. **Persistencia con Base de Datos (Code First)**  
   Implementar el uso de Entity Framework para la persistencia de datos utilizando un enfoque Code First.  

3. **Worker para Documentos Vencidos**  
   Crear un worker que, diariamente, revise los documentos vencidos y actualice su estado correspondiente en el sistema.  

4. **Método para Transición de Estados**  
   Agregar un método que permita cambiar documentos con estado *pendiente* a *negociable*.  

5. **Validaciones**  
   Incluir validaciones robustas para garantizar la integridad de los datos y reglas de negocio.   

6. **Pruebas Unitarias**  
   Desarrollar un conjunto completo de pruebas unitarias para garantizar la funcionalidad y calidad del sistema.  

### Reglas Generales

- Puedes realizar todos los cambios necesarios para mejorar la calidad del código, tanto en términos de legibilidad como de arquitectura y mejoras de negocio (Completa liberta de agregar objetos de dominio si los ven necesarios.)
- Sigue buenas prácticas de desarrollo: patrones de diseño, principios SOLID, y convenciones de nomenclatura.

Crea tu propia version del codigo en git y envialo a mi correo: mariano.batistutti@invoitrade.com
