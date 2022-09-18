using System.Text;

namespace Ejercicio_I03_AContarPalabras
{
    public partial class ContadorPalabras : Form
    {
        Dictionary<string, int> diccionario;// el string es la palabra y el int la cantidad de veces que se repite
        public ContadorPalabras()
        {
            InitializeComponent();
            diccionario = new Dictionary<string, int>();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            string texto = rtxb1.Text.ToLower();
            string[] palabras = texto.Split(' ');

            foreach(string palabra in palabras)
            {
                if (!(string.IsNullOrWhiteSpace(palabra)))
                {
                    if (diccionario.ContainsKey(palabra))
                    {
                        diccionario[palabra]++;
                    }
                    else
                    {
                        diccionario.Add(palabra, 1);
                    }
                }
            }
            List<KeyValuePair<string, int>> listadoPalabras = diccionario.ToList();
            listadoPalabras.Sort(OrdenarContadorPalabras);
            int i = 0;
            StringBuilder sb = new StringBuilder();
            if(listadoPalabras.Count != 0)
            {
                foreach (var palabra in listadoPalabras)
                {
                    i++;
                    if (i < 4)
                    {
                        sb.AppendLine($"Palabra: {palabra.Key}\nCantidad de apariciones: {palabra.Value}");
                    }
                }
                MessageBox.Show(sb.ToString());
            }
            else
            {
                MessageBox.Show("No se ingresaron Palabras");
            }
            
        }
        public static int OrdenarContadorPalabras(KeyValuePair<string, int> p1, KeyValuePair<string, int> p2)
        {
            return p2.Value - p1.Value;
        }
    }
}