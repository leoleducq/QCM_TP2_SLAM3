using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QCM
{
    public static class Controleur
    {
        private static Modele vmodele;
        internal static Modele Vmodele { get => vmodele; set => vmodele = value; }
        public static void init()
        {
            vmodele = new Modele();
        }
        
    }
}
