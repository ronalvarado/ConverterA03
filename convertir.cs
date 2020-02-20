using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_A
{
	class convertir
	{
		public string[] Tipo = { "Dinero", "Longitud", "Peso", "Almacenamiento", "Volumen" };
		public string[][] Versiones =
		{
			new string [] {"Dolar","Colones(SV)","Yenes","Rupias","Lempiras", "Peso MX","BitCoin", "Quetzal", "Euro","Cordoba","Balboa","Peso Argentino", "Peso Chileno", "Peso Colombiano", "Soles(Peru)", "Dolar Canadiense", "Dolar Beliceño"},
			new string [] {"Metro", "Cm", "Pulgada", "pie", "Varas","Yardas","Km","Millas", "Milimetro","MicroMetro", "NanoMetro"},
			new string [] {"Kilogramo","Gramo","Miligramo","MicroGramo","Libra","Onza", "Tonelada", "Stone"},
			new string [] {"MegaBytes", "KiloBytes", "GigaBytes", "TeraBytes", "PentaBytes", "ExaBytes", "Bit", "Byte"},
			new string [] {"Litro", "MiliLitro", "Metro Cubico", "Galon", "Pie Cubico", "Taza Americana"},
		};
		double[][] valor =
		{
			new double[] { 1, 8.75, 111.26, 69.75, 24.36, 19.36, 0.00026, 7.69, 0.88,32.95,1.00,39.95, 667.65, 3126.73,3.30, 1.33, 2.02 },
			new double[] { 1, 100, 39.3701, 3.28084, 1.1963081929167, 1.09361, 0.001, 0.000621371, 1000, 1e+6, 1e+9 },
			new double[] {1, 1000, 1e+6 , 1e+9, 2.20462, 35.274, 0.001, 0.157473 },
			new double[] {1, 1024, 9.77e-4, 9.54e-7, 9.31e-10, 9.09e-13, 8e+6, 1e+6},
			new double[] {1, 1000, 0.001, 0.264172, 0.0353147, 4.167 },
		};
		public double convert(int de, int a, double cantidad, int opcion)
		{
			return Math.Round(valor[opcion][a] / valor[opcion][de] * cantidad, 2);
		}
	}
}
