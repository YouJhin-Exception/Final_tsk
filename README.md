# Final Task :hammer:

## **1. Задача:** 
> Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
***
## **2. Описание алгоритма решения:**
**2.1** (**для foreach**)
Сначала объявляется два массива: изначальный и второй [такой же длины] как и первый. Потом используя foreach пробегаю по всем еллементам и сверяю каждый еллемент [item] на его длинну ( <=3 ) если условие выполняется, заносим еллемент во 2й массив, используя [sizeArrayIn] и его итератор для индексов 2го массива.

***
**2.2** (**для обычного for**) 
Сначала объявляется два массива: изначальный и второй [такой же длины] как и первый. Потом метод, в котором используя цикл соразмерный длине первого массива, пробегаем по всем еллементам и проверяем их if-фом на длинну ( <=3 ), если условие выполняется, заносим еллемент во 2й массив, используя [count] и его итератор для индексов 2го массива. 
***
**2.3** (**заполнение <=3**) 
Просим пользователя ввести количество еллементов в массиве, создаем массив указаной длинны. Далее заполняем массив в цикле используя переменную [len] для проверки длинны вводимого эллемента и переменную [pos] и его итерацию для индексов массива.
***

## **3. Блок схема:**
Блок схема метода в папке [**sсheme**](https://github.com/YouJhin-Exception/Final_tsk/tree/main/scheme) :mag: в двух файлах разных расширениях. Для всех решений логика одинаковая. (2.3 добавляется ручное заполнение массива, но логика проверки эллемнта такая же)
***

## **4. Реализация алгоритмов решения:**
Реализация алгоритма по пути **tsk/Program.cs** - или [**жмяк тут**](https://github.com/YouJhin-Exception/Final_tsk/blob/main/tsk/Program.cs) :mag: 
***

