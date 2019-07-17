using System;
using System.Collections.Generic;
using System.Text;

namespace SGCLI.ApplicationCore.Entity
{
    class Cliente
    {
        public Cliente()
        {

        }

        public int ClienteId { get; set; }
        public int Nome { get; set; }
        public int CPF { get; set; }
    }
}
