using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaLeerArchivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Clave_Nomina");
            dt.Columns.Add("Tipo_Doc");
            dt.Columns.Add("No_Doc");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Primer_Apellido");
            dt.Columns.Add("Segundo_Apellido");
            dt.Columns.Add("Sexo");
            dt.Columns.Add("Fecha_Nacimiento");
            dt.Columns.Add("Salario_Cotizable");
            dt.Columns.Add("Aporte_Voluntario");
            dt.Columns.Add("Salario_ISR");
            dt.Columns.Add("Otras_Remuneraciones");
            dt.Columns.Add("RNC_Cedula");
            dt.Columns.Add("Ingresos_Exentos");
            dt.Columns.Add("Saldo_Favor");
            dt.Columns.Add("Salario_INFOTEP");
            dt.Columns.Add("Tipo_Ingreso");
            // lee linea a linea 
            System.IO.StreamReader file = new System.IO.StreamReader(@"c:\files\Nomina.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] registro = line.Split(',');
                DataRow fila = dt.NewRow();
                fila["Clave_Nomina"] = registro[0];
                fila["Tipo_Doc"] = registro[1];
                fila["No_Doc"] = registro[2];
                fila["Nombre"] = registro[3];
                fila["Primer_Apellido"] = registro[4];
                fila["Segundo_Apellido"] = registro[5];
                fila["Sexo"] = registro [6];
                fila["Fecha_Nacimiento"] = registro[7];
                fila["Salario_Cotizable"] = registro[8];
                fila["Aporte_Voluntario"] = registro[9];
                fila["Salario_ISR"] = registro[10];
                fila["Otras_Remuneraciones"] = registro[11];
                fila["RNC_Cedula"] = registro[12];
                fila["Ingresos_Exentos"] = registro[13];
                fila["Saldo_Favor"] = registro[14];
                fila["Salario_INFOTEP"] = registro[15];
                fila["Tipo_Ingreso"] = registro[16];
                dt.Rows.Add(fila);
            }

            file.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
