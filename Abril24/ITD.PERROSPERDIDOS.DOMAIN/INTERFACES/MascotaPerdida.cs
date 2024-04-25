using System;

namespace Abril24.ITD.PERROSPERDIDOS.DOMAIN.INTERFACES
{
    public class MascotaPerdida
    {
        public int IdUsuario { get; set; }
        public int Celular { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }
        public string Tamano { get; set; }
        public char Sexo { get; set; }
        public string Caracteristicas { get; set; }
        public DateTime FechaVisto { get; set; }
        public string LugarVisto { get; set; }
        public byte[] Imagen { get; set; }
    }
}
