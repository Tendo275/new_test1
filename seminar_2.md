# Создание папки по системе контроля версий GIT 

## Как начать
**Чтобы начать работать с ситемой контроля GIT необходимо выполнить следующие комнады:**

```cs
1. git init
```
**используется для начала проекта/таска**

## Примеры:

● init: start youtube-task

● init: start mentor-dashboard task
```cs
2. git feat
```
**это - реализованнаяновая функциональ ность из технического задания (добавил поддержку зумирования, добавил footer, добавил карточку продукта)**

## Примеры:

● feat: add basic page layout

● feat: implement search box

● feat: implement request to youtube API

● feat: implement swipe for horizontal list

● feat: add additional navigation button

● feat: add banner

● feat: add social links

● feat: add physical security section

● feat: add real social icons

```cs
3. git fix
```
**исправил ошибку в ранеереализованной функциональности**

## Примеры:

● fix: implement correct loading data from youtube

● fix: change layout for video items to fix bugs

● fix: relayout header for firefox

● fix: adjust social links for mobile

```cs
4. git refactor
```
**новой функциональности не добавлял/поведениянеменял.Файлы в другие места положил, удалил, добавил. Изменил форматирование кода (white-space, formatting, missing semi-colons, etc). Улучшил алгоритм, без изменения функциональности**

## Примеры:

● refactor: change structure of the project

● refactor: rename vars for better readability

● refactor: apply eslint

● refactor: apply prettier

```cs
5. git docs
```
**используется при работе с документацией/readme проекта**

## Примеры:

● docs: update readme with additional information

● docs: update description of run( ) method

## Создание коммитов:

```cs
git add
```
Добавляет изменения в коммит

```cs
git status
```
Показывает текущий статус

```cs
git reflog
```
Выводит логи того, что происходило с файлов (также можно узнать версии и вернуться к ним)

```cs
git commit - m "ТЕКСТ КОММИТА"
```
позволяет написать комментарий к конкретной версии (рекоммендуется делать после команды "git add")

