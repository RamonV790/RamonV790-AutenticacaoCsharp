﻿using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAuteticacao.Classes
{
    public class Conexao
    {

        public static SqlConnection _conn;

        public static SqlConnection MinhaInstancia
        { //a chave da propriedade
            get
            { // chave do método get
              //se não existe conexão.
                if (_conn == null)
                { // chave do if
                    _conn = new SqlConnection(@"Server = Lab206_7\SQLEXPRESS; Database = ProjetoEstoquev; Uid = sa; Pwd = teste*123;");
                } // fecha chave do if
                  //retorna a conexão
                return _conn;
            }
        }
    }
}
