using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB_ENTIDAD
{
    class cls_venta
    {
        //CABECERA
        public int cod_ven;
        public string ven_cli;
        public DateTime ven_fec;
        public int cod_tdoc;
        public string ven_doc;        
        public double ven_total;

        //DETALLES
        public string cod_pro;
        public int dven_can;
        public double dven_puni;
        public double dven_neto;
        public double dven_des;
    }
}
