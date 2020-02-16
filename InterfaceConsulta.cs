using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop {
    interface InterfaceConsulta {
        DataTable consultaServicosPorOS(int OS);
        ArrayList consultarOS(String dataInicio, String dataFim);
        ArrayList consultarOSporCPF(long cpf);
        ArrayList consultarOS(int OS);
        int consultaIdAnimal(long CPF, String nomeAnimal);
        DataTable buscarServico(String descr);

    }
}
