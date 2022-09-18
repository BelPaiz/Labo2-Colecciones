using System.Text;

namespace Ejercicio_C01_Estadística_deportiva
{
    public class Jugador
    {
        private int _dni;
        private string _nombre;
        private int _partidosJugados;
        private float _promedioGoles;
        private int _totalGoles;

        //TODO : 1 - constructores uno vacio
        private Jugador()
        {
            _partidosJugados = 0;
            _totalGoles = 0;
            _promedioGoles = 0;
        }
        //TODO : 2 - constructores dni, nombre
       public Jugador(int dni, string nombre) : this()
        {
            _dni = dni;
            _nombre = nombre;
        }
        //TODO : 3 - constructores total goles, total partidos
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            _totalGoles = totalGoles;
            _partidosJugados = totalPartidos;
        }
        public float GetPromedioGoles()
        {
            if(_partidosJugados > 0)
            {
                _promedioGoles = (float)_totalGoles / _partidosJugados;
                return _promedioGoles;
            }
            return 0;
            
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre:  {_nombre}");
            sb.AppendLine($"Dni:  {_dni}");
            sb.AppendLine($"Partidos Jugados:  {_partidosJugados}");
            sb.AppendLine($"Total de goles:  {_totalGoles}");
            sb.AppendLine($"Promedio de goles:  {GetPromedioGoles()}");
            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if(j1 is not null && j2 is not null)
            {
                return j1._dni == j2._dni;
            }
            return false;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }


    }
}