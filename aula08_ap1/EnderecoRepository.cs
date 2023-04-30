using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula08_ap1{
    

    public class EnderecosRepository
    {
        private List<Enderecos> _enderecos;

        public EnderecosRepository()
        {
            _enderecos = new List<Enderecos>();
        }

        public void Add(Enderecos endereco)
        {
            _enderecos.Add(endereco);
        }

        public void Remove(Enderecos endereco)
        {
            _enderecos.Remove(endereco);
        }
    }
}
