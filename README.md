# Practice16.7

## Task

Протестируйте все методы класса `Calculator` с использованием `NUnit-фреймворка`.

    namespace Practices
    {
        public class Calculator
        {
            public int Additional(int a, int b)
            {
                return a + b;
            }

            public int Subtraction(int a, int b)
            {
                return a - b;
            }

            public int Miltiplication(int a, int b)
            {
                return a * b;
            }

            public int Division(int a, int b)
            {
                return a / b;
            }
        }
    }

___
***Описание решения***  

В данном решении были протестированы все методы класса `Calculator` при помощи `NUnit-фреймворка`. Для каждого метода было проведено по 3 теста, проверяющих корректность вычислений. Также для метода `Division` был написан тест, проверяющий исключение `DivideByZeroException` при делении числа на 0.