using System;

namespace NETCORE.Entidades
{
    public class Student
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        public Student() => UniqueId = Guid.NewGuid().ToString();
        
    }
}
