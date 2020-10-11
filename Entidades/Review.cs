using System;

namespace NETCORE.Entidades
{

    public class Review 
    {
        public string UniqueId { get; private set; }
        public string Name { get; set; }

        public Student Student { get; set; }
        public Asignature Asignature  { get; set; }

        public float Note { get; set; }

        public Review() => UniqueId = Guid.NewGuid().ToString();
    }


}