using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8_Generics
{
    public class Pair<S,T>
    {
        public T Password { get; }
        public S Id { get; }

        public Pair(T password, S id)
        {
            Password = password;
            Id = id;
        }
    }
}
