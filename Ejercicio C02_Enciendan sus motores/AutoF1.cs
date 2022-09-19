using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02_Enciendan_sus_motores
{
    public class AutoF1
    {
        private short cantidadCombustible;//
        private bool enCompetencia;//
        private string escuderia;
        private short numero;
        private short vueltasRestantes;//

        public AutoF1(string escuderia, short numero)
        {
            this.cantidadCombustible = 0;
            this.enCompetencia =false;
            this.escuderia = escuderia;
            this.numero = numero;
            this.vueltasRestantes = 0;
        }
        #region GETTERS & SETTERS
        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }
        public bool EnCompetencia()
        {
            return this.enCompetencia;
        }
        public short  GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }
        public void SetCantidadCombustible(short cantidad)
        {
            this.cantidadCombustible = cantidad;
        }
        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }
        public void SetVueltasRestantes(short vueltas)
        {
            this.vueltasRestantes = vueltas;
        }
        #endregion

        public string MostrarDatos()
        {
            string sigue = "no";

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de Combustible: {cantidadCombustible}");
            if(enCompetencia)
            {
                sigue = "si";
            }
            sb.AppendLine($"En competencia: {sigue}");
            sb.AppendLine($"Escuderia: {escuderia}");
            sb.AppendLine($"Numero: {numero}");
            sb.AppendLine($"Vueltas restantes: {vueltasRestantes}");
            return sb.ToString();
        }
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            if(auto1.numero == auto2.numero && auto1.escuderia == auto2.escuderia)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }
    }
}
