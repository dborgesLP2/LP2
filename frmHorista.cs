using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnInstanciarHorista_Click(object sender, EventArgs e)
        {
            // instanciando o objeto da classe horista
            Horista objHorista = new Horista();

            //set - atribui valores para o objeto
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalario.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtnHoras.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFaltas.Text);
            //get - imprime os valores do objeto
            MessageBox.Show("Nome:" + objHorista.NomeEmpregado +
            "\n" + "Matrícula:" + objHorista.Matricula + "\n" +
            "Tempo Trabalho (dias) :" + objHorista.TempoTrabalho().ToString()
            + "\n" + "Salário:" + objHorista.SalarioBruto().ToString("N2"));
        }
    }
    }

