Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Решение:
- создаю строковый массив, определяя его размер вводом с клавиатуры;
- заполняю массив вводом с клавиатуры;
- с помощью цикла for рассчитываю количество элементов массива длинной менее 4х символов и присваиваю это значение переменной size2;
- создаю второй строковый массив длиной равной size2;
- с помощью цикла for прохожу по элементам первого массива и запивываю элементы длинной менее 4х символов во второй массив;
- вывожу на печать второй массив.
