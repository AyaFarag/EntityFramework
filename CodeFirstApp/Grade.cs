﻿

namespace CodeFirstApp
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }  // one to many // navigation prop
    }
}
