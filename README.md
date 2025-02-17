# Inventario de Productos en C#

Este proyecto es una aplicación de consola en C# para gestionar un inventario de productos. Permite agregar, eliminar, actualizar y listar productos, almacenando la información en un archivo JSON.

## Características

✅ Agregar productos con un identificador único, nombre, cantidad y precio.
✅ Eliminar productos del inventario por ID.
✅ Actualizar los datos de un producto existente.
✅ Listar todos los productos guardados en el inventario.
✅ Guardado automático en un archivo JSON.

## Requisitos

- .NET 6 o superior
- Newtonsoft.Json (para manejar JSON)

## Instalación

1. Clona este repositorio o descarga los archivos.
```sh
 git clone 
```
2. Abre el proyecto en Visual Studio o Visual Studio Code.
3. Asegúrate de tener instalada la biblioteca **Newtonsoft.Json**:
```sh
 dotnet add package Newtonsoft.Json
```
4. Compila y ejecuta el programa:
```sh
 dotnet run
```

## Uso

Al ejecutar el programa, podrás ingresar comandos en la consola:

### Agregar un producto
```sh
Comando: agregar
Nombre del producto: Laptop
Cantidad: 5
Precio: 1200.50
Producto agregado.
```

### Listar productos
```sh
Comando: listar
1 - Laptop (Cantidad: 5, Precio: 1200.50)
```

### Actualizar un producto
```sh
Comando: actualizar
Ingrese el ID del producto a actualizar: 1
Nuevo nombre: Laptop Gamer
Nueva cantidad: 3
Nuevo precio: 1500.00
Producto actualizado.
```

### Eliminar un producto
```sh
Comando: eliminar
Ingrese el ID del producto a eliminar: 1
Producto eliminado.
```

### Salir del programa
```sh
Comando: salir
Saliendo...
```

## Archivo JSON

Los productos se guardan en un archivo `productos.json`, con el siguiente formato:
```json
[
  {
    "Id": 1,
    "Nombre": "Laptop Gamer",
    "Cantidad": 3,
    "Precio": 1500.00
  }
]
```

## Autor
Desarrollado por Andder Frias 🚀

