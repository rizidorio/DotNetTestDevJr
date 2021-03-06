﻿using System;
using System.Collections.Generic;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task4
    {
        /*
         * Desenvolva um método que retorne todos os estudantes do Repositório que nasceram em 2020      
         * Dica: A classe Repository possui as informções dos Students
         */
        public static List<Student> GetStudentsByBirth() 
        {
            Repository repository = new Repository();

            return repository.Students.FindAll(x => x.Birth.Year == DateTime.Now.Year);
        }
    }
}
