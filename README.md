# Como contribuir al proyecto:
### 1 Hacer fork a este repositorio (Aparece arriba a la derecha)
### 2 Una vez hecho el fork en el directorio donde queramos que esté el proyecto ejecutamos los siguientes comandos en la terminal 
(Click derecho en la carpeta del tp Git Bash Here):
```bash
- git clone <url-de-su-repositorio> (Es importante que sea el que esta en su cuenta y no el original)
- git remote add upstream https://github.com/JoaquinGomez1/Aerolinea-PAV1-GP07
```

## Si todo sale bien ejecutamos:
```bash
 $ git status
```
y debería salirnos que no hay cambios y que el árbol de trabajo está limpio

## Importante:
Siempre que terminemos de hacer cambios ejecutamos los siguientes comandos:
```bash
- $ git add .
- $ git commit -m "<UnMensajeAca>"
- $ git push
```

Antes de empezar a trabajar hay que verificar que no haya cambios que no tengamos en nuestra máquina
Para eso ejecutamos lo siguiente:
```bash
- $ git pull upstream main
```
