using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace PF_0030482011029
{
    class Cidade
    {
        private int idcidade;
        private string nomecidade;
        private string ufcidade;

        public int Idcidade
        {
            get
            {
                return idcidade;
            }
            set
            {
                idcidade = value;
            }
        }
        public string Nomecidade
        {
            get
            {
                return nomecidade;
            }
            set
            {
                nomecidade = value;
            }
        }
        public string Ufcidade
        {
            get
            {
                return ufcidade;
            }
            set
            {
                ufcidade = value;
            }
        }

        public DataTable Listar()
        {
            SqlDataAdapter daCidade;
            DataTable dtCidade = new DataTable();
            try
            {
                daCidade = new SqlDataAdapter("SELECT * FROM TB_CIDADE", FRM_PRINCIPAL.conexao);
                daCidade.Fill(dtCidade);
                daCidade.FillSchema(dtCidade, SchemaType.Source);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dtCidade;
        }

        public int Salvar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg;

                mycommand = new SqlCommand("INSERT INTO TB_CIDADE VALUES (@nome_cidade, @uf_cidade)", FRM_PRINCIPAL.conexao);

                mycommand.Parameters.Add(new SqlParameter("@nome_cidade", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade", SqlDbType.VarChar));

                mycommand.Parameters["@nome_cidade"].Value = nomecidade;
                mycommand.Parameters["@uf_cidade"].Value = ufcidade;

                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public int Alterar()
        {
            int retorno = 0;

            try
            {
                SqlCommand mycommand;
                int nReg = 0;

                mycommand = new SqlCommand("UPDATE TB_CIDADE SET nome_cidade = @nome_cidade, uf_cidade = @uf_cidade WHERE id_cidade = @id_cidade", FRM_PRINCIPAL.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@nome_cidade", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@uf_cidade", SqlDbType.Char));

                mycommand.Parameters["@id_cidade"].Value = idcidade;
                mycommand.Parameters["@nome_cidade"].Value = nomecidade;
                mycommand.Parameters["@uf_cidade"].Value = ufcidade;

                nReg = mycommand.ExecuteNonQuery();
                if (nReg > 0)
                {
                    retorno = nReg;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }

        public int Excluir()
        {
            int nReg = 0;

            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("DELETE FROM TB_CIDADE WHERE id_cidade = @id_cidade", FRM_PRINCIPAL.conexao);

                mycommand.Parameters.Add(new SqlParameter("@id_cidade", SqlDbType.Int));

                mycommand.Parameters["@id_cidade"].Value = idcidade;

                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }
    }
}
