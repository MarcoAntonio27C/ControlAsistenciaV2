using System;
using System.Collections.Generic;
using System.Text;

namespace ControlAsistencia_.Models
{
    public class ComboboxValue
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public ComboboxValue(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
