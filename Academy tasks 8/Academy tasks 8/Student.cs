using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_tasks_8
{
    class Student
    {
        public string FullName;
        private byte _age=15;

        public byte Age
        {
            set
            {
                if (value>=15)
                {
                    _age = value;
                }
            }
            get
            {
                return _age;
            }
        }
    }
}
