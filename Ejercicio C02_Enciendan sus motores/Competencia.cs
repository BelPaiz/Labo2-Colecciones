using System.Text;

namespace Ejercicio_C02_Enciendan_sus_motores
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVuletas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            cantidadCompetidores = 0;
            cantidadVuletas = 0;
            competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVuletas): this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVuletas = cantidadVuletas;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de Competidores: {cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {cantidadVuletas}");
            foreach(AutoF1 auto in competidores)
            {
                sb.AppendLine($"Competidores: {auto.MostrarDatos()}");
            }
            return sb.ToString();
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            foreach(AutoF1 auto in c.competidores)
            {
                if(auto == a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            Random rand = new Random();
          
            if(c.competidores.Count < c.cantidadCompetidores && c!= a)
            {
                c.competidores.Add(a);
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVuletas);
                a.SetCantidadCombustible((short)rand.Next(15, 100));
                return true;
            }
            return false;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            if(c==a)
            {
                c.competidores.Remove(a);
                return true;
            }
            return false;
        }
    }
}