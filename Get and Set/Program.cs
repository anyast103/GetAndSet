﻿using System;
using System.Collections.Generic;

namespace Get_and_Set
{
    class Program
    {

        // get - позволяет читать переменную.
        // set - позволяет установить значение переменной.

        
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.PrintStudents();
            
            
        }

    }

    class Student
    {
        private string name; // Имя студента (это поле)
        private int course; // Курс (и это поле)
        private bool stipend; // Наличие стипендии (это тоже поле)

        public Student(string Name, int Course, bool Stipend)  // Здесь мы берём значения, определённые в полях.
            // То есть, без этого конструктора приватные поля использовать мы не можем.
        {
            this.name = Name;
            this.course = Course;
            this.stipend = Stipend;
        }

        // Мы используем уровень защиты private, так как эти поля фигурируют только в этом классе.

        public int Course // Благодаря конструктору мы можем устанавливать определённые значения и условия к ним для
            // наших переменных. 
        {
            get { return course;}  // Мы читаем значение поля, которое указано в конструкторе ниже (просто пример).

            set
            {
                if (value < 1) // Нулевого курса не бывает, поэтому, если курс был указан меньше чем 1, по дефолту
                    // выводится Курс 1
                    course = 1;
                else if (value > 5) // Аналогично, только с 6 и выше курсом.
                    course = 5;
                else
                    course = value;

            }
        }
        public Student() // Мы инициализируем одного из студентов. Можно поэкспериментировать и поменять значение курса.
            // Кстати, если указать set как приватный, или вовсе его не использовать, в других классах задать
            // курс не получится.
            // **Примечание: В данном конструкторе проверка course не проводится. Она проводится только тогда,
            // когда мы в другом методе хотим изменить значение course.
        {
            name = "Иван";
            course = 1;
            stipend = true;
            
        }

        public void PrintStudents()  // Просто вывод данных.
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("Курс: " + course);
            Console.WriteLine("Стипендия: " + stipend);
        }

        // Так же мы можем использовать get и set без проверок и прочего. Если мы хотим, чтобы наше поле нигде не
        // изменялось, мы ставим аксессору set модификатор private, а если же мы хотим изменять, но не хотим,
        // чтобы поле читалось (выводилось), аксессору get мы ставим модификатор private.
    }
}
