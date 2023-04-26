using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula09_semi_pre.exemplo3
{
    public interface IAnimalEstimacao
    {
        string Nome { get; set; }    
        Dono dono { get; set; }
    }
}