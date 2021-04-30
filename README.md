# Como contribuir al proyecto:
### 1 Hacer fork a este repositorio (Aparece arriba a la derecha)
### 2 Una vez hecho el fork en el directorio donde queramos que esté el proyecto ejecutamos los siguientes comandos en la terminal 
(Click derecho en la carpeta del tp > Git Bash Here):
```bash
 git clone <url-de-su-repositorio> 
 git init
 git remote add -u https://github.com/JoaquinGomez1/Aerolinea-PAV1-GP07
 git remote add -u <url-de-su-repositorio> 
```
para la url de su repositorio es importante que sea el que esta en su cuenta y no el original.
para saber cual es la url van a su perfil en GitHub > Repositorios > abren el ultimo > copian la dirección del navegador

## Si todo sale bien ejecutamos:
```bash
 git status
```
y debería salirnos que no hay cambios y que el árbol de trabajo está limpio

## Importante:
Antes de empezar a trabajar hay que verificar que no haya cambios que no tengamos en nuestra máquina
Para eso ejecutamos lo siguiente:
```bash
 git pull
```
Es posible que Git nos pida que guardemos los cambios en un commit antes de hacer pull.
Esto pasa porque se necesita tener guardados nuestros cambios en el entorno local antes de
intentar traer y fusionar las cosas que están en el repositorio original

Para poder "guardar" los cambios en nuestra máquina necesitamos hacer un commit ejecutando los siguientes comandos
```bash
 git add .
 git commit -m "<UnMensajeAca>"
```

Si el error nos indica 
```bash
 git remote -v
```

y verificar que el link del repositorio que figura sea este.

Siempre que terminemos de hacer cambios ejecutamos los siguientes comandos:
```bash
 git add .
 git commit -m "<UnMensajeAca>" (por ejemplo "cambie aerOlimpo por aeroPuto")
 git push
```

Luego vamos a GitHub > van a su perfil > repositories > Aerolinea-PAV1-GP07-1 > Pull requests > New Pull request > Create Pull Request > Si se quiere se puede agregar un comentario de los cambios que se hizo > Create pull request

Una vez que se acepta el Pull request te llega un mail con la confirmacion y se actualiza el codigo para todos.

### <span style="color:blue">Aclaración: </span>
 Git es una herramienta con muchos beneficios pero que es necesario entender algunas cosas basicas para poder empezar a usarlo adecuadamente.
 vamos a dejar a disposición la [guia oficial](https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository) de Git en la que todos van a poder encontrar mas de una respuesta a algún problema que estén teniendo
 

