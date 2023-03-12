Задача :
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
Описание алгоритма решения:
Объявляем  два массива: изначальный и вторый такой же длины. Затем метод, в котором цикл проходит проверка размерности массива, если элемент массива проходит проверку на размерность (<=3), то элемент первого массива заносится в count элемент второго массива. Переменная count чтобы поочередно закидывать из первого массива во второй. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. 
![Схема](%D1%81%D1%85%D0%B5%D0%BC%D0%B0.png)