using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LIB_ENTIDAD
{
    class cls_compra
    {
        //CABECERA
        public int cod_com;
        public string com_prov;
        public int cod_tdoc;
        public string com_doc;
        public DateTime com_fec;
        public double com_total;

        //DETALLES
        public string cod_pro;
        public int dcom_can;
        public double dcom_puni;
        public double dcom_neto;
    }
}
